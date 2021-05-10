using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowResponse
    {
        public WorkflowResponse()
        {
        }

        public WorkflowResponse(Workflow workflow)
        {
            Workflow = workflow;
        }

        public Workflow Workflow { get; protected set; }

        internal string DebuggerDisplay
            => $"Workflow: {Workflow.DebuggerDisplay}";
    }
}
