using DesignPatternApp;

namespace DPCore.BehavioralPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Implémentation du design pattern "Chain Of Responsibility"
    /// </summary>
    public class DPChainOfResponsibility : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public void Execute(IDpAppLogger logger)
        {
            // Création de la chaine de responsabilité
            ConseillerSL conseillerSL = new ConseillerSL();
            DeveloppeurCompta developpeurCompta = new DeveloppeurCompta();
            DeveloppeurOutils developpeurOutils = new DeveloppeurOutils();
            conseillerSL.SetNext(developpeurCompta);
            developpeurCompta.SetNext(developpeurOutils);

            // Traitements des maintenances
            conseillerSL.TraiterMaintenance(new Maintenance() { Probleme = "Comment saisir une écriture ?" }, logger);
            conseillerSL.TraiterMaintenance(new Maintenance() { Probleme = "Erreur violation PK" }, logger);
            conseillerSL.TraiterMaintenance(new Maintenance() { Probleme = "Erreur mise à jour updater" }, logger);
            developpeurCompta.TraiterMaintenance(new Maintenance() { Probleme = "Comment saisir une écriture ?" }, logger);
            developpeurOutils.TraiterMaintenance(new Maintenance() { Probleme = "Erreur violation PK" }, logger);
        }
    }
}
