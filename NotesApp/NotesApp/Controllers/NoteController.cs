using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NotesApp.DataAccess;
using NotesApp.Models;
using NotesApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.Controllers
{
    public class NoteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NoteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Note> objList = _db.Notes;

            foreach (var obj in objList)
            {
                obj.NoteType = _db.NoteTypes.FirstOrDefault(u => u.Id == obj.NoteTypeId);
            }


            return View(objList);
        }

        public IActionResult Create()
        {

            NoteVM noteVM = new NoteVM()
            {
                Note = new Note(),
                TypeDropDown = _db.NoteTypes.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };

            return View(noteVM);
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NoteVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Notes.Add(obj.Note);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Details(int id)
        {
            var noteDetails = _db.Notes.Find(id);

            if (noteDetails == null)
                return View("Not Found");

            noteDetails.ReadCount += 1;
            _db.SaveChanges();

            IEnumerable<Note> objList = _db.Notes;

            foreach (var obj in objList)
            {
                obj.NoteType = _db.NoteTypes.FirstOrDefault(u => u.Id == obj.NoteTypeId);
            }

            return View(noteDetails);
        }


        //GET Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Notes.Find(id);

            if (obj == null)
                return NotFound();

            NoteVM noteVM = new NoteVM()
            {
                Note = obj,
                TypeDropDown = _db.NoteTypes.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };

            return View(noteVM);


        }

        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(NoteVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Notes.Update(obj.Note);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }



        //GET Delete
        public IActionResult Delete(int? id)
        {
            var obj = _db.Notes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Notes.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
