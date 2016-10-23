using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreDemo1.Core.Interfaces;
using ASPNetCoreDemo1.Core.Models;
using ASPNetCoreDemo1.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreDemo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Students()
        {
            var students = _studentRepository.GetAll();

            return View(students);

        }


        /// <summary>
        /// Home/Student/003457336
        /// </summary>
        [HttpGet("{jmbag}")]
        public IActionResult Student(string jmbag)
        {
            var student = _studentRepository.Get(jmbag);

            return View(student);

        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.Add(s);
                return RedirectToAction("Students");
            }
            return View(s);
        }


        public IActionResult Error()
        {
            return View();
        }


    }
}
