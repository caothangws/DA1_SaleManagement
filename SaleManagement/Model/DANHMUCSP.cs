namespace SaleManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUCSP")]
    public partial class DANHMUCSP
    {
        [Key]
        public int IDDanhMuc { get; set; }

        [Required]
        public string TENDM { get; set; }

        [Required]
        [StringLength(10)]
        public string CodeDM { get; set; }
    }
}
