using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Team_Todo_Management.Extensions;
using Team_Todo_Management.Models;

namespace Team_Todo_Management.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected readonly IConfiguration Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DataContext(DbContextOptions options, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            Configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            /** Connect to database here */
            options.UseSqlServer("Server=MINH-COMPUTER\\SQLEXPRESS;Database=todos_db;User Id=sa;Password=12345678a@");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigDBTablesRelationship();

            modelBuilder.ConfigTablesRequirements();

            modelBuilder.Seed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AutoTrack();
            int result = await base.SaveChangesAsync();

            return result;
        }

        private void AutoTrack()
        {
            /** Auto apply info of user and time every time entity is modified */
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseModel && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseModel)entity.Entity).CreatedAt = DateTime.UtcNow;
                    ((BaseModel)entity.Entity).CreatedById = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value
                        ?? null;
                }

                ((BaseModel)entity.Entity).LastModifiedAt = DateTime.UtcNow;
                ((BaseModel)entity.Entity).LastModifiedById = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value
                        ?? null;
            }
        }
    }
}
