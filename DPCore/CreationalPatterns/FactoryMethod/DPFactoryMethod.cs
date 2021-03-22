using DesignPatternApp;

namespace DPCore.FactoryMethod
{
    /// <summary>
    /// Implémentation du design pattern "Factory Method"
    /// </summary>
    public class DPFactoryMethod : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        public override void Execute()
        {
            // Création d'une moto
            IVehicule moto = new MotoFactory(this._logger).ConstruireVehicule();
            this._logger.Log(string.Format("Le véhicule construit est un {0}", moto.ObtenirNomVehicule()));

            // Création d'un bateau
            IVehicule bateau = new BateauFactory(this._logger).ConstruireVehicule();
            this._logger.Log(string.Format("Le véhicule construit est un {0}", bateau.ObtenirNomVehicule()));
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPFactoryMethod(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
