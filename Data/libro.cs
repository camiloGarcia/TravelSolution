namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("libro")]
    public partial class libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isbn { get; set; }

        public int? editorial_id { get; set; }

        [StringLength(50)]
        public string titulo { get; set; }

        [Column(TypeName = "text")]
        public string sinopsis { get; set; }

        public int? n_paginas { get; set; }

        public virtual editorial editorial { get; set; }
    }
}
