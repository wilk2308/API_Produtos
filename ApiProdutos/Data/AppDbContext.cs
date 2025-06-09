using ApiProdutos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}

