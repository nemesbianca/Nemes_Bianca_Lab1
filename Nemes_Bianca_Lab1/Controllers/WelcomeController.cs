using Microsoft.AspNetCore.Mvc;
using Nemes_Bianca_Lab1.Models;
using System.Diagnostics;

namespace Nemes_Bianca_Lab1.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }


    }
}