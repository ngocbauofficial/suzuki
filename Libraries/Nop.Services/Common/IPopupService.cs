using Nop.Core.Domain.Common;
using System.Collections.Generic;

namespace Nop.Services.Common
{
    public partial interface IPopupService
    {

        void Delete(Popup popup);

        void Insert(Popup popup);

        void Edit(Popup popup);


        IList<Popup> GetAll();
    }
}
