namespace SaleManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAPSP")]
    public partial class NHAPSP
    {
        [Key]
        public int MANSP { get; set; }

        public int MASP { get; set; }

        public decimal GIANHAP { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYNHAP { get; set; }

        public int SOLUONG { get; set; }

        public decimal THANHTIEN { get; set; }

        public int MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
