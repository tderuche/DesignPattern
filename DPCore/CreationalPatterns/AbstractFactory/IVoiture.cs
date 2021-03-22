namespace DPCore.AbstractFactory
{
    /// <summary>
    /// Interface pour tous les types de voitures
    /// </summary>
    public interface IVoiture
    {
        /// <summary>
        /// Obtention du prix de la voiture
        /// </summary>
        /// <returns>Prix de la voiture</returns>
        string ObtenirPrix();

        /// <summary>
        /// Obtention du nom de la voiture
        /// </summary>
        /// <returns>Nom de la voiture</returns>
        string ObtenirNomVoiture();
    }
}
