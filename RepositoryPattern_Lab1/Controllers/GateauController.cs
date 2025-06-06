using Microsoft.AspNetCore.Mvc;
using RepositoryPattern_Lab1.Models;

namespace RepositoryPattern_Lab1.Controllers
{
    public class GateauController : Controller
    {
        private IGateauRepository _gateauRepository; // liste de gâteaux

        /// <summary>
        /// Constructeur du controller: Initialise la liste et les méthodes pour le gâteaux
        /// </summary>
        /// <param name="gateauRepository">ServiceParameter</param>
        public GateauController(IGateauRepository gateauRepository)
        {
            _gateauRepository = gateauRepository; // Récupère le service soit la liste de gâteaux
        }

        public IActionResult Index()
        {
            return View(_gateauRepository.ListeGateaux); // Récupère la liste pour le modèle
        }
        public IActionResult Details(int id) 
        {
            return View(_gateauRepository.GetGateau(id));
        }

        public IActionResult Supprimer(int id) 
        {
            _gateauRepository.DeleteGateau(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreerNouveauGateau() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerNouveauGateau(Gateau gateau) 
        {
            try
            {
                _gateauRepository.CreerGateau(gateau);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult ModifierGateau(int id) 
        {
            Gateau gateau = _gateauRepository.GetGateau(id);
            return View(gateau);
        }
        [HttpPost]
        public IActionResult ModifierGateau(int id, Gateau gateau) 
        {
            _gateauRepository.UpdateGateau(id, gateau);
            return RedirectToAction(nameof(Index));
        }
    }
}
