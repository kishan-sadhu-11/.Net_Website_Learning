using System.Web.Mvc;
using mvc_practice.Models;
using mvc_practice.dbcontext;

namespace mvc_practice.Controllers
{
    public class StudentController : Controller
    {
        studnt_db db = new studnt_db();

        // GET: Student/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                db.student_add(s);
                ViewBag.Msg = "Student Saved Successfully";
                // Agar aap page redirect karna chahte hain toh niche wali line uncomment karein:
                // return RedirectToAction("Create"); 
            }

            return View(s);
        }
    }
}