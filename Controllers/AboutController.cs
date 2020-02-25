using Microsoft.AspNetCore.Mvc;

namespace IParse.Controllers
{
    public class AboutController : Controller
    {
        public ViewResult AboutUs()
        {
            return View();
        } 
    }
}