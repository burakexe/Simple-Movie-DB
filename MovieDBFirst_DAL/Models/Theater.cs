namespace MovieDBFirst_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Theater
    {
        public int TheaterID { get; set; }

        public int MovieID { get; set; }

        public int SessionID { get; set; }

        public int SaloonID { get; set; }

        public int WeekID { get; set; }

        public virtual Movy Movy { get; set; }

        public virtual Saloon Saloon { get; set; }

        public virtual Session Session { get; set; }

        public virtual Week Week { get; set; }
    }
}
