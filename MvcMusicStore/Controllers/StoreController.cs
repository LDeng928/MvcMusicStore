using Microsoft.AspNetCore.Mvc;
using MvcMusicStore.Models;
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

        //The List() action with create a new album list and iterate 
        //the list and output the list in a HTML page
        public IActionResult List()
        {
            List<Album> albums = new List<Album>();
            for(int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Generic Album " + i });
            }
            //ViewBag.Albums = albums; //create the albums list in ViewBag
            //return View(); //render the view with the name 'List'
            return View(albums); //returns the albums list model
        }

        //Create a guest view
        public IActionResult Guest()
        {
            return View();
        }
    }
}
