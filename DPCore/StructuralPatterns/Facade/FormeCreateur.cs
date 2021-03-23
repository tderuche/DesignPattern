using System;
using DesignPatternApp;

namespace DPCore.StructuralPatterns.Facade
{
    /// <summary>
    /// Facade permettant de dessiner des formes
    /// </summary>
    public class FormeCreateur
    {
        private readonly IForme _cercle;
        private readonly IForme _rectangle;

        private readonly IDpAppLogger _logger;

        /// <summary>
        /// Initialisation des formes
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public FormeCreateur(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            this._cercle = new Cercle();
            this._rectangle = new Rectangle();
        }

        /// <summary>
        /// Dessine un cercle
        /// </summary>
        /// <returns>Le cercle dessiné</returns>
        public void DessinerCercle()
        {
            this._logger.Log(this._cercle.Dessiner());
        }

        /// <summary>
        /// Dessine un rectangle
        /// </summary>
        /// <returns>Le rectangle dessiné</returns>
        public void DessinerRectangle()
        {
            this._logger.Log(this._rectangle.Dessiner());
        }
    }
}
