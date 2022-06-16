using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SarajevoEvents.Controllers
{
    public class FeedbackController : Controller
    {
        // 
        // GET: /Feedback/

       
        public IActionResult Index()
        {
            return View();
        }
    }
}