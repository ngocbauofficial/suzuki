using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Common
{
   public class Popup : BaseEntity
    {
        public int PictureId { get; set; }

        public string Time { get; set; }

        public string Link { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifyDate { get; set; }
    }
}
