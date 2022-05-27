using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ExamController : Controller
    {
        private List<Exam> _exams;
        public ExamController()
        {
            _exams = new List<Exam>
            {
                new Exam(23,"Nigar Aliyeva",45),
                new Exam(35,"Fidan Abbasova",88),
            };
        }
        public ActionResult Result(int studentId)
        {
            return Content(studentId.ToString());
            //return View();
        }
        public ActionResult Detail(int id)
        {
            Exam exam = _exams.Find(x => x.Id == id);
            TempData["ExamId"] = id;
            ViewData["ExamId"] = id;
            ViewBag.ExamId = id;
            ViewBag.StudentName = exam.StudentFullName;

            return View();
        }
    }
}
