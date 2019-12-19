using System.Web.Mvc;

namespace HomeWork2._2.Controllers
{
    public class HomoWorkSecondController : Controller
    {
        // GET: HomoWorkSecond
        public ActionResult hWorkSecond(string x, string y, string opperand)
        {
            int opp1, opp2;

            if (int.TryParse(x, out opp1) && int.TryParse(y, out opp2))
            {
                switch (opperand)
                {
                    case "multiply":
                        ViewBag.Result = opp1 * opp2;
                        break;
                    case "plus":
                        ViewBag.Result = opp1 + opp2;
                        break;
                    case "minus":
                        ViewBag.Result = opp1 - opp2;
                        break;
                    case "divided":
                        if (opp1 == 0 || opp2 == 0)
                            ViewBag.Result = "нельзя делить на 0";
                        else
                            ViewBag.Result = opp1 / opp2;
                        break;
                    default:
                        ViewBag.Result = "Выбрано не верное арефметическое действие";
                        break;

                }
            }
            else
                ViewBag.Result = "Введенно не валидное значение";
            return View();
        }
    }
}