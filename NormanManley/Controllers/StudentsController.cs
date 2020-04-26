using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormanManley.Contracts;
using NormanManley.Data;
using NormanManley.Models;


namespace NormanManley.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

            // GET: Registration
            public ActionResult Index()
            {
                var Students = _repo.Findall().ToList();
                var Model = _mapper.Map<List<Students>, List<StudentVM>>(Students);

                return View();
            }

            // GET: Registration/Details/5
            public ActionResult Details(int id)
            { 
                if (_repo.IsExists(id))
            {
                    return NotFound();
            }
            var Students = _repo.FindById(id);
            var Model = _mapper.Map< StudentVM > (Students);

            return View(Model);
            }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentVM Model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {

                    return View(Model);

                }
                var Registration = _mapper.Map<Students>(Model);
                var isSuccess = _repo.Create(Registration);
                if (!isSuccess)

                {
                    ModelState.AddModelError("", "Something Went wrong...");
                    return View(Model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something Went wrong...");

                return View(Model);
            }
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {

            if (!_repo.IsExists(id))

            {
                return NotFound();
            }

            var Students = _repo.FindById(id);
            var Model = _mapper.Map<StudentVM>(Students);
            return View();
        }

        // POST: Registration/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentVM Model)
        {
            try
            {
                // TODO: Add update logic here

                if (!ModelState.IsValid)
                {

                    return View(Model);
                }

                var Students = _mapper.Map<Students>(Model);
                var IsSuccess = _repo.Update(Students);
                if (!IsSuccess)

                {
                    ModelState.AddModelError("", "Something Went wrong...");
                    return View(Model);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            var Student = _repo.FindById(id);

            if (Student == null)
            {

                return NotFound();
            }

            var IsSuccess = _repo.Delete(Student);

            if (!IsSuccess)

            {

                return BadRequest();
            }


            return RedirectToAction(nameof(Index));
        }

        // POST: Registration/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentVM Model)
        {
            try
            {
                // TODO: Add delete logic here

                var Student = _repo.FindById(id);

                if (Student == null)
                {

                    return NotFound();
                }

                var IsSuccess = _repo.Delete(Student);

                if (!IsSuccess)

                {

                    return View(Model);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(Model);
            }
        }
    }
}