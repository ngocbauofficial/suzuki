
using System.Web.Mvc;

using Nop.Web.Framework;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.CostEstimates
{

    public partial class EstimateModel : BaseNopEntityModel
    {



        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.Gia")]
        [AllowHtml]
        public double Gia { get; set; }
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

        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.TongChiPhi")]
        [AllowHtml]

        public double TongChiPhi { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Estimate.Fields.TongCong")]
        [AllowHtml]

        public double TongCong { get; set; }


    }


}