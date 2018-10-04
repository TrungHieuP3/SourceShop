namespace Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reply")]
    public partial class Reply
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RepNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string ComID { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }

        [StringLength(60)]
        public string CusID { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
