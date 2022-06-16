using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SarajevoEvents.Controllers
{
    public class LoginController : Controller
    {
        // 
        // GET: /Login/

        public IActionResult Index()
        {
            return View();
        }
    }
}