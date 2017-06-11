using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SerienMVC;
using SerienMVC.Repositories;

namespace SerienMVC.Controllers
{
    public class SeriesController : Controller
    {
        private UnitOfWork uow;
        public SeriesController()
        {
            this.uow = new UnitOfWork(new SerienDBEntities());
        }
        // GET: Series
        public ActionResult Index()
        {
            return View(uow.Serie.GetAll());
        }

        // GET: Series/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serie serie = uow.Serie.Get(id.Value);
            if (serie == null)
            {
                return HttpNotFound();
            }
            return View(serie);
        }

        // GET: Series/Create
        public ActionResult Create()
        {
            ViewBag.Genre = new SelectList(uow.Genre.GetAll(), "ID", "Name");
            return View();
        }

        // POST: Series/Create
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Rating,ReleaseDate")] Serie serie)
        {
            if (ModelState.IsValid)
            {
                uow.Serie.Add(serie);
                uow.Complete();
                return RedirectToAction("Index");
            }
            ViewBag.Genre = new SelectList(uow.Genre.GetAll(), "ID", "Name");
            return View(serie);
        }

        // GET: Series/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serie serie = uow.Serie.Get(id.Value);
            if (serie == null)
            {
                return HttpNotFound();
            }
            ViewBag.Genre = new SelectList(uow.Genre.GetAll(), "ID", "Name");
            return View(serie);
        }

        // POST: Series/Edit/5
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Rating,ReleaseDate")] Serie serie)
        {
            if (ModelState.IsValid)
            {
                uow.Serie.Update(serie);
                uow.Complete();
                return RedirectToAction("Index");
            }
            //ViewBag.RegionId = new SelectList(uOW.Regionen.GetAll(), "RegionId", "RegionBezeichnung", hotel.RegionId);
            return View(serie);
        }

        // GET: Series/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serie serie = uow.Serie.Get(id.Value);
            if (serie == null)
            {
                return HttpNotFound();
            }
            return View(serie);
        }

        // POST: Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Serie serie = uow.Serie.Get(id);
            uow.Serie.Remove(serie);
            uow.Complete();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                uow.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
