namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Autor { get; set; }

        [StringLength(50)]
        public string Cover { get; set; }

        [StringLength(50)]
        public string Genge { get; set; }

        [StringLength(50)]
        public string Publisher { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        public int? Price { get; set; }

        public int? Pages { get; set; }

        public int? Year { get; set; }
    }
}
