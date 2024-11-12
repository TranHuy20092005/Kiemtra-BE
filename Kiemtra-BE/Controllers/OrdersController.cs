using Kiemtra_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiemtra_BE.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders

        public ActionResult Index()
        {
            var orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                Status = "Giao hàng thành công",
                Items = new List<OrderItem>
                {
                    new OrderItem { Id = 1, Product = new Product { Id = 1, Name = "Làm giàu từ cổ phiếu", ImageUrl = "/Content/images/ảnh 1.jpg", Price = 399000 }, Quantity = 1 },
                    new OrderItem { Id = 2, Product = new Product { Id = 2, Name = "Hãy chăm sóc mẹ", ImageUrl = "/Content/images/ảnh 1.jpg", Price = 67000 }, Quantity = 1 }
                }
            },
            new Order
            {
                Id = 2,
                Status = "Đã hủy",
                Items = new List<OrderItem>
                {
                    new OrderItem { Id = 3, Product = new Product { Id = 3, Name = "Cây cam ngọt của tôi", ImageUrl = "/Content/images/ảnh 1.jpg", Price = 73800 }, Quantity = 1 }
                }
            }
        };
                return View(orders);
    }
    }
}