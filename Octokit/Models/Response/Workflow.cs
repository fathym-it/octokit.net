using System;
using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Workflow
    {
        public Workflow()
        {
        }

        public Workflow(
            long id, string nodeId, string name, string path, string state, string url,
            string htmlUrl, string badgeUrl, DateTimeOffset createdAt, DateTimeOffset updatedAt)
        {
            Id = id;
            NodeId = nodeId;
            Name = name;
            Path = path;
            State = state;
            Url = url;
            HtmlUrl = htmlUrl;
            BadgeUrl = badgeUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public long Id { get; protected set; }
        public string NodeId { get; protected set; }
        public string Name { get; protected set; }
        public string Path { get; protected set; }
        public string State { get; protected set; }
        public string Url { get; protected set; }
        public string BadgeUrl { get; protected set; }
        public string HtmlUrl { get; protected set; }
        public DateTimeOffset CreatedAt { get; protected set; }
        public DateTimeOffset UpdatedAt { get; protected set; }
        internal string DebuggerDisplay
            => $"Id: {Id}, NodeId: {NodeId}, Name: {Name}, Path: {Path}, State: {State}";
    }
}
