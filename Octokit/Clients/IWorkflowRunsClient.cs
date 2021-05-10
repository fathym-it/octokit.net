using System.Threading.Tasks;

namespace Octokit
{
    public interface IWorkflowRunsClient
    {
        /// <summary>
        /// Lists all workflow runs for a repository
        /// </summary>
        /// <param name="repositoryId">Id of the repository</param>
        Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId);
        /// <summary>
        /// Lists all workflow runs for a repository
        /// </summary>
        /// <param name="repositoryId">Id of the repository</param>
        /// <param name="request">Used to filter and sort the list of workflow runs returned</param>
        Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId, WorkflowRunsRequest request);
        /// <summary>
        /// Lists all workflow runs for a repository
        /// </summary>
        /// <param name="repositoryId">Id of the repository</param>
        /// <param name="request">Used to filter and sort the list of workflow runs returned</param>
        /// <param name="options">Options for changing the API response</param>
        Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId, WorkflowRunsRequest request, ApiOptions options);

        /// <summary>
        /// Lists all workflow runs for a repository
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name);
        /// <summary>
        /// Lists all workflow runs for a repository
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="request">Used to filter and sort the list of workflow runs returned</param>
        Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name, WorkflowRunsRequest request);
        /// <summary>
        /// Lists all workflow runs for a repository
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="request">Used to filter and sort the list of workflow runs returned</param>
        /// <param name="options">Options for changing the API response</param>
        Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name, WorkflowRunsRequest request, ApiOptions options);

        /// <summary>
        /// List all workflow runs for a workflow. You can replace workflow_id with the workflow file name. For example, you could use main.yaml. You can use parameters to narrow the list of results. For more information about using parameters, see Parameters.
        /// Anyone with read access to the repository can use this endpoint.If the repository is private you must use an access token with the repo scope.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-workflow-runs
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowRunsResponse> List(string owner, string repository, string workflowId, WorkflowRunsRequest request = null);

        /// <summary>
        /// List all workflow runs for a workflow. You can replace workflow_id with the workflow file name. For example, you could use main.yaml. You can use parameters to narrow the list of results. For more information about using parameters, see Parameters.
        /// Anyone with read access to the repository can use this endpoint.If the repository is private you must use an access token with the repo scope.
        /// </summary>
        /// <remarks>
        /// https://docs.github.com/en/rest/reference/actions#list-workflow-runs
        /// </remarks>
        /// <param name="owner">The name of the owner</param>
        /// <param name="repository">The name of the repository</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="options">Options for changing the API response</param>
        /// <param name="request">The additional pararmeters for the request</param>
        Task<WorkflowRunsResponse> List(string owner, string repository, string workflowId, ApiOptions options, WorkflowRunsRequest request = null);
    }
}
