using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base()
        {
        }

        public static string ConnectionString { get; set; } = string.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entityTypeBuilder =>
            {
                entityTypeBuilder.ToTable("User");

                builder.Entity<IdentityRole>(entity => entity.ToTable(name: "Roles"));
                builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UsersRoles"));
                builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UsersClaims"));
                builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UsersLogins"));
                builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RolesClaims"));
                builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UsersTokens"));
            });

            builder.Entity<Empresa>()
                       .HasMany<Post>(p => p.Publicaciones);

            builder.Entity<Postulante>()
                        .HasMany<Empresa>(p => p.Empresas)
                        .WithMany(e => e.Postulantes)
                        .UsingEntity(pe => pe.ToTable("PostulanteEmpresa"));
        }

        public DbSet<Postulante> Postulantes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

}
