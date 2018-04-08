using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcMovie_Core.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        /*public string Index()
        {
            return "This is my default action...";
        }*/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        /*public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name,  int numTimes = 3)
        //{
        //    string myParam = "moj parametar";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes} plus another parameter {myParam}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            ViewData["MojTest"] = "testiram viewData no?";


            return View();
        }

    }
}