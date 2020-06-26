﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Repository Actions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/actions">Repository Actions API documentation</a> for more details.
    /// </remarks>
    public interface IRepositoryActionsClient
    {
        /// <summary>
        /// Client for GitHub's Repository Actions API
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/actions/">Deployments API documentation</a> for more details
        /// </remarks>
        IRepositorySecretsClient Secrets { get; }
    }
}
