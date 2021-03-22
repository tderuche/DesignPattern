namespace DPCore.AbstractFactory
{
    /// <summary>
    /// Citadine Peugeot 208
    /// </summary>
    class Peugeot208 : ICitadine
    {
        /// <summary>
        /// Obtention du prix de la voiture
        /// </summary>
        /// <returns>Prix de la voiture</returns>
        public string ObtenirPrix()
        {
            return "12k€";
        }

        /// <summary>
        /// Obtention du nom de la voiture
        /// </summary>
        /// <returns>Nom de la voiture</returns>
        public string ObtenirNomVoiture()
        {
            return "Peugeot 208";
        }
    }
}
