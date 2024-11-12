using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiemtra_BE.Models
{
    public class Order : Controller
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalPrice => Items.Sum(item => item.Product.Price * item.Quantity);
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
    }
}