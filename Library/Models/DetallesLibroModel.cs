using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class DetallesLibroModel
    {
        [Display(Name = "ISBN")]
        public int isbn { get; set; }

        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Display(Name = "Sinopsis")]
        public string sinopsis { get; set; }

        [Display(Name = "# Paginas")]
        public int? n_paginas { get; set; }

        [Display(Name = "Nombre Editorial")]
        public string nombreEditorial { get; set; }

        [Display(Name = "Sede Editorial")]
        public string sedeEditorial { get; set; }

        [Display(Name = "Nombres Autor")]
        public string nombresAutor { get; set; }

        [Display(Name = "Apellidos Autor")]
        public string apellidosAutor { get; set; }

    }
}