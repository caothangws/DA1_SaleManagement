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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUCSP()
        {
            SANPHAM = new HashSet<SANPHAM>();
        }

        [Key]
        public int IDDanhMuc { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDM { get; set; }

        [Required]
        [StringLength(50)]
        public string CodeDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAM { get; set; }
    }
}
