using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SarajevoEvents.Controllers
{
    public class NaslovnaController : Controller
    {
        // 
        // GET: /Test/

        public IActionResult Index()
        {
            return View();
        }
    }
}