using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
