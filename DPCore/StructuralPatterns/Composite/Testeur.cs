﻿using System;
using DesignPatternApp;

namespace DPCore.StructuralPatterns.Composite
{
    /// <summary>
    /// Implémentation d'un ISalarie en tant que testeur
    /// </summary>
    public class Testeur : ISalarie
    {
        private readonly IDpAppLogger _logger;
        private readonly string _nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        /// <param name="nom">Nom du testeur</param>
        public Testeur(IDpAppLogger logger, string nom)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this._nom = nom;
        }

        /// <summary>
        /// Affiche les infos du testeur
        /// </summary>
        public void Afficher()
        {
            this._logger.Log(string.Format("Je suis le testeur {0}.", this._nom));
        }
    }
}
