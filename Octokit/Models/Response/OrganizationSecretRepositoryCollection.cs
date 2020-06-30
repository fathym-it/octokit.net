﻿using Octokit.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Octokit
{
    /// <summary>
    /// Represents response of the repositories for a secret in an organization.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class OrganizationSecretRepositoryCollection
    {
        public OrganizationSecretRepositoryCollection()
        {
        }

        public OrganizationSecretRepositoryCollection(int count, IReadOnlyList<Repository> repositories)
        {
            Count = count;
            Repositories = repositories;
        }

        /// <summary>
        /// The total count of repositories with visibility to the secret in the organization
        /// </summary>
        [Parameter(Key = "total_count")]
        public int Count { get; }

        /// <summary>
        /// The list of repositories with visibility to the secret in the organization
        /// </summary>
        [Parameter(Key = "repositories")]
        public IReadOnlyList<Repository> Repositories { get; }

        internal string DebuggerDisplay => string.Format(CultureInfo.CurrentCulture, "OrganizationSecretRepositoryCollection: Count: {0}", Count);
    }
}
