using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class LibroRepository
    {
        private ModelLibrary context = new ModelLibrary();

        public List<LibroDto> GetAll()
        {
            List<LibroDto> librosDto = new List<LibroDto>();
            try
            {
                librosDto = context
                    .libros
                    .Select(x => new LibroDto
                    {
                        editorial = new EditorialDto
                        {
                            id = x.editorial.id,
                            nombre = x.editorial.nombre,
                            sede = x.editorial.sede
                        },
                        editorial_id = x.editorial_id,
                        isbn = x.isbn,
                        n_paginas = x.n_paginas,
                        sinopsis = x.sinopsis,
                        titulo = x.titulo
                    })
                    .ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return librosDto;
        }

        public LibroDto GetByISBN(int id)
        {
            LibroDto libroDto = null;
            try
            {
                libroDto = context
                    .libros
                    .Where(x => x.isbn == id)
                    .Select(x => new LibroDto
                    {
                        editorial = new EditorialDto
                        {
                            id = x.editorial.id,
                            nombre = x.editorial.nombre,
                            sede = x.editorial.sede
                        },
                        editorial_id = x.editorial_id,
                        isbn = x.isbn,
                        n_paginas = x.n_paginas,
                        sinopsis = x.sinopsis,
                        titulo = x.titulo
                    })
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return libroDto;
        }
    }
}
