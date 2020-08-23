namespace Mars_Store.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANQUYEN")]
    public partial class PHANQUYEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TENQUYEN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TK { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
