using Microsoft.AspNetCore.Mvc;

namespace Quiz_67127924_Chanapol.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            
            ViewBag.UserId = TempData.Peek("UserId")?.ToString();
            return View();
        }

        public IActionResult MyDetail()
        {
            
            ViewBag.Var1 = "Chanapol Sereekhunakhun";
            ViewBag.Var2 = "67127924";
            ViewBag.Var3 = "Computer Science";
            ViewBag.Var4 = "Sripatum University";
            ViewBag.Var5 = "Year 3";
            ViewBag.Var6 = "Bangkok";
            ViewBag.Var7 = "Male";
            ViewBag.Var8 = "20 Years Old";
            ViewBag.Var9 = "GMAIL: chanapol.ser@spumail.net";
            ViewBag.Var10 = "Tel:098-381-3674";

            return View();
        }
    }
}