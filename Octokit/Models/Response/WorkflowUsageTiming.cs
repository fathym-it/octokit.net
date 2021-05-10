using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowUsageTiming
    {
        public WorkflowUsageTiming()
        {
        }

        public WorkflowUsageTiming(long totalMs)
        {
            TotalMs = totalMs;
        }

        public long TotalMs { get; protected set; }

        internal string DebuggerDisplay
            => $"TotalMs: {TotalMs}";
    }
}
