namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("autor")]
    public partial class autor
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nombres { get; set; }

        [StringLength(50)]
        public string apellidos { get; set; }
    }
}
