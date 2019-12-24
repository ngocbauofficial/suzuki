using System.Collections.Generic;
using Nop.Core.Domain.Directory;

namespace Nop.Services.Directory
{
    /// <summary>
    /// State province service interface
    /// </summary>
    public partial interface IEstimateService
    {
        /// <summary>
        /// Deletes a state/province
        /// </summary>
      
        void DeleteEstimate(Estimate Estimate);

        /// <summary>
        /// Gets a state/province
        /// </summary>
      
        /// <returns>State/province</returns>
        Estimate GetEstimateById(int EstimateId);

        Estimate GetEstimateByStateId(int StateId);

        /// <summary>
        /// Gets a state/province collection by country identifier
        /// </summary>
      
        /// <returns>States</returns>

        void InsertEstimate(Estimate Estimate);

        /// <summary>
        /// Updates a state/province
        /// </summary>
      
        void UpdateEstimate(Estimate Estimate);
    }
}
