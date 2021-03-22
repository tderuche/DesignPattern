namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Représente une moto Ducati Superleggera V4 
    /// </summary>
    public class DucatiSuperleggeraV4 : IVehicule
    {
        /// <summary>
        /// Retourne le nom du véhicule
        /// </summary>
        /// <returns>Nom du véhicule</returns>
        public string ObtenirNomVehicule()
        {
            return "Ducati Superleggera V4";
        }
    }
}
