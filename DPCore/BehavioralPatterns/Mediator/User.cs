using System;
using DesignPatternApp;

namespace DPCore.BehavioralPatterns.Mediator
{
    /// <summary>
    /// Utilisateur de base d'un réseau social
    /// </summary>
    public abstract class User
    {
        protected IReseauSocialMediator _mediator;
        protected IDpAppLogger _logger;
        protected string _name;

        /// <summary>
        /// Constructeur d'un utilisateur d'un réseau social
        /// </summary>
        /// <param name="mediator">Reseau social à utiliser</param>
        /// <param name="name">Nom de l'utilisateur</param>
        /// <param name="logger">Gestionnaire de logs</param>
        public User(IReseauSocialMediator mediator, string name, IDpAppLogger logger)
        {
            this._name = name;
            this._mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Retourne le nom de l'utilisateur courant
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this._name;
        }

        /// <summary>
        /// Envoi d'un message sur le réseau social
        /// </summary>
        /// <param name="message">Message envoyé</param>
        public abstract void Send(string message);

        /// <summary>
        /// Réception d'un message sur le réseau social
        /// </summary>
        /// <param name="message">Message envoyé</param>
        public abstract void Notify(string message);
    }
}
