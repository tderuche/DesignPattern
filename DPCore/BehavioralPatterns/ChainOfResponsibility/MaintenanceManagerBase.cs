using DesignPatternApp;

namespace DPCore.BehavioralPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Classe de base de gestionnaire de maintenance
    /// </summary>
    public abstract class MaintenanceManagerBase : IMaintenanceManager
    {
        /// <summary>
        /// Gestionnaire de maintenance suivant
        /// </summary>
        IMaintenanceManager _maintenanceManagerSuivant;

        /// <summary>
        /// Affectation d'un gestionnaire de maintenance si le courant ne peut pas la traiter
        /// </summary>
        /// <param name="maintenanceManager">Gestionnaire de maintenance suivant</param>
        public void SetNext(IMaintenanceManager maintenanceManager)
        {
            this._maintenanceManagerSuivant = maintenanceManager;
        }

        /// <summary>
        /// Traitement d'une maintenance par un conseiller SL
        /// </summary>
        /// <param name="maintenance">Maintenance à traiter</param>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <returns>Est-ce que la maintenance a été traitée</returns>
        public virtual bool TraiterMaintenance(Maintenance maintenance, IDpAppLogger logger)
        {
            if (this._maintenanceManagerSuivant != null)
            {
                return this._maintenanceManagerSuivant.TraiterMaintenance(maintenance, logger);
            }
            else
            {
                logger.Log(string.Format("La maintenance [{0}] n'a pas pu être traitée.", maintenance.Probleme));
                return false;
            }
        }
    }
}
