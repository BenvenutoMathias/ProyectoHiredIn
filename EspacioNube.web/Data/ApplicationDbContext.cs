using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

using EspacioNube.web.Models;

namespace EspacioNube.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Postulante> Postulantes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        /* Agregado */
        // protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        // {



        //     modelBuilder.Entity<Postulante>()
        //                 .HasMany<Empresa>(p => p.Empresas)
        //                 .WithMany(e => e.Postulantes)
        //                 .Map(cs =>
        //                         {
        //                             cs.MapLeftKey("PostulanteRefId");
        //                             cs.MapRightKey("EmpresaRefId");
        //                             cs.ToTable("PostulanteEmpresa");
        //                         });

        // }

        /* Agregado */


        /* PARA AGREGAR PROPIEDADES A ENTITY */
        /*  User */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(entityTypeBuilder =>
            {
                entityTypeBuilder.ToTable("User");

                
                builder.Entity<IdentityRole>(entiy => entiy.ToTable(name: "Roles"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UsersRoles"));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UsersClaims"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UsersLogins"));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RolesClaims"));
            builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UsersTokens"));

            
            });
        /*  User */

            builder.Entity<Postulante>()
                        .HasMany<Empresa>(p => p.Empresas)
                        .WithMany(e => e.Postulantes)
                        .UsingEntity(pe => pe.ToTable("PostulanteEmpresa"));
        }

    }
    /* PARA AGREGAR PROPIEDADES A ENTITY */

}


