using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("WishList/Views/Home/Index.cshtml");
        }
        public IActionResult Error() 
        {
            return View("WishList/Views/Shared/Error.cshtml");
        }
    }
}
