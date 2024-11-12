using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiemtra_BE.Models
{
    public class OrderItem : Controller
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        // GET: OrderItem
        public ActionResult Index()
        {
            return View();
        }
    }
}