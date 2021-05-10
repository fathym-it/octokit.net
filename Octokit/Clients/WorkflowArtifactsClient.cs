using System.Linq;
using System.Threading.Tasks;

namespace Octokit
{
    public class WorkflowArtifactsClient : ApiClient, IWorkflowArtifactsClient
    {
        public WorkflowArtifactsClient(IApiConnection apiConnection)
            : base(apiConnection)
        { }

        public Task<byte[]> Download(string owner, string repository, long artifactId)
        {
            return Download(owner, repository, artifactId, ApiOptions.None);
        }

        public async Task<byte[]> Download(string owner, string repository, long artifactId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowArtifactDownload(owner, repository, artifactId);

            var response = await ApiConnection.GetRaw(uri, null);

            return response;
        }

        public Task<WorkflowArtifactsResponse> List(string owner, string repository, WorkflowListRequest request = null)
        {
            return List(owner, repository, ApiOptions.None, request: request);
        }

        public async Task<WorkflowArtifactsResponse> List(string owner, string repository, ApiOptions options, WorkflowListRequest request = null)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowArtifactList(owner, repository);

            var results = await ApiConnection.GetAll<WorkflowArtifactsResponse>(uri, request?.ToParametersDictionary(), options);

            return new WorkflowArtifactsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.Artifacts).ToList());
        }

        public Task<WorkflowArtifactsResponse> ListForRun(string owner, string repository, string runId, WorkflowListRequest request = null)
        {
            return ListForRun(owner, repository, runId, ApiOptions.None, request: request);
        }

        public async Task<WorkflowArtifactsResponse> ListForRun(string owner, string repository, string runId, ApiOptions options, 
            WorkflowListRequest request = null)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var uri = ApiUrls.WorkflowArtifactListForRun(owner, repository, runId);

            var results = await ApiConnection.GetAll<WorkflowArtifactsResponse>(uri, request?.ToParametersDictionary(), options);

            return new WorkflowArtifactsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.Artifacts).ToList());
        }
    }
}
