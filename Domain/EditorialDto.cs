using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EditorialDto
    {
        public EditorialDto()
        {
            librosDto = new HashSet<LibroDto>();
        }

        public int id { get; set; }
        
        public string nombre { get; set; }
        
        public string sede { get; set; }
        
        public ICollection<LibroDto> librosDto { get; set; }
    }
}
