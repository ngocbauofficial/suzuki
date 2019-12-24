using System;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Stores;

namespace Nop.Core.Domain.Directory
{
    /// <summary>
    /// Represents a currency
    /// </summary>
    public partial class Estimate : BaseEntity
    {
      

        /// <summary>
        /// Gets or sets the currency code
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// Gets or sets the rate
        /// </summary>
        public double LePhiTruocBa { get; set; }

        /// <summary>
        /// Gets or sets the display locale
        /// </summary>
        public double BienSo { get; set; }

        public double PhiKiemDinh { get; set; }
        public double PhiBHVC { get; set; }
        public double PhiDuongBo { get; set; }
       
        public double BaoHiemTNDS { get; set; }
     
        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
  

        /// <summary>
        /// Gets or sets the display order


        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
   
        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
    
    }

}
