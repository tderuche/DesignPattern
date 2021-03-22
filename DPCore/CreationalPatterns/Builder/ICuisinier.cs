namespace DPCore.Builder
{
    /// <summary>
    /// Description du travail d'un cuisinier
    /// </summary>
    public interface ICuisinier
    {
        /// <summary>
        /// Préparation de la viande
        /// </summary>
        void PreparerViande();

        /// <summary>
        /// Préparation des légumes
        /// </summary>
        void PreparerLegumes();

        /// <summary>
        /// Préparation de la sauce
        /// </summary>
        void PreparerSauce();

        /// <summary>
        /// Obtention du nom du cuisiner
        /// </summary>
        string ObtenirNom();

        /// <summary>
        /// Obtention du plat une fois terminé
        /// </summary>
        void ObtenirPlatComplet();
    }
}
