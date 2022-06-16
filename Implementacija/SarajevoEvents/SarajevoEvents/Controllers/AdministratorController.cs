using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SarajevoEvents.Controllers
{
    public class AdministratorController : Controller
    {

        private readonly ApplicationDataContext _context;

        public AdministratorController(ApplicationDataContext context)
        {
            _context = context;
        }
        // 
        // GET: /Test/

        public IActionResult Index()
        {
            return View();
        }
    }
}