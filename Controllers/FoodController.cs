using Microsoft.AspNetCore.Mvc;

namespace RazorFun
{
    public class FoodController : Controller
    {
        [HttpGet("")]
        public ViewResult Food()
        {
            return View();
        }
    }
}