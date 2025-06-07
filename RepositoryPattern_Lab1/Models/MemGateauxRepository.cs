
namespace RepositoryPattern_Lab1.Models
{
    public class MemGateauxRepository : IGateauRepository
    {
        /// <summary>
        /// Liste des choix de gâteaux
        /// Voir la différence entre le = et le =>
        /// </summary>
        public IEnumerable<Gateau> ListeGateaux = new List<Gateau>()
        {
        new Gateau{
            Id = 0,
            Nom = "Volcan et dinosaures",
            UrlImage = "Dinos.jpg",
            Description="Gâteau génoise vanille, ganache au chocolat blanc vanille (intérieur) et au chocolat au lait (extérieur), amandes effilées",
            Ingredients="Farine, oeufs, sucre, crème 35%, chocolat blanc, chocolat au lait, café, amandes, etc. "
        },
        new Gateau{
            Id= 1,
            Nom="Mouton mignon",
            UrlImage="Sheep.jpg",
            Description="Gâteau en couches aux couleurs de l'arc-en-ciel avec une dacquoise amandes, crème chantilly mascarpone",
            Ingredients="Farine, oeufs, sucre, amandes, crème 35%, mascarpone, guimauve, etc."
        },
                new Gateau
        {
            Id=2,
            Nom="Ruche",
            UrlImage="Ruche.jpg",
            Description="Gâteau vanille, ganache au chocolat blanc et miel",
            Ingredients="Farine, oeufs, sucre, crème 35%, chocolat blanc, colorant jaune, miel, etc."
        },
        new Gateau
        {
            Id=3,
            Nom="Chat",
            UrlImage="chat.jpg",
            Description="Gâteau damier, génoise chocolat et vanille, crème au beurre meringue italienne, recouvert de pâte à sucre",
            Ingredients="Farine, oeufs, sucre, beurre, colorant, etc."
        }
        };

        IEnumerable<Gateau> IGateauRepository.ListeGateaux => ListeGateaux;

        public void CreerGateau(Gateau gateau)
        {
            ((List<Gateau>)ListeGateaux).Add(gateau);
        }

        public void DeleteGateau(int id)
        {
            ((List<Gateau>)ListeGateaux).RemoveAll(g => g.Id == id);
        }

        public Gateau GetGateau(int id)
        {
            return ListeGateaux.FirstOrDefault(g => g.Id == id);
        }

        public void UpdateGateau(int id, Gateau gateau)
        {
            Gateau gateauOG = ((List<Gateau>)ListeGateaux).FirstOrDefault(g => g.Id == id);
            int indexGateau = ((List<Gateau>)ListeGateaux).IndexOf(gateauOG);

            ((List<Gateau>)ListeGateaux)[indexGateau] = gateau;
        }
    }
}
