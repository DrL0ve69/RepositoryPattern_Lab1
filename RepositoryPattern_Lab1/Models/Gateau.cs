namespace RepositoryPattern_Lab1.Models
{
    public class Gateau
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string UrlImage { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public Gateau() { }

        public Gateau(int id, string nom, string urlImage, string description, string ingredients)
        {
            Id = id;
            Nom = nom;
            UrlImage = urlImage;
            Description = description;
            Ingredients = ingredients;
        }
    }
    
}
