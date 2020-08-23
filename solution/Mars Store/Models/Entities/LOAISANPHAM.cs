namespace Mars_Store.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISANPHAM")]
    public partial class LOAISANPHAM
    {
        [Key]
        public int ID_LOAISANPHAM { get; set; }

        [StringLength(250)]
        public string tenspthem { get; set; }

        public int ID_SP { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
