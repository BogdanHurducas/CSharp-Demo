namespace DemoConsole07
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialite()
        {
            Stagiaires = new HashSet<Stagiaire>();
        }

        [Key]
        [Column("id Specialite")]
        public byte id_Specialite { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public decimal Frais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiaire> Stagiaires { get; set; }
    }
}
