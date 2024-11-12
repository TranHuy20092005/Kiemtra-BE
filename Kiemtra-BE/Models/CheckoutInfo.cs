using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiemtra_BE.Models
{
    public class CheckoutInfo : Controller
    {
        // GET: CheckoutInfo
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }
        public ActionResult Index()
        {
            return View();
        }
    }
}