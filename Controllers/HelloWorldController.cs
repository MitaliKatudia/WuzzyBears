using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WuzzyBears.Controllers
{
    public class HelloWorldController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        } */

        // 
        // GET: /HelloWorld/

        //public string Index()
        public IActionResult Index()
        {
            // return "This is my default action...";

            return View();
        }

        /* 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        } 
        
        
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }  */

        //public string Welcome(string name, int ID = 1)

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}

