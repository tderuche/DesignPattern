namespace DPCore.BehavioralPatterns.Mediator
{
    /// <summary>
    /// Description d'un réseau social
    /// </summary>
    public interface IReseauSocialMediator
    {
        /// <summary>
        /// Envoi d'un message sur Twitter
        /// </summary>
        /// <param name="message">Message envoyé</param>
        /// <param name="user">Utilisateur ayant envoyé le message</param>
        void SendMessage(string msg, User user);
    }
}
