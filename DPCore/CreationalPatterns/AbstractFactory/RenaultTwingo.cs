namespace DPCore.AbstractFactory
{
    /// <summary>
    /// Citadine Renault Twingo
    /// </summary>
    public class RenaultTwingo : ICitadine
    {
        /// <summary>
        /// Obtention du prix de la voiture
        /// </summary>
        /// <returns>Prix de la voiture</returns>
        public string ObtenirPrix()
        {
            return "1k€";
        }

        /// <summary>
        /// Obtention du nom de la voiture
        /// </summary>
        /// <returns>Nom de la voiture</returns>
        public string ObtenirNomVoiture()
        {
            return "Renault Twingo";
        }
    }
}
