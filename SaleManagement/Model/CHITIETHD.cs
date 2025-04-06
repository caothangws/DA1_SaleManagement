namespace SaleManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHD")]
    public partial class CHITIETHD
    {
        [Key]
        public int MACT { get; set; }

        [Required]
        [StringLength(50)]
        public string MAHD { get; set; }

        public int MASP { get; set; }

        public int SOLUONG { get; set; }

        public decimal THANHTIEN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
