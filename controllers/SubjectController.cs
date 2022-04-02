using MVCPROJ;
using MVCPROJ.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1809.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SubjectController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Subject> listofsubjects = _db.Subject;
            return View(listofsubjects);
        }

        [HttpGet]
        public IActionResult Edit(int subjectid)
        {
            var subobj = _db.Subject.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Subject updatedvaluesobj)
        {
            _db.Subject.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

       
    }
}
