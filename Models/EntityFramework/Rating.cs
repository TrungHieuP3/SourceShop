namespace Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rating
    {
        [Key]
        [StringLength(10)]
        public string RatID { get; set; }

        [Required]
        [StringLength(60)]
        public string ProID { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public int Level { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
