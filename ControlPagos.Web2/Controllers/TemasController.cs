using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlPagos.Common.Models;
using ControlPagos.Web2.Models;

namespace ControlPagos.Web2.Controllers
{
    public class TemasController : Controller
    {
        private PagosDBContext db = new PagosDBContext();

        // GET: Temas
        public async Task<ActionResult> Index()
        {
            return View(await db.Temas.ToListAsync());
        }

        // GET: Temas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Temas temas = await db.Temas.FindAsync(id);
            if (temas == null)
            {
                return HttpNotFound();
            }
            return View(temas);
        }

        // GET: Temas/Create
        public ActionResult Create()
        {
           // Temas tema = new Temas();
            return View();
        }

        // POST: Temas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Temas temas)
        {
            if (ModelState.IsValid)
            {
                //if (temas.FechaCreado == null)
                //    temas.FechaCreado = DateTime.Now;

                db.Temas.Add(temas);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(temas);
        }

        // GET: Temas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Temas temas = await db.Temas.FindAsync(id);
            if (temas == null)
            {
                return HttpNotFound();
            }
            return View(temas);
        }

        // POST: Temas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Temas temas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(temas).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(temas);
        }

        // GET: Temas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Temas temas = await db.Temas.FindAsync(id);
            if (temas == null)
            {
                return HttpNotFound();
            }
            return View(temas);
        }

        // POST: Temas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Temas temas = await db.Temas.FindAsync(id);
            db.Temas.Remove(temas);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
