namespace DemoConsole07
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mouchard")]
    public partial class Mouchard
    {
        public int id { get; set; }

        public int? idstagiaire { get; set; }

        public DateTime? dateInscription { get; set; }

        [StringLength(30)]
        public string Qui { get; set; }
    }
}
