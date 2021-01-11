﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication5.Models.DB
{
    public partial class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

      

    }
}
