using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AutorRepository
    {
        private ModelLibrary context = new ModelLibrary();
        public AutorDto GetByISBN(int id)
        {
            AutorDto autorDto = null;
            try
            {
                var autorid=context
                    .autores_has_libros
                    .Where(x => x.isbn_libro == id)
                    .Select(x => x.autor_id)
                    .FirstOrDefault();
                if (autorid>0)
                {
                    autorDto = context
                        .autores
                        .Where(x => x.id == autorid)
                        .Select(x=>new AutorDto { 
                            apellidos=x.apellidos,
                            id=x.id,
                            nombres=x.nombres
                        })
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return autorDto;
        }
    }
}
