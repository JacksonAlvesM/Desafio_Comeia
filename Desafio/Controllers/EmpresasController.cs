using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Desafio.DAO;
using Desafio.Models;

namespace Desafio.Controllers
{
    public class EmpresasController : Controller
    {
        private EmpresasContext db = new EmpresasContext();

        // GET: Empresas
        public ActionResult Index()
        {
            return View(db.Empresas.ToList());
        }

        // GET: Empresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresas empresas = db.Empresas.Find(id);
            if (empresas == null)
            {
                return HttpNotFound();
            }
            return View(empresas);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            Empresas empresas = new Empresas();
            empresas.Data_Do_Cadastro = DateTime.Now;
            return View(empresas);
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CNPJ,Nome_Fantasia,Telefone,Email,Data_Do_Cadastro")] Empresas empresas)
        {
            if (ModelState.IsValid)
            {
                db.Empresas.Add(empresas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(empresas);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresas empresas = db.Empresas.Find(id);
            if (empresas == null)
            {
                return HttpNotFound();
            }
            return View(empresas);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CNPJ,Nome_Fantasia,Telefone,Email,Data_Do_Cadastro")] Empresas empresas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empresas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empresas);
        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresas empresas = db.Empresas.Find(id);
            if (empresas == null)
            {
                return HttpNotFound();
            }
            return View(empresas);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empresas empresas = db.Empresas.Find(id);
            db.Empresas.Remove(empresas);
            db.SaveChanges();
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
