namespace MovieDBFirst_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actor()
        {
            Movies = new HashSet<Movy>();
        }

        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string SurName { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ActorAndFilm_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movy> Movies { get; set; }
    }
}
