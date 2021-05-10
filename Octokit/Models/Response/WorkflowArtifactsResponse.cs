using System.Collections.Generic;
using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowArtifactsResponse
    {
        public WorkflowArtifactsResponse()
        {
        }

        public WorkflowArtifactsResponse(int totalCount, IReadOnlyList<WorkflowArtifact> workflowArtifacts)
        {
            TotalCount = totalCount;
            Artifacts = workflowArtifacts;
        }

        public int TotalCount { get; protected set; }

        public IReadOnlyList<WorkflowArtifact> Artifacts { get; protected set; }

        internal string DebuggerDisplay
            => $"TotalCount: {TotalCount}, Artifacts: {Artifacts.Count}";
    }
}
