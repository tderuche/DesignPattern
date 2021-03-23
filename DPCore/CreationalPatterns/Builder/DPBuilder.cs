using DesignPatternApp;

namespace DPCore.Builder
{
    /// <summary>
    /// Implémentation du design pattern "Builder"
    /// </summary>
    public class DPBuilder : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        public void Execute(IDpAppLogger logger)
        {
            // Création du Chef
            ChefCuisinier chefCuisinier = new ChefCuisinier(logger);

            // Créations des cuisiniers
            CuisinierFrancais cuisinierFrancais = new CuisinierFrancais(logger);
            CuisinierItalien cuisinierItalien = new CuisinierItalien(logger);

            // Plat demandé par le chef cuisinier au cuisinier français
            chefCuisinier.ChangerCuisinier(cuisinierFrancais);
            chefCuisinier.DemanderPlatPrincipal();

            //Plat demandé par le chef cuisinier au cuisinier italien
            chefCuisinier.ChangerCuisinier(cuisinierItalien);
            chefCuisinier.DemanderPlatPrincipal();
        }
    }
}
