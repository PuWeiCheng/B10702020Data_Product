namespace hk2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [StringLength(50)]
        public string Product_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Name { get; set; }

        public int Product_Amount { get; set; }

        public int Product_Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Class { get; set; }
    }
}
