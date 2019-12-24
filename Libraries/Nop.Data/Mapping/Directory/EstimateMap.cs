using Nop.Core.Domain.Directory;

namespace Nop.Data.Mapping.Directory
{
    public partial class EstimateMap : NopEntityTypeConfiguration<Estimate>
    {
        public EstimateMap()
        {
            this.ToTable("Estimate");
            this.HasKey(c => c.Id);
            this.Property(u => u.StateId);
            this.Property(u => u.BaoHiemTNDS);
            this.Property(u => u.BienSo);
            this.Property(u => u.PhiBHVC);
            this.Property(u => u.PhiDuongBo);
            this.Property(u => u.PhiKiemDinh);
            this.Property(u => u.LePhiTruocBa);
          

        }
    }
}