using DesignPatternApp;

namespace DPCore.BehavioralPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Conseiller SL pour la gestion des maintenances
    /// </summary>
    public class ConseillerSL : MaintenanceManagerBase
    {
        /// <summary>
        /// Traitement d'une maintenance par un conseiller SL
        /// </summary>
        /// <param name="maintenance">Maintenance à traiter</param>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <returns>Est-ce que la maintenance a été traitée</returns>
        public override bool TraiterMaintenance(Maintenance maintenance, IDpAppLogger logger)
        {
            if (string.Equals(maintenance.Probleme, "Comment saisir une écriture ?"))
            {
                logger.Log(string.Format("Conseiller SL : je peux traiter la maintenance [{0}].", maintenance.Probleme));
                return true;
            }
            logger.Log(string.Format("Conseiller SL : je ne peux pas traiter la maintenance [{0}].", maintenance.Probleme));
            return base.TraiterMaintenance(maintenance, logger);
        }
    }
}
