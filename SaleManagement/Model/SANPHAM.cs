namespace SaleManagement.Model
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
            CHITIETHD = new HashSet<CHITIETHD>();
            NHAPSP = new HashSet<NHAPSP>();
        }

        [Key]
        public int MASP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSP { get; set; }

        public int SOLUONGTON { get; set; }

        public decimal GIABAN { get; set; }

        public string GHICHU { get; set; }

        [StringLength(60)]
        public string HINHANH { get; set; }

        public int IDDanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHD> CHITIETHD { get; set; }

        public virtual DANHMUCSP DANHMUCSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPSP> NHAPSP { get; set; }
    }
}
