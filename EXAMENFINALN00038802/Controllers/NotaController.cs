using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EXAMENFINALN00038802.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EXAMENFINALN00038802.Controllers
{
    public class NotaController : Controller
    {
        private readonly ExamenFinalContext context;
        public NotaController(ExamenFinalContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            ViewBag.Etiquetitas = context.EtiquetaNotas.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {
            var not = context.Notas.ToList();
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            ViewBag.Etiquetitas = context.EtiquetaNotas.ToList();

            if (!String.IsNullOrEmpty(search))
            {
                not = not.Where(o => o.Titulo.Contains(search) || o.Contenido.Contains(search)).ToList();
                return View(not);
            }
            return View(not);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            return View(new Nota());
        }


        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            List<EtiquetaNota> etic = new List<EtiquetaNota>();

            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta", "Seleccione uno por lo menos");

            nota.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                context.Notas.Add(nota);
                context.SaveChanges();
                foreach (var item in etiqueta)
                {
                    var etique = new EtiquetaNota();
                    etique.IdEtiqueta = item;
                    etique.IdNota = nota.Id;
                    etic.Add(etique);
                }
                context.EtiquetaNotas.AddRange(etic);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Etiquetas.ToList();
                return View(nota);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = context.Notas.ToList();
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);

        }


        [HttpPost]
        public IActionResult Edit(Nota nota/*, List<int> etiqueta*/)
        {
            nota.Fecha = DateTime.Now;
            //List<EtiquetaNota> etic = new List<EtiquetaNota>();

            //if (etiqueta.Count() == 0)
            //    ModelState.AddModelError("etiqueta", "Seleccione por lo menos uno");

            if (ModelState.IsValid)
            {
                context.Notas.Update(nota);
                context.SaveChanges();
                //foreach (var item in etiqueta)
                //{
                //    var etique = new EtiquetaNota();
                //    etique.IdEtiqueta = item;
                //    etique.IdNota = nota.Id;
                //    etic.Add(etique);
                //}
                //context.EtiquetaNotas.AddRange(etic);
                //context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Etiquetas.ToList();
                return View(nota);
            }

        }


        //eliminar
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = context.EtiquetaNotas.Where(o => o.IdNota == id).ToList();
            context.Notas.Remove(nota);
            context.EtiquetaNotas.RemoveRange(etiqueta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Det(int id)
        {
            var etiqueta = context.Etiquetas.ToList();
            ViewBag.Etiquetas = context.EtiquetaNotas.Include(o => o.Etiqueta).ToList();
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }

    }
}
