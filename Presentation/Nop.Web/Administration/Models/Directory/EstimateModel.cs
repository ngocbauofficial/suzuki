using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Nop.Admin.Validators.Directory;
using Nop.Web.Framework;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc;

namespace Nop.Admin.Models.Directory
{
   
    public partial class EstimateModel : BaseNopEntityModel
    {


        public int StateId { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.LePhiTruocBa")]
        [AllowHtml]
        public double LePhiTruocBa { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.BienSo")]
        [AllowHtml]
        public double BienSo { get; set; }
        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.PhiKiemDinh")]
        [AllowHtml]
        public double PhiKiemDinh { get; set; }
        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.PhiBHVC")]
        [AllowHtml]
        public double PhiBHVC { get; set; }
        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.PhiDuongBo")]
        [AllowHtml]
        public double PhiDuongBo { get; set; }
        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.BaoHiemTNDS")]
        [AllowHtml]

        public double BaoHiemTNDS { get; set; }

       

    }


}