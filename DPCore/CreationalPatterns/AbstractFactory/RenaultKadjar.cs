namespace DPCore.AbstractFactory
{
    /// <summary>
    /// SUV Renault Kadjar
    /// </summary>
    public class RenaultKadjar : ISUV
    {
        /// <summary>
        /// Obtention du prix de la voiture
        /// </summary>
        /// <returns>Prix de la voiture</returns>
        public string ObtenirPrix()
        {
            return "21k€";
        }

        /// <summary>
        /// Obtention du nom de la voiture
        /// </summary>
        /// <returns>Nom de la voiture</returns>
        public string ObtenirNomVoiture()
        {
            return "Renault Kadjar";
        }
    }
}
