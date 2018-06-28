using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Company.MyProj.Dao.Entity.Context;
using Company.MyProj.Dominio;
using Company.MyProj.Web.App_Start;
using Company.MyProj.Web.ViewModel.Usuario;

namespace Company.MyProj.Web.Controllers
{
    public class Usuarios1Controller : Controller
    {
        private MyProjDBContext db = new MyProjDBContext();

        // GET: Usuarios1
        public ActionResult Index()
        {
            //return View(db.Usuarios.ToList());
            return View(AutoMapperConfig.Mapper.Map<List<Usuario>, List<UsuarioIndexViewModel>>(db.Usuarios.ToList()));
        }

        // GET: Usuarios1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Login,Nome,Status")] ViewModeltoUsuario ViewModelUsuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = Mapper.Map<ViewModeltoUsuario, Usuario>(ViewModelUsuario);


                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ViewModelUsuario);
        }

        // GET: Usuarios1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Usuario , ViewModeltoUsuario>(usuario));
        }

        // POST: Usuarios1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Login,Nome,Status")] ViewModeltoUsuario ViewModelUsuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = Mapper.Map<ViewModeltoUsuario, Usuario>(ViewModelUsuario);
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ViewModelUsuario);
        }

        // GET: Usuarios1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
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
