using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EncuestasITESRC.Models
{
    public partial class itesrcne_encuestasContext : DbContext
    {
        public itesrcne_encuestasContext()
        {
        }

        public itesrcne_encuestasContext(DbContextOptions<itesrcne_encuestasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Encuesta> Encuesta { get; set; }
        public virtual DbSet<Encuestado> Encuestado { get; set; }
        public virtual DbSet<Opcionrespuesta> Opcionrespuesta { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<Respuestaabierta> Respuestaabierta { get; set; }
        public virtual DbSet<Respuestacerrada> Respuestacerrada { get; set; }
        public virtual DbSet<Tiporespuesta> Tiporespuesta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=204.93.216.11; user id=itesrcne_encuest; password=programadores1ncuest; database=itesrcne_encuestas;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.ToTable("administrador");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.NoControl)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.ToTable("alumno");

                entity.HasIndex(e => e.CarreraId)
                    .HasName("fk_alumno_carrera1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CarreraId)
                    .HasColumnName("carrera_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.NoControl)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.Carrera)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.CarreraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_alumno_carrera1");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.ToTable("carrera");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Estatus).HasColumnType("bit(1)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.ToTable("categoria");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.Estatus).HasColumnType("bit(1)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Encuesta>(entity =>
            {
                entity.ToTable("encuesta");

                entity.HasIndex(e => e.IdAdministrador)
                    .HasName("fkEncuestaAdministrador_idx");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("fkEncuestaCategoria");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnType("longtext");

                entity.Property(e => e.Estado).HasColumnType("bit(1)");

                entity.Property(e => e.Estatus).HasColumnType("bit(1)");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.IdAdministrador).HasColumnType("int(11)");

                entity.Property(e => e.IdCategoria).HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdAdministradorNavigation)
                    .WithMany(p => p.Encuesta)
                    .HasForeignKey(d => d.IdAdministrador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkEncuestaAdministrador");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Encuesta)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkEncuestaCategoria");
            });

            modelBuilder.Entity<Encuestado>(entity =>
            {
                entity.ToTable("encuestado");

                entity.HasIndex(e => e.AlumnoId)
                    .HasName("fk_encuestado_alumno1_idx");

                entity.HasIndex(e => e.IdEncuesta)
                    .HasName("fkEncuestadoEncuesta_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AlumnoId)
                    .HasColumnName("alumno_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaRespuesta).HasColumnType("date");

                entity.Property(e => e.IdEncuesta).HasColumnType("int(11)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Encuestado)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_encuestado_alumno1");

                entity.HasOne(d => d.IdEncuestaNavigation)
                    .WithMany(p => p.Encuestado)
                    .HasForeignKey(d => d.IdEncuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkEncuestadoEncuesta");
            });

            modelBuilder.Entity<Opcionrespuesta>(entity =>
            {
                entity.ToTable("opcionrespuesta");

                entity.HasIndex(e => e.IdPregunta)
                    .HasName("fkOpcionRespuestaPregunta");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdPregunta).HasColumnType("int(11)");

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Opcionrespuesta)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkOpcionRespuestaPregunta");
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.ToTable("pregunta");

                entity.HasIndex(e => e.IdEncuesta)
                    .HasName("fkPreguntaEncuesta");

                entity.HasIndex(e => e.IdTipoRespuesta)
                    .HasName("fkPreguntaTipoRespuesta");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Contenido)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdEncuesta).HasColumnType("int(11)");

                entity.Property(e => e.IdTipoRespuesta).HasColumnType("int(11)");

                entity.HasOne(d => d.IdEncuestaNavigation)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.IdEncuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkPreguntaEncuesta");

                entity.HasOne(d => d.IdTipoRespuestaNavigation)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.IdTipoRespuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkPreguntaTipoRespuesta");
            });

            modelBuilder.Entity<Respuestaabierta>(entity =>
            {
                entity.ToTable("respuestaabierta");

                entity.HasIndex(e => e.IdEncuestado)
                    .HasName("fkRespuestaAEncuestado");

                entity.HasIndex(e => e.IdPregunta)
                    .HasName("fkRespuestaAPregunta");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdEncuestado).HasColumnType("int(11)");

                entity.Property(e => e.IdPregunta).HasColumnType("int(11)");

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdEncuestadoNavigation)
                    .WithMany(p => p.Respuestaabierta)
                    .HasForeignKey(d => d.IdEncuestado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkRespuestaAEncuestado");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Respuestaabierta)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkRespuestaAPregunta");
            });

            modelBuilder.Entity<Respuestacerrada>(entity =>
            {
                entity.ToTable("respuestacerrada");

                entity.HasIndex(e => e.IdEncuestado)
                    .HasName("fkRespuestaCEncuestado");

                entity.HasIndex(e => e.IdOpcionRespuesta)
                    .HasName("fkRespuestaCOpcionRespuesta");

                entity.HasIndex(e => e.IdPregunta)
                    .HasName("fkRespuestaCPregunta");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdEncuestado).HasColumnType("int(11)");

                entity.Property(e => e.IdOpcionRespuesta).HasColumnType("int(11)");

                entity.Property(e => e.IdPregunta).HasColumnType("int(11)");

                entity.HasOne(d => d.IdEncuestadoNavigation)
                    .WithMany(p => p.Respuestacerrada)
                    .HasForeignKey(d => d.IdEncuestado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkRespuestaCEncuestado");

                entity.HasOne(d => d.IdOpcionRespuestaNavigation)
                    .WithMany(p => p.Respuestacerrada)
                    .HasForeignKey(d => d.IdOpcionRespuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkRespuestaCOpcionRespuesta");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Respuestacerrada)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkRespuestaCPregunta");
            });

            modelBuilder.Entity<Tiporespuesta>(entity =>
            {
                entity.ToTable("tiporespuesta");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnType("longtext");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });
        }
    }
}
