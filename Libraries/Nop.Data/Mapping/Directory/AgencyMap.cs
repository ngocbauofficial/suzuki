using Nop.Core.Domain.Directory;

namespace Nop.Data.Mapping.Directory
{
    public partial class AgencyMap : NopEntityTypeConfiguration<Agency>
    {
        public AgencyMap()
        {
            this.ToTable("Agency");
            this.HasKey(c => c.Id);
      
        }
    }
}