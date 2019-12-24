using Nop.Web.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nop.Web.Models.Order
{
    public class BookingModel
    {
        public BookingModel()
        {
            AvailableCar = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
       
        }
        public IList<SelectListItem> AvailableCar { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        [Required(ErrorMessage = "Vui Lòng Điền Tên")]
        [NopResourceDisplayName("Booking.Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Booking.Adress")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Vui Lòng Điền Số Điện Thoại")]
        [NopResourceDisplayName("Booking.Phone")]
        public string Phone { get; set; }
        [NopResourceDisplayName("Booking.Gender")]
        public bool Gender { get; set; }
        [NopResourceDisplayName("Booking.Deed")]
        public int Deed  { get; set; }
        [NopResourceDisplayName("Booking.Product")]
        [Required(ErrorMessage = "Vui Lòng Chọn Dòng Xe")]
        public int ProductId { get; set; }
        [NopResourceDisplayName("Booking.Vendor")]
        [Required(ErrorMessage = "Vui Lòng Chọn Đại Lý")]
        public int VendorId { get; set; }
        [NopResourceDisplayName("Booking.State")]
        [Required(ErrorMessage = "Vui Lòng Chọn Tỉnh/Thành Phố")]
        public int State { get; set; }
        [NopResourceDisplayName("Booking.Note")]
        public string Note { get; set; }


    }
}