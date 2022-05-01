using Diarymous.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasMany(acc => acc.diaries).WithOne(diary => diary.author);
            modelBuilder.Entity<Account>().HasMany(acc => acc.likedPosts);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Suggestion> suggestions {get;set;}
        public DbSet<Diary> diaries { get; set; }
        public DbSet<Account> accounts { get; set; }
    }
}
