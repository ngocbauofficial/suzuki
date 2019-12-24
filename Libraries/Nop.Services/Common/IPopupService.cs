using Nop.Core;
using Nop.Core.Domain.Common;
using System.Collections.Generic;

namespace Nop.Services.Common
{
    public partial interface IPopupService
    {

        void Delete(Popup popup);

        void Insert(Popup popup);

        void Edit(Popup popup);
        Popup GetById(int id);

        IPagedList<Popup> GetAll(
          int pageIndex = 0, int pageSize = int.MaxValue, bool showHidden = false);
    }
}
