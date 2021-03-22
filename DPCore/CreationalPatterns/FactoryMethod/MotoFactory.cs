using DesignPatternApp;

namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Factory de création de moto (DucatiSuperleggeraV4)
    /// </summary>
    class MotoFactory : VehiculeFactory
    {
        /// <summary>
        /// Méthode interne de construction d'un DucatiSuperleggeraV4
        /// </summary>
        /// <returns>Le véhicule DucatiSuperleggeraV4</returns>
        protected override IVehicule InternalConstruire()
        {
            this._logger.Log("Construction d'une moto.");
            return new DucatiSuperleggeraV4();
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public MotoFactory(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
