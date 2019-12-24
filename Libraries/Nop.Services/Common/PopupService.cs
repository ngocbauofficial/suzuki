using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Domain.Common;
using Nop.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Common
{
    public partial class  PopupService : IPopupService
    {
   
        #region Fields

        private readonly IRepository<Popup> _popupRepository;
        private readonly IEventPublisher _eventPublisher;
  

        #endregion

        #region Ctor


        public PopupService(IRepository<Popup> popupRepository,
            
         
            IEventPublisher eventPublisher
          )
        {

            this._popupRepository = popupRepository;
    
   
            this._eventPublisher = eventPublisher;
     
        }

        #endregion
        public virtual void Delete(Popup popup)
        {
            _popupRepository.Delete(popup);
            _eventPublisher.Publish(popup);
        }
        public virtual void Insert(Popup popup)
        {
            _popupRepository.Insert(popup);
       
        }
        public virtual void Edit(Popup popup)
        {
            _popupRepository.Update(popup);
 
        }
        public Popup GetById(int id)
        {

            return _popupRepository.GetById(id);

        }
        public virtual IPagedList<Popup> GetAll(
            int pageIndex = 0, int pageSize = int.MaxValue, bool showHidden = false)
        {
            var query = _popupRepository.Table;
         
            query = query.OrderByDescending(n => n.CreatedDate);

            //Store mapping
           

            var news = new PagedList<Popup>(query, pageIndex, pageSize);
            return news;
        }
    }
}
