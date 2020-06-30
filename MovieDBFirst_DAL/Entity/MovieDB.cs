namespace MovieDBFirst_DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieDB : DbContext
    {
        public MovieDB()
            : base("name=MovieDB")
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movy> Movies { get; set; }
        public virtual DbSet<Saloon> Saloons { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Theater> Theaters { get; set; }
        public virtual DbSet<Week> Weeks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Actors)
                .Map(m => m.ToTable("MovieActors").MapRightKey("Movie_ID"));

            modelBuilder.Entity<Director>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Directors)
                .Map(m => m.ToTable("DirectorMovies").MapLeftKey("Director_ID").MapRightKey("Movie_ID"));

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Genres)
                .Map(m => m.ToTable("Movie_Genre_Joined").MapLeftKey("GenreID").MapRightKey("MovieID"));

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Theaters)
                .WithRequired(e => e.Movy)
                .HasForeignKey(e => e.MovieID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Saloon>()
                .HasMany(e => e.Theaters)
                .WithRequired(e => e.Saloon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.Theaters)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Week>()
                .HasMany(e => e.Theaters)
                .WithRequired(e => e.Week)
                .WillCascadeOnDelete(false);
        }
    }
}
