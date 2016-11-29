using Microsoft.AspNetCore.Mvc;
using tutorial1.Models;
using System.Linq;
using System;

namespace tutorial1.Controllers
{
    public class tutorial1Controller : Controller      
    {
        private YourContext _context; 

        public tutorial1Controller(YourContext context)      
        {
            _context = context;
        }

        [HttpGet]
        [Route("view")]
        public IActionResult view()  
        {
            Console.WriteLine("This is the View route!");
            
            return View(_context.Quotes.ToList());  
        }

        [HttpGet]
        [Route("create")]
        public IActionResult create()  
        {
            Console.WriteLine("This is the Create route!");
            
            return View("create");   
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(Quote quote)   
        {
            Console.WriteLine("This is the create route!");
            if(ModelState.IsValid)
            {
                quote.name = Request.Form["name"];
                quote.quote = Request.Form["quote"];
                quote.created_at = DateTime.Now;
                
                _context.Quotes.Add(quote);
                _context.SaveChanges();
                return RedirectToAction("view"); 
            }
            return View(quote); 
        }
    }
}