using System;
using System.Collections.Generic;
using System.Text;
using EfCoreApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EfCoreApp.Data
{
    public class TodoDbContext : DbContext
    {

        public TodoDbContext(DbContextOptionsBuilder builder) : base(builder.Options)
        {
        }
        public DbSet<TodoItem> TodoItems
        {
            get; set;
        }
        // Metot ile ayarların yapılması



    }
}
