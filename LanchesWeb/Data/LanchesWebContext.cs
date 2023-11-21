using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LanchesWeb.Models;

namespace LanchesWeb.Data
{
    public class LanchesWebContext : DbContext
    {
        public LanchesWebContext (DbContextOptions<LanchesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; } = default!;

        public DbSet<Lanche>? Lanches { get; set; }
    }
}
