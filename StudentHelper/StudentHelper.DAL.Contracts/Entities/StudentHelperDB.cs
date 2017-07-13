namespace StudentHelper.DAL.Contracts.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentHelperDB : DbContext
    {
        public StudentHelperDB()
            : base("name=StudentHelperDB")
        {
        }

        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Recension> Recension { get; set; }
        public virtual DbSet<Science> Science { get; set; }
        public virtual DbSet<Script> Script { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .Property(e => e.ScienceName)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionAnswer>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Recension>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Recension>()
                .Property(e => e.RecensionDate)
                .IsFixedLength();

            modelBuilder.Entity<Science>()
                .Property(e => e.ScienceName)
                .IsUnicode(false);

            modelBuilder.Entity<Script>()
                .Property(e => e.DateCreated)
                .IsFixedLength();

            modelBuilder.Entity<Script>()
                .Property(e => e.ScriptTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Script>()
                .HasMany(e => e.User1)
                .WithMany(e => e.Script1)
                .Map(m => m.ToTable("UserUseScript").MapLeftKey("ScriptId").MapRightKey("UserId"));

            modelBuilder.Entity<Test>()
                .Property(e => e.DateOfTest)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Script)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);
        }
    }
}
