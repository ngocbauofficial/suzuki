using Nop.Core;
using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nop.Admin.Models.Common
{
    public class PopupModel : BaseNopEntityModel
    {
        [UIHint("Picture")]
        public int PictureId { get; set; }

        public string Time { get; set; }

        public string Link { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifyDate { get; set; }
    }
}