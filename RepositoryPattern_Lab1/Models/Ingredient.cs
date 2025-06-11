using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern_Lab1.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Type { get; set; }
    public float Quantite { get; set; }
    public string Unite { get; set; }
    public double Prix { get; set; }
    public int GateauID { get; set; } // Clé étrangère
    public Gateau Gateau { get; set; } // Navigation
}
