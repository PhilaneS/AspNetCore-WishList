using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Item>() { new Item { Id=1, Description="Testing" } });
        }
    }
}
