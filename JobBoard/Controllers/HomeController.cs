using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Jobs()
        {
            return View();
        }

        [HttpPost("/addJob")]
        public ActionResult addJob(string title, string description, string name, string phoneNumber, string emailAddress)
        {
            Contact newContact = new Contact(name, phoneNumber, emailAddress);
            JobOpening newJob = new JobOpening(title, description, newContact);
            return RedirectToAction("Listings");
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Listings()
        {
            List<JobOpening> allJobs = JobOpening.GetAll();
            return View(allJobs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
