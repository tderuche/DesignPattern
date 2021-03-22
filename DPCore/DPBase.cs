using System;
using DesignPatternApp;

namespace DPCore
{
    /// <summary>
    /// Interface pour les implémentations des design Patterns
    /// </summary>
    public abstract class DPBase : IDPBase
    {
        protected readonly IDpAppLogger _logger;

        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Log des traitements</param>
        public abstract void Execute();

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        protected DPBase(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
