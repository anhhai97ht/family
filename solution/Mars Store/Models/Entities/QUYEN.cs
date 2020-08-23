namespace Mars_Store.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYEN")]
    public partial class QUYEN
    {
        [Key]
        public int ID_QUYEN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENQUYEN { get; set; }
    }
}
