using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern_Lab1.Models;

public class DB_CatalogueGateaux : DbContext
{
    public DB_CatalogueGateaux(DbContextOptions<DB_CatalogueGateaux> options) : base(options) { }
    public DbSet­<Gateau> Gateaux {  get; set; } // Table pour gateaux
    public DbSet­<Ingredient> Ingredient { get; set; } // Table pour Ingredients


}
