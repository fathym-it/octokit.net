﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Enterprise Management Console API
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/enterprise/management_console/">Enterprise Management Console API documentation</a> for more information.
    ///</remarks>
    public interface IEnterpriseManagementConsoleClient
    {
        /// <summary>
        /// Gets GitHub Enterprise Maintenance Mode Status
        /// </summary>
        /// <remarks>
        /// https://developer.github.com/v3/enterprise/management_console/#check-maintenance-status
        /// </remarks>
        Task<MaintenanceModeResponse> GetMaintenanceMode(string managementConsolePassword);

        /// <summary>
        /// Sets GitHub Enterprise Maintenance Mode
        /// </summary>
        /// <remarks>
        /// https://developer.github.com/v3/enterprise/management_console/#check-maintenance-status
        /// </remarks>
        Task<MaintenanceModeResponse> EditMaintenanceMode(UpdateMaintenanceRequest maintenance, string managementConsolePassword);

        /// <summary>
        /// Gets the authorized SSH keys for the GitHub Enterprise instance
        /// </summary>
        /// <remarks>
        /// https://developer.github.com/v3/enterprise/management_console/#retrieve-authorized-ssh-keys
        /// </remarks>
        [ExcludeFromPaginationApiOptionsConventionTest("Pagination is not supported by this endpoint")]
        Task<IReadOnlyList<AuthorizedKey>> GetAllAuthorizedKeys(string managementConsolePassword);

        /// <summary>
        /// Adds an authorized SSH key to the GitHub Enterprise instance
        /// </summary>
        /// <remarks>
        /// https://developer.github.com/v3/enterprise/management_console/#add-a-new-authorized-ssh-key
        /// </remarks>
        Task<IReadOnlyList<AuthorizedKey>> AddAuthorizedKey(AuthorizedKeyRequest authorizedKey, string managementConsolePassword);

        /// <summary>
        /// Removes an authorized SSH key from the GitHub Enterprise instance
        /// </summary>
        /// <remarks>
        /// https://developer.github.com/v3/enterprise/management_console/#remove-an-authorized-ssh-key
        /// </remarks>
        Task<IReadOnlyList<AuthorizedKey>> DeleteAuthorizedKey(AuthorizedKeyRequest authorizedKey, string managementConsolePassword);
    }
}