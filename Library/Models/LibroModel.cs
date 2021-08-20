using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class LibroModel
    {
        [Display(Name ="ISBN")]
        public int isbn { get; set; }

        public int? editorial_id { get; set; }

        [Display(Name = "Editorial")]
        public string editorial { get; set; }

        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Display(Name = "Sinopsis")]
        public string sinopsis { get; set; }

        [Display(Name = "# Paginas")]
        public int? n_paginas { get; set; }
       
    }
}