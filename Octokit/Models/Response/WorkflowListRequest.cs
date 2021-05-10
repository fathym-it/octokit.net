using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowListRequest : RequestParameters
    {
        /// <summary>
        /// Results per page (max 100).
        /// </summary>
        public int PerPage { get; protected set; }

        /// <summary>
        /// Page number of the results to fetch.
        /// </summary>
        public int Page { get; protected set; }

        internal string DebuggerDisplay 
            => $"Page: {Page}, PerPage: {PerPage}";
    }
}
