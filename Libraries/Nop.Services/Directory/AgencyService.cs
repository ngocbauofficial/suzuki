using System;
using System.Collections.Generic;
using System.Linq;
using Nop.Core.Caching;
using Nop.Core.Data;
using Nop.Core.Domain.Directory;
using Nop.Services.Events;

namespace Nop.Services.Directory
{
    /// <summary>
    /// State province service
    /// </summary>
    public partial class AgencyService : IAgencyService
    {
        #region Constants



        #endregion

        #region Fields

        private readonly IRepository<Agency> _AgencyRepository;
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
        public AgencyService(ICacheManager cacheManager,
            IRepository<Agency> AgencyRepository,
            IEventPublisher eventPublisher)
        {
            _cacheManager = cacheManager;
            _AgencyRepository = AgencyRepository;
            _eventPublisher = eventPublisher;
        }

        #endregion

        #region Methods

        public virtual void DeleteAgency(Agency Agency)
        {
            if (Agency == null)
                throw new ArgumentNullException("Agency");

            _AgencyRepository.Delete(Agency);



            //event notification
            _eventPublisher.EntityDeleted(Agency);
        }

        public virtual IList<Agency> GetAllAgency(int languageId = 0, bool showHidden = false)
        {
            
                var query = _AgencyRepository.Table;
                if (!showHidden)
                    query = query.Where(c => c.Published);
                query = query.OrderBy(c => c.DisplayOrder).ThenBy(c => c.Name);

              

                var Agency = query.ToList();

               
                return Agency;
         
        }

        public virtual Agency GetAgencyById(int AgencyId)
        {
            if (AgencyId == 0)
                return null;

            return _AgencyRepository.GetById(AgencyId);
        }

        /// <summary>
        /// Gets a state/province 
        /// </summary>
        /// <param name="abbreviation">The state/province abbreviation</param>
        /// <returns>State/province</returns>
        public virtual Agency GetAgencyByStateId(int StateId)
        {
            var query = from sp in _AgencyRepository.Table
                        where sp.StateId == StateId
                        select sp;
            var Agency = query.FirstOrDefault();
            return Agency;
        }

        public virtual void InsertAgency(Agency Agency)
        {
            if (Agency == null)
                throw new ArgumentNullException("Agency");

            _AgencyRepository.Insert(Agency);



            //event notification
            _eventPublisher.EntityInserted(Agency);
        }


        public virtual void UpdateAgency(Agency Agency)
        {
            if (Agency == null)
                throw new ArgumentNullException("Agency");

            _AgencyRepository.Update(Agency);

            //event notification
            _eventPublisher.EntityUpdated(Agency);
        }

        #endregion
    }
}
