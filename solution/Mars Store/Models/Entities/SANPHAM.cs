namespace Mars_Store.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            BINHLUANs = new HashSet<BINHLUAN>();
            CTDONHANGs = new HashSet<CTDONHANG>();
            LOAISANPHAMs = new HashSet<LOAISANPHAM>();
            SPGIAMGIAs = new HashSet<SPGIAMGIA>();
        }

        [Key]
        public int ID_SP { get; set; }

        public int ID_DM { get; set; }

        [Required]
        public string tensanpham { get; set; }

        public int giabd { get; set; }

        public int? trongluong { get; set; }

        [Required]
        [StringLength(250)]
        public string ImgLink { get; set; }

        [Required]
        [StringLength(250)]
        public string mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDONHANG> CTDONHANGs { get; set; }

        public virtual DANHMUC DANHMUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOAISANPHAM> LOAISANPHAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPGIAMGIA> SPGIAMGIAs { get; set; }
    }
}
