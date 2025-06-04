namespace RepositoryPattern_Lab1.Models
{
    public interface IGateauRepository
    {
        /// <summary>
        /// La liste de gateaux 
        /// </summary>
        IEnumerable<Gateau> ListeGateaux { get; }

        /// <summary>
        /// Retourne le gateau dans la liste avec le id
        /// </summary>
        /// <param name="id">Id pour le gateau</param>
        /// <returns>Retourne le gateau trouvé</returns>
        Gateau GetGateau(int id);
        void CreerGateau(Gateau gateau);
        void DeleteGateau(int id);
        void UpdateGateau(int id,Gateau gateau);
    }
}
