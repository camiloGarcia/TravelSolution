using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LibroDto
    {       
        public int isbn { get; set; }

        public int? editorial_id { get; set; }
     
        public string titulo { get; set; }
        
        public string sinopsis { get; set; }

        public int? n_paginas { get; set; }

        public virtual EditorialDto editorial { get; set; }
    }
}
