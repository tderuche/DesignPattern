using System;
using DesignPatternApp;

namespace DPCore.BehavioralPatterns.Mediator
{
    /// <summary>
    /// Médiateur entre un utilisateur Instagram et Twitter
    /// </summary>
    public class InstagramTwitterMediator : IReseauSocialMediator
    {
        private InstagramUser _instagramUser;
        private TwitterUser _twitterUser;
        protected IDpAppLogger _logger;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public InstagramTwitterMediator(IDpAppLogger logger)
        {
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Utilisateur Instagram
        /// </summary>
        public InstagramUser InstagramUser
        {
            set { this._instagramUser = value; }
        }

        /// <summary>
        /// Utilisateur Twitter
        /// </summary>
        public TwitterUser TwitterUser
        {
            set { this._twitterUser = value; }
        }

        /// <summary>
        /// Envoi d'un message sur Twitter
        /// </summary>
        /// <param name="message">Message envoyé</param>
        /// <param name="user">Utilisateur ayant envoyé le message</param>
        public void SendMessage(string message, User user)
        {
            if (user == this._instagramUser)
            {
                this._twitterUser.Notify(message);
            }
            else
            {
                this._instagramUser.Notify(message);
            }
        }
    }
}
