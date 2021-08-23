using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Items.ToList());
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);

            _context.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult Delete(int Id)
        {
            var ItemToDelet = _context.Items.FirstOrDefault(item => item.Id == Id);

            _context.Items.Remove(ItemToDelet);

            //_context.Entry(Item).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
