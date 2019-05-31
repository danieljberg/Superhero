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
            return View();
        }

        // GET: Superheros/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            context.Superheroes.Find(id);
            return View();
        }

        // POST: Superheros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Superheros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
