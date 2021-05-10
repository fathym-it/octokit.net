using System;
using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowArtifact
    {
        public WorkflowArtifact()
        {
        }

        public WorkflowArtifact(
            long id, string nodeId, string name, long sizeInBytes, bool expired, string url,
            string archiveDownloadUrl, DateTimeOffset createdAt, DateTimeOffset expiresAt, DateTimeOffset updatedAt)
        {
            Id = id;
            NodeId = nodeId;
            Name = name;
            SizeInBytes = sizeInBytes;
            Expired = expired;
            Url = url;
            ArchiveDownloadUrl = archiveDownloadUrl;
            CreatedAt = createdAt;
            ExpiresAt = expiresAt;
            UpdatedAt = updatedAt;
        }

        public long Id { get; protected set; }
        public string NodeId { get; protected set; }
        public string Name { get; protected set; }
        public long SizeInBytes { get; protected set; }
        public bool Expired { get; protected set; }
        public string Url { get; protected set; }
        public string ArchiveDownloadUrl { get; protected set; }
        public DateTimeOffset CreatedAt { get; protected set; }
        public DateTimeOffset ExpiresAt { get; protected set; }
        public DateTimeOffset UpdatedAt { get; protected set; }
        internal string DebuggerDisplay
            => $"Id: {Id}, NodeId: {NodeId}, Name: {Name}, SizeInBytes: {SizeInBytes}, Expired: {Expired}";
    }
}
