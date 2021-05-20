using System;
using System.Collections.Generic;
using DesignPatternApp;

namespace DPCore.StructuralPatterns.Composite
{
    /// <summary>
    /// Implémentation d'un ISalarie en tant que Manager
    /// Il possède une List<ISalarie>
    /// </summary>
    public class Manager : ISalarie
    {
        private readonly List<ISalarie> _manages = new List<ISalarie>();
        private readonly IDpAppLogger _logger;
        private readonly string _nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <param name="nom">Nom du manager</param>
        public Manager(IDpAppLogger logger, string nom)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this._nom = nom;
        }

        /// <summary>
        /// Affiche les infos du manager et de ses managés
        /// </summary>
        public void Afficher()
        {
            this._logger.Log(string.Format("Je suis le manager {0} et je manage les personnes suivantes:", this._nom));
            foreach (ISalarie item in this._manages)
            {
                item.Afficher();
            }
        }

        /// <summary>
        /// Ajoute un managé au manager
        /// </summary>
        /// <param name="salarie"></param>
        public void AjouterSalarie(ISalarie salarie)
        {
            this._manages.Add(salarie);
        }
    }
}
