using DesignPatternApp;

namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Factory de création de bateau (YachtOctopus)
    /// </summary>
    class BateauFactory : VehiculeFactory
    {
        /// <summary>
        /// Méthode interne de construction d'un YachtOctopus
        /// </summary>
        /// <returns>Le véhicule YachtOctopus</returns>
        protected override IVehicule InternalConstruire()
        {
            this._logger.Log("Construction d'un Yacht.");
            return new YachtOctopus();
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public BateauFactory(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
