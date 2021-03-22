using System;
using DesignPatternApp;

namespace DPCore.Builder
{
    /// <summary>
    /// Chef cuisinier
    /// </summary>
    class ChefCuisinier
    {
        private readonly IDpAppLogger _logger;

        /// <summary>
        /// Cuisinier avec lequel il travaille
        /// </summary>
        private ICuisinier _cuisinier;

        /// <summary>
        /// Demande de préparation d'un plat à un cuisinier
        /// </summary>
        public void DemanderPlatPrincipal()
        {
            // Demande au cuisinier de prépaper les aliments
            this._logger.Log(string.Format("Le chef cuisinier demande de préparer un plat au {0}:", this._cuisinier.ObtenirNom()));
            this._cuisinier.PreparerLegumes();
            this._cuisinier.PreparerViande();
            this._cuisinier.PreparerSauce();
            this._cuisinier.ObtenirPlatComplet();
        }

        /// <summary>
        /// Changement de cuisinier
        /// </summary>
        /// <param name="cuisinier"></param>
        public void ChangerCuisinier(ICuisinier cuisinier)
        {
            // garde son cuisinier
            this._cuisinier = cuisinier ?? throw new ArgumentNullException(nameof(cuisinier));
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public ChefCuisinier(IDpAppLogger logger)
        {
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
