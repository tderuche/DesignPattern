using DesignPatternApp;

namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Implémentation du design pattern "Factory Method"
    /// </summary>
    public class DPFactoryMethod : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        public void Execute(IDpAppLogger logger)
        {
            // Création d'une moto
            IVehicule moto = new MotoFactory(logger).ConstruireVehicule();
            logger.Log(string.Format("Le véhicule construit est un {0}", moto.ObtenirNomVehicule()));

            // Création d'un bateau
            IVehicule bateau = new BateauFactory(logger).ConstruireVehicule();
            logger.Log(string.Format("Le véhicule construit est un {0}", bateau.ObtenirNomVehicule()));
        }
    }
}
