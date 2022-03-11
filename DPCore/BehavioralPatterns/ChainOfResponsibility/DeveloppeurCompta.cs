using DesignPatternApp;

namespace DPCore.BehavioralPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Développeur compta pour la gestion des maintenances
    /// </summary>
    public class DeveloppeurCompta : MaintenanceManagerBase
    {
        /// <summary>
        /// Traitement d'une maintenance par un développeur compta
        /// </summary>
        /// <param name="maintenance">Maintenance à traiter</param>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <returns>Est-ce que la maintenance a été traitée</returns>
        public override bool TraiterMaintenance(Maintenance maintenance, IDpAppLogger logger)
        {
            if (string.Equals(maintenance.Probleme, "Erreur violation PK"))
            {
                logger.Log(string.Format("Développeur Compta : je peux traiter la maintenance [{0}].", maintenance.Probleme));
                return true;
            }
            logger.Log(string.Format("Développeur Compta : je ne peux pas traiter la maintenance [{0}].", maintenance.Probleme));
            return base.TraiterMaintenance(maintenance, logger);
        }
    }
}
