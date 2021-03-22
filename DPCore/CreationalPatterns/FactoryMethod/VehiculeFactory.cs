using System;
using DesignPatternApp;

namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Class abstraite de création d'un véhicule
    /// </summary>
    public abstract class VehiculeFactory
    {
        protected readonly IDpAppLogger _logger;

        /// <summary>
        /// Méthode interne de construction
        /// </summary>
        /// <returns>Le véhicule construit</returns>
        protected abstract IVehicule InternalConstruire();

        /// <summary>
        /// Méthode publique pour construire un véhicule
        /// </summary>
        /// <returns></returns>
        public IVehicule ConstruireVehicule()
        {
            return this.InternalConstruire();
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        protected VehiculeFactory(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
