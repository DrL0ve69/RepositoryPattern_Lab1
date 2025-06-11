
namespace RepositoryPattern_Lab1.Models
{
    public class DBGateauxRepository : IGateauRepository
    {
        private readonly DB_CatalogueGateaux _context; // BD
        public DBGateauxRepository(DB_CatalogueGateaux context)
        {
            _context = context; // Récupérer la BD dans le service
        }

        /// <summary>
        /// Liste des choix de gâteaux
        /// Voir la différence entre le = et le =>
        /// </summary>
        /*
        public List<Gateau> ListeGateaux = new List<Gateau>()
        {
        new Gateau{
            Id = 0,
            Nom = "Volcan et dinosaures",
            UrlImage = "/images/Dinos.jpg",
            Description="Gâteau génoise vanille, ganache au chocolat blanc vanille (intérieur) et au chocolat au lait (extérieur), amandes effilées",
            Ingredients="Farine, oeufs, sucre, crème 35%, chocolat blanc, chocolat au lait, café, amandes, etc. "
        },
        new Gateau{
            Id= 1,
            Nom="Mouton mignon",
            UrlImage="/images/Sheep.jpg",
            Description="Gâteau en couches aux couleurs de l'arc-en-ciel avec une dacquoise amandes, crème chantilly mascarpone",
            Ingredients="Farine, oeufs, sucre, amandes, crème 35%, mascarpone, guimauve, etc."
        },
                new Gateau
        {
            Id=2,
            Nom="Ruche",
            UrlImage="/images/Ruche.jpg",
            Description="Gâteau vanille, ganache au chocolat blanc et miel",
            Ingredients="Farine, oeufs, sucre, crème 35%, chocolat blanc, colorant jaune, miel, etc."
        },
        new Gateau
        {
            Id=3,
            Nom="Chat",
            UrlImage="/images/chat.jpg",
            Description="Gâteau damier, génoise chocolat et vanille, crème au beurre meringue italienne, recouvert de pâte à sucre",
            Ingredients="Farine, oeufs, sucre, beurre, colorant, etc."
        }
        };
        */

        IEnumerable<Gateau> IGateauRepository.ListeGateaux => _context.Gateaux;

        public void CreerGateau(Gateau gateau)
        {
            _context.Gateaux.Add(gateau);
            _context.SaveChanges();
        }

        public void DeleteGateau(int id)
        {
            _context.Gateaux.Remove(GetGateau(id));
            _context.SaveChanges();
        }

        public Gateau GetGateau(int id)
        {
            return _context.Gateaux.FirstOrDefault(g => g.Id == id);
        }

        public void UpdateGateau(int id, Gateau gateau)
        {
            _context.Gateaux.Update(gateau);
            _context.SaveChanges();
        }
    }
}
