using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TaskApp.Controllers;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numTimes}");
        }
    }
