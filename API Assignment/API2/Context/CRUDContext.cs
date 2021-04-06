using API2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

    }
}
