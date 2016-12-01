namespace Final_Project_Part1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Soup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Item { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }
    }
}
