using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        // Action names correspond with cshtml files in /Home
        // Default http method is 'get'
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpGet] // '[HttpGet]' attribute specifies http request method
        public IActionResult Edit()
        {
            return View(new Post());
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
             return RedirectToAction("Index"); // redirect to home page
        }
    }
}
