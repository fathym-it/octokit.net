using System.Threading.Tasks;

namespace Octokit
{
    public interface IWorkflowsClient
    {
        /// <summary>
        /// Client for managing workflow runs
        /// </summary>
        IWorkflowArtifactsClient Artifact { get; }

        /// <summary>
        /// Client for managing workflow runs
        /// </summary>
        IWorkflowRunsClient Run { get; }

        /// <summary>
        /// Disables a workflow and sets the state of the workflow to disabled_manually. You can replace workflow_id with the workflow file name. For example, you could use main.yaml.
        /// You must authenticate using an access token with the repo scope to use this endpoint. GitHub Apps must have the actions:write permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#disable-a-workflow
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        Task Disable(string owner, string repository, string workflowId);

        /// <summary>
        /// Disables a workflow and sets the state of the workflow to disabled_manually. You can replace workflow_id with the workflow file name. For example, you could use main.yaml.
        /// You must authenticate using an access token with the repo scope to use this endpoint. GitHub Apps must have the actions:write permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#disable-a-workflow
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="options">Options for changing the API response</param>
        Task Disable(string owner, string repository, string workflowId, ApiOptions options);

        /// <summary>
        /// Enables a workflow and sets the state of the workflow to active. You can replace workflow_id with the workflow file name. For example, you could use main.yaml.
        /// You must authenticate using an access token with the repo scope to use this endpoint. GitHub Apps must have the actions:write permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#enable-a-workflow
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        Task Enable(string owner, string repository, string workflowId);

        /// <summary>
        /// Enables a workflow and sets the state of the workflow to active. You can replace workflow_id with the workflow file name. For example, you could use main.yaml.
        /// You must authenticate using an access token with the repo scope to use this endpoint. GitHub Apps must have the actions:write permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#enable-a-workflow
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="options">Options for changing the API response</param>
        Task Enable(string owner, string repository, string workflowId, ApiOptions options);

        /// <summary>
        /// Lists the workflows in a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token
        /// with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-repository-workflows
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowsResponse> List(string owner, string repository, WorkflowListRequest request = null);

        /// <summary>
        /// Lists the workflows in a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token
        /// with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-repository-workflows
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowsResponse> List(string owner, string repository, ApiOptions options, WorkflowListRequest request = null);

        /// <summary>
        /// Gets the number of billable minutes used by a specific workflow during the current billing cycle. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see "Managing billing for GitHub Actions".
        /// You can replace workflow_id with the workflow file name. For example, you could use main.yaml. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#get-workflow-usage
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        Task<WorkflowUsageResponse> Usage(string owner, string repository);

        /// <summary>
        /// Gets the number of billable minutes used by a specific workflow during the current billing cycle. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see "Managing billing for GitHub Actions".
        /// You can replace workflow_id with the workflow file name. For example, you could use main.yaml. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the repo scope. GitHub Apps must have the actions:read permission to use this endpoint.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#get-workflow-usage
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        Task<WorkflowUsageResponse> Usage(string owner, string repository, ApiOptions options);
    }
}
