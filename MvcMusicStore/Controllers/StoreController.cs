using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from store controller index.";
        }

        public string browse(string genre)
        {
            //Request.Query["genre"].FirstOrDefault();
            return "we got " + genre; 

        }

        public string Details(Int32 id)
        {
            return "we got " + id;
        }

        public IActionResult Sample()
        {
            ViewBag.message = "this is the ViewBag property message";
            return View("Sample");
            //return view() - this will go to a view that has the same action name. 
        }
    }
}
