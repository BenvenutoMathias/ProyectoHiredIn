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

                /* entityTypeBuilder.Property(u => u.UserName)
                        .HasMaxLength(100)
                        .HasDefaultValue(0);
                entityTypeBuilder.Property(u => u.Gender) 
            .HasMaxLength(1); */
            });

            builder.Entity<Postulante>()
                        .HasMany<Empresa>(p => p.Empresas)
                        .WithMany(e => e.Postulantes)
                        .UsingEntity(pe => pe.ToTable("PostulanteEmpresa"));
        }
        /*  User */

    }
    /* PARA AGREGAR PROPIEDADES A ENTITY */

}


