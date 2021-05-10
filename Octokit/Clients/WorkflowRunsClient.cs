using System;
using System.Linq;
using System.Threading.Tasks;

namespace Octokit
{
    public class WorkflowRunsClient : ApiClient, IWorkflowRunsClient
    {
        public WorkflowRunsClient(IApiConnection apiConnection)
            : base(apiConnection)
        {
        }

        public Task<WorkflowRunsResponse> ListForRepository(long repositoryId)
            => ListForRepository(repositoryId, new WorkflowRunsRequest(), ApiOptions.None);

        public Task<WorkflowRunsResponse> ListForRepository(long repositoryId, WorkflowRunsRequest request)
        {
            Ensure.ArgumentNotNull(request, nameof(request));
            return ListForRepository(repositoryId, request, ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> ListForRepository(long repositoryId, WorkflowRunsRequest request, ApiOptions options)
        {
            Ensure.ArgumentNotNull(request, nameof(request));
            Ensure.ArgumentNotNull(options, nameof(options));

            return RequestAndReturnWorkflowRunsResponse(ApiUrls.WorkflowRunsForRepository(repositoryId), request, options);
        }

        public Task<WorkflowRunsResponse> ListForRepository(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return ListForRepository(owner, name, new WorkflowRunsRequest(), ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> ListForRepository(string owner, string name, WorkflowRunsRequest request)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(request, nameof(request));

            return ListForRepository(owner, name, request, ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> ListForRepository(string owner, string name, WorkflowRunsRequest request, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(request, nameof(request));
            Ensure.ArgumentNotNull(options, nameof(options));

            return RequestAndReturnWorkflowRunsResponse(ApiUrls.WorkflowRunsForRepository(owner, name), request, options);
        }

        public Task<WorkflowRunsResponse> List(string owner, string repository, string workflowId, WorkflowRunsRequest request = null)
        {
            return List(owner, repository, workflowId, ApiOptions.None, request: request);
        }

        public Task<WorkflowRunsResponse> List(string owner, string repository, string workflowId, ApiOptions options,
            WorkflowRunsRequest request = null)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowRunList(owner, repository, workflowId);

            return RequestAndReturnWorkflowRunsResponse(uri, request, options);
        }

        private async Task<WorkflowRunsResponse> RequestAndReturnWorkflowRunsResponse(Uri uri, WorkflowRunsRequest request, ApiOptions options)
        {
            var results = await ApiConnection.GetAll<WorkflowRunsResponse>(uri, request.ToParametersDictionary(), options);
            return new WorkflowRunsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.WorkflowRuns).ToList());
        }
    }
}
