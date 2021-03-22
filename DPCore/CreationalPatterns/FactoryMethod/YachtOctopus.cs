namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Représente un yacht Octopus
    /// </summary>
    public class YachtOctopus : IVehicule
    {
        /// <summary>
        /// Retourne le nom du véhicule
        /// </summary>
        /// <returns>Nom du véhicule</returns>
        public string ObtenirNomVehicule()
        {
            return "Yacht OCTOPUS";
        }
    }
}
