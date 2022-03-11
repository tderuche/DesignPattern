using DesignPatternApp;

namespace DPCore.BehavioralPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Interface pour la chaine de responsabilité de traitements des maintenances
    /// </summary>
    public interface IMaintenanceManager
    {
        /// <summary>
        /// Affectation d'un gestionnaire de maintenance si le courant ne peut pas la traiter
        /// </summary>
        /// <param name="maintenanceManager">Gestionnaire de maintenance suivant</param>
        void SetNext(IMaintenanceManager maintenanceManager);

        /// <summary>
        /// Traitement d'une maintenance par un conseiller SL
        /// </summary>
        /// <param name="maintenance">Maintenance à traiter</param>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <returns>Est-ce que la maintenance a été traitée</returns>
        bool TraiterMaintenance(Maintenance maintenance, IDpAppLogger logger);
    }
}
