namespace DPCore.AbstractFactory
{
    /// <summary>
    /// SUV Peugeot 3008
    /// </summary>
    class Peugeot3008 : ISUV
    {
        /// <summary>
        /// Obtention du prix de la voiture
        /// </summary>
        /// <returns>Prix de la voiture</returns>
        public string ObtenirPrix()
        {
            return "22k€";
        }

        /// <summary>
        /// Obtention du nom de la voiture
        /// </summary>
        /// <returns>Nom de la voiture</returns>
        public string ObtenirNomVoiture()
        {
            return "Peugeot 3008";
        }
    }
}
