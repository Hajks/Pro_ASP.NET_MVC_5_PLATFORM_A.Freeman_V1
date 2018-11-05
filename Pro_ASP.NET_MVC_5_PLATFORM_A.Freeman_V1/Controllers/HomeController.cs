using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1.Models;

namespace Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //todo: wyslij zawartosc guestResponse do organiatora przyjecia
                return View("Thanks", guestResponse);
            }
            else
            {
                //błąd kontroli poprawności, więc ponownie wyświetlany formularz wprowadzania danych
                return View();
            }
        }
    }
}