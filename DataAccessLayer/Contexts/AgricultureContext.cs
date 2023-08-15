using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KURSAD\\SQLEXPRESS; database=DbAgricultureContext; Trusted_Connection=true");
        }
        public DbSet<Adress> Adresses => Set<Adress>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<Image> Images => Set<Image>();
        public DbSet<Announcement> Announcements => Set<Announcement>();
        public DbSet<Service> Services => Set<Service>();
        public DbSet<Team> Teams => Set<Team>();
        public DbSet<SocialMedia> SocialMedias => Set<SocialMedia>();
        public DbSet<About> Abouts => Set<About>();
        public DbSet<Admin> Admins => Set<Admin>();
    }
}
