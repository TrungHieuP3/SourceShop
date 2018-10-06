namespace Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [StringLength(12)]
        public string BillID { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(60)]
        public string CusID { get; set; }

        public int Pay { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual User User { get; set; }
    }
}
