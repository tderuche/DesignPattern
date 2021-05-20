using DesignPatternApp;

namespace DPCore.StructuralPatterns.Composite
{
    /// <summary>
    /// Implémentation du design pattern "Composite"
    /// </summary>
    public class DPComposite : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public void Execute(IDpAppLogger logger)
        {
            // Création des managers
            Manager chefProduction = new Manager(logger, "Richard Harquin");
            Manager chefDev = new Manager(logger, "Aubrey Bonnet");
            Manager chefTests = new Manager(logger, "Orson Sarrazin");
            chefProduction.AjouterSalarie(chefDev);
            chefProduction.AjouterSalarie(chefTests);

            // Création des non managers
            Developpeur dev1 = new Developpeur(logger, "Ferragus Allaire");
            Developpeur dev2 = new Developpeur(logger, "Oriel Beaulieu");
            chefDev.AjouterSalarie(dev1);
            chefDev.AjouterSalarie(dev2);

            Testeur testeur1 = new Testeur(logger, "Clovis Parrot");
            Testeur testeur2 = new Testeur(logger, "Solaine Meunier");
            chefTests.AjouterSalarie(testeur1);
            chefTests.AjouterSalarie(testeur2);

            // Affiche les salariés à partir du chef de production
            chefProduction.Afficher();
        }
    }
}
