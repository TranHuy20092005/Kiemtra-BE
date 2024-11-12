using Kiemtra_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiemtra_BE.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        private List<OrderItem> GetCartItems()
        {
            return new List<OrderItem>
        {
            new OrderItem
            {
                Id = 1,
                Quantity = 1,
                Product = new Product
                {
                    Id = 9,
                    Name = "Làm giàu từ cổ phiếu",
                    ImageUrl = "~/Content/images/ảnh 1.jpg",
                    Price = 399000
                }
            },
             new OrderItem
            {
                Id = 2,
                Quantity = 1,
                Product = new Product
                {
                    Id = 9,
                    Name = "Hãy chăm sóc mẹ",
                    ImageUrl = "~/Content/images/ảnh 1.jpg",
                    Price = 67000
                }
            }
        };
        }
        public ActionResult Index()
        {
            var cartItems = GetCartItems();
            ViewBag.TotalAmount = cartItems.Sum(item => item.Product.Price * item.Quantity);
            return View(cartItems);
        }
        [HttpPost]
        public ActionResult PlaceOrder(CheckoutInfo checkoutInfo)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("OrderSuccess");
            }
            return View("Index", GetCartItems());
        }
        public ActionResult OrderSuccess()
        {
            return View();
        }
    }
    }
