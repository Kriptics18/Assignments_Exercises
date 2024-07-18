using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using System.Data;

namespace Infrastructure.Data {
    public class MovieDbContext : DbContext {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) {
        }

        public DbSet<Genres> Genres { get; set; }
        public DbSet<Casts> Casts { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieGenres> MovieGenres { get; set; }
        public DbSet<MovieCasts> MovieCasts { get; set; }
        public DbSet<Trailers> Trailers { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Purchases> Purchases { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // MovieGenres configuration
            modelBuilder.Entity<MovieGenres>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });

            modelBuilder.Entity<MovieGenres>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);

            modelBuilder.Entity<MovieGenres>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);

            // MovieCasts configuration
            modelBuilder.Entity<MovieCasts>()
                .HasKey(mc => new { mc.MovieId, mc.CastId });

            modelBuilder.Entity<MovieCasts>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieCasts)
                .HasForeignKey(mc => mc.MovieId);

            modelBuilder.Entity<MovieCasts>()
                .HasOne(mc => mc.Cast)
                .WithMany(c => c.MovieCasts)
                .HasForeignKey(mc => mc.CastId);

            // Favorites configuration
            modelBuilder.Entity<Favorites>()
                .HasKey(f => new { f.MovieId, f.UserId });

            modelBuilder.Entity<Favorites>()
                .HasOne(f => f.Movie)
                .WithMany(m => m.Favorites)
                .HasForeignKey(f => f.MovieId);

            modelBuilder.Entity<Favorites>()
                .HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId);

            // Reviews configuration
            modelBuilder.Entity<Reviews>()
                .HasKey(r => new { r.MovieId, r.UserId });

            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieId);

            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            // Purchases configuration
            modelBuilder.Entity<Purchases>()
                .HasKey(p => new { p.MovieId, p.UserId });

            modelBuilder.Entity<Purchases>()
                .HasOne(p => p.Movie)
                .WithMany(m => m.Purchases)
                .HasForeignKey(p => p.MovieId);

            modelBuilder.Entity<Purchases>()
                .HasOne(p => p.User)
                .WithMany(u => u.Purchases)
                .HasForeignKey(p => p.UserId);

            // UserRoles configuration
            modelBuilder.Entity<UserRoles>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRoles>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRoles>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(
                    "your_connection_string",
                    sqlServerOptions => sqlServerOptions.CommandTimeout(180));
            }
        }
    }
}
