using System.Collections.Generic;
using Nop.Core.Domain.Directory;

namespace Nop.Services.Directory
{
    /// <summary>
    /// State province service interface
    /// </summary>
    public partial interface IAgencyService
    {
        /// <summary>
        /// Deletes a state/province
        /// </summary>

        void DeleteAgency(Agency Agency);

        /// <summary>
        /// Gets a state/province
        /// </summary>

        /// <returns>State/province</returns>
         IList<Agency> GetAllAgency(int languageId = 0, bool showHidden = false);
        Agency GetAgencyById(int AgencyId);

        Agency GetAgencyByStateId(int StateId);

        /// <summary>
        /// Gets a state/province collection by country identifier
        /// </summary>

        /// <returns>States</returns>

        void InsertAgency(Agency Agency);

        /// <summary>
        /// Updates a state/province
        /// </summary>

        void UpdateAgency(Agency Agency);
    }
}
