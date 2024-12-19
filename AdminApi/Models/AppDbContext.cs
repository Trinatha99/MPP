using AdminApi.Models.App;
using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using System;

namespace AdminApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<FilterValues> FilterValues { get; set; }
        public virtual DbSet<FilterSetting> FilterSettings { get; set; }
       
        public virtual DbSet<MarketUsers> MarketUsers { get; set; }
        public virtual DbSet<MarketUserLogHistory> MarketUserLogHistory { get; set; }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Notifications> GetNotifications { get; set; }

        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GalleryCategory> GalleryCategories { get; set; }
        public virtual DbSet<Facilities> GetFacilities { get; set; }
        public virtual DbSet<SubCourse> SubCourses { get; set; }
        public virtual DbSet<Students>Studentss { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<FixVideo> FixVideos { get; set; }
        public virtual DbSet<DemoVideo> DemoVideos { get; set; }

        public virtual DbSet<FacultyVideoUpload> FacultyVideoUploads { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<Category>()
            .HasMany(e => e.Children)

            .WithOne() // EF Core
            .HasForeignKey(e => e.Parent);


            modelBuilder.Entity<Category>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Category>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();


            modelBuilder.Entity<Filter>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Filter>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();


            modelBuilder.Entity<FilterValues>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FilterValues>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();



            modelBuilder.Entity<FilterSetting>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FilterSetting>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();



            modelBuilder.Entity<MarketUsers>()
          .Property(s => s.DateAdded)
          .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<MarketUsers>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<MarketUsers>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<Course>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Course>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<Students>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Students>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<Subject>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Subject>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<Teacher>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Teacher>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<FixVideo>()
          .Property(s => s.CreatedOn)
          .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FixVideo>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();


            modelBuilder.Entity<DemoVideo>()
         .Property(s => s.CreatedOn)
         .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<DemoVideo>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<FacultyVideoUpload>()
        .Property(s => s.CreatedOn)
        .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FacultyVideoUpload>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();
        }


    }
}
