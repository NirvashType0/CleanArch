using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class S10290D0Context : DbContext
    {
        public S10290D0Context(DbContextOptions options) : base(options){}
        public DbSet<Course> Courses { get; set; }
    }
}
