namespace RepositoryPattern_Lab1.Models;

public static class Db_Seeders
{
    private static List<Gateau> _listeGateaux = new List<Gateau>()
    {
        new Gateau{
            //Id = 0,
            Nom = "Volcan et dinosaures",
            UrlImage = "/images/Dinos.jpg",
            Description="Gâteau génoise vanille, ganache au chocolat blanc vanille (intérieur) et au chocolat au lait (extérieur), amandes effilées",
            Ingredients="Farine, oeufs, sucre, crème 35%, chocolat blanc, chocolat au lait, café, amandes, etc. "
        },
        new Gateau{
            //Id= 1,
            Nom="Mouton mignon",
            UrlImage="/images/Sheep.jpg",
            Description="Gâteau en couches aux couleurs de l'arc-en-ciel avec une dacquoise amandes, crème chantilly mascarpone",
            Ingredients="Farine, oeufs, sucre, amandes, crème 35%, mascarpone, guimauve, etc."
        },
                new Gateau
        {
            //Id=2,
            Nom="Ruche",
            UrlImage="/images/Ruche.jpg",
            Description="Gâteau vanille, ganache au chocolat blanc et miel",
            Ingredients="Farine, oeufs, sucre, crème 35%, chocolat blanc, colorant jaune, miel, etc."
        },
        new Gateau
        {
            //Id=3,
            Nom="Chat",
            UrlImage="/images/chat.jpg",
            Description="Gâteau damier, génoise chocolat et vanille, crème au beurre meringue italienne, recouvert de pâte à sucre",
            Ingredients="Farine, oeufs, sucre, beurre, colorant, etc."
        }
    };
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        DB_CatalogueGateaux context = applicationBuilder.ApplicationServices.CreateScope()
            .ServiceProvider.GetRequiredService<DB_CatalogueGateaux>();

        if (!context.Gateaux.Any())context.Gateaux.AddRange(_listeGateaux) ;
        context.SaveChanges();
    }
}
