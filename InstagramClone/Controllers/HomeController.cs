using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InstagramClone.Models;

namespace InstagramClone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Users user)
        {
            using (var context = new InstagramCloneContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public IActionResult passwordreset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult passwordreset(Users user)
        {
            using (var context = new InstagramCloneContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public IActionResult posts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult posts(Posts post)
        {
            using (var context = new InstagramCloneContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public IActionResult signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult signin(Users user)
        {
            using (var context = new InstagramCloneContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            return View();
        }
    }
}
