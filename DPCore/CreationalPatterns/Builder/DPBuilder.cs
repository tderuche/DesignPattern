using DesignPatternApp;

namespace DPCore.Builder
{
    /// <summary>
    /// Implémentation du design pattern "Builder"
    /// </summary>
    public class DPBuilder : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        public override void Execute()
        {
            // Création du Chef
            ChefCuisinier chefCuisinier = new ChefCuisinier(this._logger);

            // Créations des cuisiniers
            CuisinierFrancais cuisinierFrancais = new CuisinierFrancais(this._logger);
            CuisinierItalien cuisinierItalien = new CuisinierItalien(this._logger);

            // Plat demandé par le chef cuisinier au cuisinier français
            chefCuisinier.ChangerCuisinier(cuisinierFrancais);
            chefCuisinier.DemanderPlatPrincipal();

            //Plat demandé par le chef cuisinier au cuisinier italien
            chefCuisinier.ChangerCuisinier(cuisinierItalien);
            chefCuisinier.DemanderPlatPrincipal();
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPBuilder(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
