using DataAccess.Context.Initializers;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataAccess.Context
{
    public class TestsContext : DbContext
    {
        private static TestsContext _instance;
        private TestsContext()
        {
            //TestsInitializer.Initialize(this);
        }
        public TestsContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            TestsInitializer.Initialize(this);
        }
        public static TestsContext GetContext()
        {
            if (_instance == null)
                _instance = new TestsContext();
            return _instance;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        #region DbSets
        public DbSet<LoginUser> Logins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTest> UserTests { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        #endregion
        #region Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Primary Keys
            modelBuilder.Entity<Answer>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<LoginUser>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Question>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Test>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<UserTest>()
                .HasKey(x => x.Id);
            #endregion
            #region Relations
            modelBuilder.Entity<Answer>()
                .HasOne(x => x.Question)
                .WithMany(x => x.Answers)
                .HasForeignKey(x => x.QuestionId);
            modelBuilder.Entity<LoginUser>()
                .HasOne(x => x.User)
                .WithOne(x => x.Login).HasForeignKey<LoginUser>(x => x.UserId);
            modelBuilder.Entity<Question>()
                .HasOne(x => x.Test)
                .WithMany(x => x.Questions);
            modelBuilder.Entity<Question>()
                .HasMany(x => x.Answers)
                .WithOne(x => x.Question);
            modelBuilder.Entity<Test>()
                .HasMany(x => x.Questions)
                .WithOne(x => x.Test);
            modelBuilder.Entity<Test>()
                .HasMany(x => x.Users)
                .WithOne(x => x.Test);
            modelBuilder.Entity<User>()
                .HasMany(x => x.Tests)
                .WithOne(x => x.User);
            modelBuilder.Entity<User>()
                .HasOne(x => x.Login)
                .WithOne(x => x.User).HasForeignKey<User>(x => x.LoginId);
            modelBuilder.Entity<UserTest>()
                .HasOne(x => x.User)
                .WithMany(x => x.Tests)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserTest>()
                .HasOne(x => x.Test)
                .WithMany(x => x.Users)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
        #endregion
    }
}
