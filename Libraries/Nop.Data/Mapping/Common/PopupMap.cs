using Nop.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Data.Mapping.Common
{
    public partial class PopupMap : NopEntityTypeConfiguration<Popup>
    {
        public PopupMap()
        {
            this.ToTable("Popup");
            this.HasKey(a => a.Id);
        }
    }
}
