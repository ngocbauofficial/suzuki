using System;
using System.Collections.Generic;
using System.Linq;
using Nop.Core.Caching;
using Nop.Core.Data;
using Nop.Core.Domain.Directory;
using Nop.Services.Events;
using Nop.Services.Localization;

namespace Nop.Services.Directory
{
    /// <summary>
    /// State province service
    /// </summary>
    public partial class EstimateService : IEstimateService
    {
        #region Constants



        #endregion

        #region Fields

        private readonly IRepository<Estimate> _EstimateRepository;
        private readonly IEventPublisher _eventPublisher;
        private readonly ICacheManager _cacheManager;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="cacheManager">Cache manager</param>
        /// <param name="stateProvinceRepository">State/province repository</param>
        /// <param name="eventPublisher">Event published</param>
        public EstimateService(ICacheManager cacheManager,
            IRepository<Estimate> EstimateRepository,
            IEventPublisher eventPublisher)
        {
            _cacheManager = cacheManager;
            _EstimateRepository = EstimateRepository;
            _eventPublisher = eventPublisher;
        }

        #endregion

        #region Methods
     
        public virtual void DeleteEstimate(Estimate Estimate)
        {
            if (Estimate == null)
                throw new ArgumentNullException("Estimate");

            _EstimateRepository.Delete(Estimate);



            //event notification
            _eventPublisher.EntityDeleted(Estimate);
        }

        public virtual Estimate GetEstimateById(int EstimateId)
        {
            if (EstimateId == 0)
                return null;

            return _EstimateRepository.GetById(EstimateId);
        }

        /// <summary>
        /// Gets a state/province 
        /// </summary>
        /// <param name="abbreviation">The state/province abbreviation</param>
        /// <returns>State/province</returns>
        public virtual Estimate GetEstimateByStateId(int StateId)
        {
            var query = from sp in _EstimateRepository.Table
                        where sp.StateId == StateId
                        select sp;
            var Estimate = query.FirstOrDefault();
            return Estimate;
        }

        public virtual void InsertEstimate (Estimate Estimate)
        {
            if (Estimate == null)
                throw new ArgumentNullException("Estimate");

            _EstimateRepository.Insert(Estimate);

      

            //event notification
            _eventPublisher.EntityInserted(Estimate);
        }

      
        public virtual void UpdateEstimate(Estimate Estimate)
        {
            if (Estimate == null)
                throw new ArgumentNullException("Estimate");

            _EstimateRepository.Update(Estimate);

            //event notification
            _eventPublisher.EntityUpdated(Estimate);
        }

        #endregion
    }
}
