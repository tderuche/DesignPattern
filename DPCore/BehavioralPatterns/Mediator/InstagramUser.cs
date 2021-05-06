using DesignPatternApp;

namespace DPCore.BehavioralPatterns.Mediator
{
    /// <summary>
    /// Utilisateur de Instagram
    /// </summary>
    public class InstagramUser : User
    {
        /// <summary>
        /// Constructeur d'un utilisateur de Instagram
        /// </summary>
        /// <param name="mediator">Médiateur à utiliser</param>
        /// <param name="name">Nom de l'utilisateur</param>
        /// <param name="logger">Gestionnaire de logs</param>
        public InstagramUser(InstagramTwitterMediator mediator, string name, IDpAppLogger logger) : base(mediator, name, logger) { }

        /// <summary>
        /// Envoi d'un message sur Instagram
        /// </summary>
        /// <param name="message">Message envoyé</param>
        public override void Send(string message)
        {
            this._logger.Log(this._name + ": Message envoyé depuis Instagram : " + message);
            this._mediator.SendMessage(message, this);
        }

        /// <summary>
        /// Réception d'un message sur Instagram
        /// </summary>
        /// <param name="message">Message envoyé</param>
        public override void Notify(string message)
        {
            this._logger.Log(this._name + ": Message reçu sur Instagram: " + message);
        }
    }
}
