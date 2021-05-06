using DesignPatternApp;

namespace DPCore.BehavioralPatterns.Mediator
{
    /// <summary>
    /// Utilisateur de Twitter
    /// </summary>
    public class TwitterUser : User
    {
        /// <summary>
        /// Constructeur d'un utilisateur de Twitter
        /// </summary>
        /// <param name="mediator">Médiateur à utiliser</param>
        /// <param name="name">Nom de l'utilisateur</param>
        /// <param name="logger">Gestionnaire de logs</param>
        public TwitterUser(InstagramTwitterMediator mediator, string name, IDpAppLogger logger) : base(mediator, name, logger) { }

        /// <summary>
        /// Envoi d'un message sur Twitter
        /// </summary>
        /// <param name="message">Message envoyé</param>
        public override void Send(string message)
        {
            this._logger.Log(this._name + ": Message envoyé depuis Twitter : " + message);
            this._mediator.SendMessage(message, this);
        }

        /// <summary>
        /// Réception d'un message sur Twitter
        /// </summary>
        /// <param name="message">Message envoyé</param>
        public override void Notify(string message)
        {
            this._logger.Log(this._name + ": Message reçu sur Twitter: " + message);
        }
    }
}
