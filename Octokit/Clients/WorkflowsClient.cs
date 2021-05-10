using System;
using System.Linq;
using System.Threading.Tasks;

namespace Octokit
{
    public class WorkflowsClient : ApiClient, IWorkflowsClient
    {
        public IWorkflowArtifactsClient Artifact { get; }

        public IWorkflowRunsClient Run { get; }

        public WorkflowsClient(IApiConnection apiConnection)
            : base(apiConnection)
        {
            Artifact = new WorkflowArtifactsClient(apiConnection);

            Run = new WorkflowRunsClient(apiConnection);
        }

        public Task Disable(string owner, string repository, string workflowId)
        {
            return Disable(owner, repository, workflowId, ApiOptions.None);
        }

        public async Task Disable(string owner, string repository, string workflowId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowDisable(owner, repository, workflowId.UriEncode());

            await ApiConnection.Put(uri);
        }

        public Task Enable(string owner, string repository, string workflowId)
        {
            return Enable(owner, repository, workflowId, ApiOptions.None);
        }

        public async Task Enable(string owner, string repository, string workflowId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowEnable(owner, repository, workflowId.UriEncode());

            await ApiConnection.Put(uri);
        }

        public Task<WorkflowsResponse> List(string owner, string repository, WorkflowListRequest request = null)
        {
            return List(owner, repository, ApiOptions.None, request: request);
        }

        public async Task<WorkflowsResponse> List(string owner, string repository, ApiOptions options, WorkflowListRequest request = null)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowList(owner, repository);

            var results = await ApiConnection.GetAll<WorkflowsResponse>(uri, request?.ToParametersDictionary(), options);

            return new WorkflowsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.Workflows).ToList());
        }

        public Task<WorkflowUsageResponse> Usage(string owner, string repository)
        {
            return Usage(owner, repository, ApiOptions.None);
        }

        public async Task<WorkflowUsageResponse> Usage(string owner, string repository, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowList(owner, repository);

            var results = await ApiConnection.Get<WorkflowUsageResponse>(uri);

            return new WorkflowUsageResponse(results.Billable);
        }
    }
}
