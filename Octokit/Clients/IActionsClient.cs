namespace Octokit
{
    public interface IActionsClient
    {
        /// <summary>
        /// Client for managing workflow runs
        /// </summary>
        IWorkflowsClient Workflow { get; }
    }
}
