using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SGEscolar.Models;

public partial class SgescolarContext : DbContext
{
    public SgescolarContext()
    {
    }

    public SgescolarContext(DbContextOptions<SgescolarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Calificacione> Calificaciones { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; DataBase=SGEscolar;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.ToTable("alumnos");

            entity.Property(e => e.AlumnoId).HasColumnName("alumno_id");
            entity.Property(e => e.AlumnoCorreo)
                .HasMaxLength(50)
                .HasColumnName("alumno_correo");
            entity.Property(e => e.AlumnoNombre)
                .HasMaxLength(50)
                .HasColumnName("alumno_nombre");
            entity.Property(e => e.AlumnoTelefono)
                .HasMaxLength(50)
                .HasColumnName("alumno_telefono");
        });

        modelBuilder.Entity<Calificacione>(entity =>
        {
            entity.HasKey(e => e.CalificacionId);

            entity.ToTable("calificaciones");

            entity.Property(e => e.CalificacionId).HasColumnName("calificacion_id");
            entity.Property(e => e.AlumnoId).HasColumnName("alumno_id");
            entity.Property(e => e.Calificacion).HasColumnName("calificacion");
            entity.Property(e => e.MateriaId).HasColumnName("materia_id");

            entity.HasOne(d => d.Alumno).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.AlumnoId)
                .HasConstraintName("FK_calificaciones_alumnos");

            entity.HasOne(d => d.Materia).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.MateriaId)
                .HasConstraintName("FK_calificaciones_materias");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.ToTable("materias");

            entity.Property(e => e.MateriaId).HasColumnName("materia_id");
            entity.Property(e => e.MateriaNombre)
                .HasMaxLength(100)
                .HasColumnName("materia_nombre");
            entity.Property(e => e.ProfesorId).HasColumnName("profesor_id");

            entity.HasOne(d => d.Profesor).WithMany(p => p.Materia)
                .HasForeignKey(d => d.ProfesorId)
                .HasConstraintName("FK_materias_profesores");
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.HasKey(e => e.ProfesorId);

            entity.ToTable("profesores");

            entity.Property(e => e.ProfesorId).HasColumnName("profesor_id");
            entity.Property(e => e.ProfesorCorreo)
                .HasMaxLength(80)
                .HasColumnName("profesor_correo");
            entity.Property(e => e.ProfesorNombre)
                .HasMaxLength(100)
                .HasColumnName("profesor_nombre");
            entity.Property(e => e.ProfesorTelefono)
                .HasMaxLength(50)
                .HasColumnName("profesor_telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
