using Microsoft.AspNetCore.Mvc;
using Quiz_67127924_Chanapol.Models;

namespace Quiz_67127924_Chanapol.Controllers
{
    public class CalculateController : Controller
    {
        [HttpGet]
        public IActionResult CalculateForm()
        {
            return View(new ScoreViewModel());
        }

        [HttpPost]
        public IActionResult CalculateForm(ScoreViewModel model)
        {
            
            model.TotalScore = model.Score1 + model.Score2 + model.Score3 + model.Score4 + model.Score5 +
                               model.Score6 + model.Score7 + model.Score8 + model.Score9 + model.Score10;

            
            if (model.TotalScore >= 80) model.Grade = "A";
            else if (model.TotalScore >= 75) model.Grade = "B+";
            else if (model.TotalScore >= 70) model.Grade = "B";
            else if (model.TotalScore >= 65) model.Grade = "C+";
            else if (model.TotalScore >= 60) model.Grade = "C";
            else if (model.TotalScore >= 55) model.Grade = "D+";
            else if (model.TotalScore >= 50) model.Grade = "D";
            else model.Grade = "F";

            return View("CalculateResult", model);
        }
    }
}