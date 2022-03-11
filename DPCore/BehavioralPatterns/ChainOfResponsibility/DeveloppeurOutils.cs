using DesignPatternApp;

namespace DPCore.BehavioralPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Développeur outils pour la gestion des maintenances
    /// </summary>
    public class DeveloppeurOutils : MaintenanceManagerBase
    {
        /// <summary>
        /// Traitement d'une maintenance par un développeur outils
        /// </summary>
        /// <param name="maintenance">Maintenance à traiter</param>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <returns>Est-ce que la maintenance a été traitée</returns>
        public override bool TraiterMaintenance(Maintenance maintenance, IDpAppLogger logger)
        {
            if (string.Equals(maintenance.Probleme, "Erreur mise à jour updater"))
            {
                logger.Log(string.Format("Développeur Outils : je peux traiter la maintenance [{0}].", maintenance.Probleme));
                return true;
            }
            logger.Log(string.Format("Développeur Outils : je ne peux pas traiter la maintenance [{0}].", maintenance.Probleme));
            return base.TraiterMaintenance(maintenance, logger);
        }
    }
}
