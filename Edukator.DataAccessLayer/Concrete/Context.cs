﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Edukator.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser1, AppRole1, int>
    {
        //10
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-28U4354N\\SQLEXPRESS;initial catalog=DbEdukatorMongo;integrated security = true;");
        }

        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; } //11
    }
}