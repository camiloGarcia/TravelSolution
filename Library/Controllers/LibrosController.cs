using Data.Repositories;
using Domain;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class LibrosController : Controller
    {
        LibroRepository libroRepository = new LibroRepository();
        AutorRepository autorRepository= new AutorRepository();
        // GET: Libros
        public ActionResult Index()
        {
            List<LibroModel> model= libroRepository
                .GetAll()
                .Select(x=>new LibroModel { 
                    editorial_id=x.editorial_id,
                    editorial=x.editorial.nombre,
                    isbn=x.isbn,
                    n_paginas=x.n_paginas,
                    sinopsis=x.sinopsis,
                    titulo=x.titulo
                })
                .ToList();
            return View(model);
        }       

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            var model = new DetallesLibroModel();
            LibroDto libroDto= libroRepository.GetByISBN(id);
            if (libroDto!=null)
            {
                model.nombreEditorial =libroDto.editorial.nombre;
                model.sedeEditorial = libroDto.editorial.sede;
                model.isbn=libroDto.isbn;
                model.n_paginas =libroDto.n_paginas;
                model.sinopsis =libroDto.sinopsis;
                model.titulo =libroDto.titulo;                
            }
            AutorDto autorDto = autorRepository.GetByISBN(id);
            if (autorDto!=null)
            {
                model.apellidosAutor = autorDto.apellidos;
                model.nombresAutor= autorDto.nombres;
            }
            return View(model);            
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libros/Edit/5
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

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libros/Delete/5
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
