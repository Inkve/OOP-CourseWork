using CourseWork_With_SQLite.Classes;
using Microsoft.EntityFrameworkCore;

namespace CourseWork_With_SQLite.Context
{
    internal partial class CourseWorkContext : DbContext
    {
        public CourseWorkContext()
        {
            Database.EnsureCreated();
        }
        public CourseWorkContext(DbContextOptions<CourseWorkContext> options) : base(options) { }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Coursework.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SpecialityCode).HasColumnType("VARCHAR");
                entity.Property(e => e.Name).HasColumnType("VARCHAR");
                entity.Property(e => e.FacultyId).HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Surname).HasColumnType("VARCHAR");
                entity.Property(e => e.Name).HasColumnType("VARCHAR");
                entity.Property(e => e.Patronymic).HasColumnType("VARCHAR");
                entity.Property(e => e.BirthdayDate).HasColumnType("DATETIME");
                entity.Property(e => e.Budget).HasColumnType("BOOL");
                entity.Property(e => e.SemesterOfStudy).HasColumnType("INT");
                entity.Property(e => e.SpecialityCode).HasColumnType("VARCHAR");
                entity.Property(e => e.Group).HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SpecialityID).HasColumnType("VARCHAR");
                entity.Property(e => e.Name).HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdStudent).HasColumnType("VARCHAR");
                entity.Property(e => e.IdSubject).HasColumnType("VARCHAR");
                entity.Property(e => e.Semester).HasColumnType("INT");
                entity.Property(e => e.Score).HasColumnType("INT");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
