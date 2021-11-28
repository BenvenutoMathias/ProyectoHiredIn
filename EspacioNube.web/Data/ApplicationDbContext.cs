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

        /* PARA AGREGAR PROPIEDADES A ENTITY */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(entityTypeBuilder =>
            {
                entityTypeBuilder.ToTable("User");

                entityTypeBuilder.Property(u => u.UserName)
                        .HasMaxLength(100)
                        .HasDefaultValue(0);
                entityTypeBuilder.Property(u => u.Gender)
            .HasMaxLength(1);
            });

        }
        /* PARA AGREGAR PROPIEDADES A ENTITY */

    }


  /*   public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

    } */
}
