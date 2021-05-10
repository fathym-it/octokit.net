using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowUsageResponse
    {
        public WorkflowUsageResponse()
        {
        }

        public WorkflowUsageResponse(IDictionary<string,  WorkflowUsageTiming> billable)
        {
            Billable = billable;
        }

        public IDictionary<string,  WorkflowUsageTiming> Billable { get; protected set; }

        internal string DebuggerDisplay
            => $"Billable: {string.Join(", ", Billable.Select(b => $"{b.Key}: {b.Value.DebuggerDisplay}"))}";
    }
}
