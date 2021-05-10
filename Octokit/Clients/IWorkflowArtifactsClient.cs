using System.Threading.Tasks;

namespace Octokit
{
    public interface IWorkflowArtifactsClient
    {
        /// <summary>
        /// Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for Location: in the response header to find the URL for the download. The :archive_format must be zip. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#download-an-artifact
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="artifactId">The id of the artifact</param>
        Task<byte[]> Download(string owner, string repository, long artifactId);

        /// <summary>
        /// Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for Location: in the response header to find the URL for the download. The :archive_format must be zip. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#download-an-artifact
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="artifactId">The id of the artifact</param>
        /// <param name="options">Options for changing the API response</param>
        Task<byte[]> Download(string owner, string repository, long artifactId, ApiOptions options);

        /// <summary>
        /// Lists all artifacts for a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-artifacts-for-a-repository
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowArtifactsResponse> List(string owner, string repository, WorkflowListRequest request = null);

        /// <summary>
        /// Lists all artifacts for a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-artifacts-for-a-repository
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowArtifactsResponse> List(string owner, string repository, ApiOptions options, WorkflowListRequest request = null);

        /// <summary>
        /// Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-workflow-run-artifacts
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="runId">The name of the run id</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowArtifactsResponse> ListForRun(string owner, string repository, string runId, WorkflowListRequest request = null);

        /// <summary>
        /// Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-workflow-run-artifacts
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="runId">The name of the run id</param>
        /// <param name="options">Options for changing the API response</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowArtifactsResponse> ListForRun(string owner, string repository, string runId, ApiOptions options, WorkflowListRequest request = null);
    }
}
