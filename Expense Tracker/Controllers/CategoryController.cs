using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
