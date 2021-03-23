using DesignPatternApp;

namespace DPCore
{
    /// <summary>
    /// Interface pour les implémentations des design Patterns
    /// </summary>
    public interface IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        void Execute(IDpAppLogger logger);
    }
}
