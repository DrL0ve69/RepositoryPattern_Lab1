using Microsoft.AspNetCore.Mvc;

namespace RepositoryPattern_Lab1.Models
{
    public class Gateau
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        private string _urlImage = "/images/";
        public string UrlImage 
        {
            get => _urlImage;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _urlImage += value;
                }
            }
        }

        public IFormFile ImageFile { get; set; } // Pour le téléchargement de l'image
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
