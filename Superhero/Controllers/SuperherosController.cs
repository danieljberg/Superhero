using Superhero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero.Controllers
{
    public class SuperherosController : Controller
    {
        Models.ApplicationDbContext context;
        public SuperherosController()
        {
            context = new Models.ApplicationDbContext();
        }
        // GET: Superheros
        public ActionResult Index()
        {
            return View(context.Superheroes);
        }

        // GET: Superheros/Details/5
        public ActionResult Details(int id)
        {
            var superhero = context.Superheroes.Find(id);
            return View(superhero);
        }

        // GET: Superheros/Create
        public ActionResult Create()
        {
            Models.Superhero superhero = new Models.Superhero();
            return View(superhero);
        }

        // POST: Superheros/Create
        [HttpPost]
        public ActionResult Create(Models.Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheros/Edit/5
        public ActionResult Edit(int id)
        {
            var superheroToEdit = context.Superheroes.Find(id);
            return View(superheroToEdit);
        }

        // POST: Superheros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here                
                var superheroToEdit = context.Superheroes.Find(id);
                superheroToEdit.name = superhero.name;
                superheroToEdit.alterEgo = superhero.alterEgo;
                superheroToEdit.primarySuperheroAbility = superhero.primarySuperheroAbility;
                superheroToEdit.secondarySuperheroAbility = superhero.secondarySuperheroAbility;
                superheroToEdit.catchphrase = superhero.catchphrase;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheros/Delete/5
        public ActionResult Delete(int id)
        {
            var superheroToDelete = context.Superheroes.Find(id);
            return View(superheroToDelete);
        }

        // POST: Superheros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Models.Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                var superheroToDelete = context.Superheroes.Find(id);
                context.Superheroes.Remove(superheroToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
