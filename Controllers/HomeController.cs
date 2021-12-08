using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Random_Passcode_Generator.Models;
using Microsoft.AspNetCore.Http;

namespace Random_Passcode_Generator.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            string LocalVariable = HttpContext.Session.GetString("Passcode");
            ViewBag.Passcode = LocalVariable;
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            return View();
        }

        [HttpGet("setpasscode")]
        public IActionResult PasscodeMaker()
        {
            Passcode toDisplay = new Passcode();
            string generatedString = toDisplay.CreateRandomString();

            int? Count = HttpContext.Session.GetInt32("Count");
            int newCount = Convert.ToInt32(Count)+1;
            HttpContext.Session.SetString("Passcode", generatedString);
            HttpContext.Session.SetInt32("Count", newCount);
            // To retrieve a string from session we use ".GetString"
            return Redirect("/");
        }









    }
}
