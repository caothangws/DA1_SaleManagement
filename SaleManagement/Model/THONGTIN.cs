namespace SaleManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTIN")]
    public partial class THONGTIN
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TENCOSO { get; set; }

        [Required]
        [StringLength(50)]
        public string NGUOIDAIDIEN { get; set; }

        [Required]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(50)]
        public string SDT { get; set; }

        [Column(TypeName = "ntext")]
        public string LOGO { get; set; }
    }
}
