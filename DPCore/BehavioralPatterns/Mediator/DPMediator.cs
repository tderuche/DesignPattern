using DesignPatternApp;

namespace DPCore.BehavioralPatterns.Mediator
{
    /// <summary>
    /// Implémentation du design pattern "Mediator"
    /// </summary>
    public class DPMediator : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public void Execute(IDpAppLogger logger)
        {
            // Création du mediateur Twitter
            InstagramTwitterMediator mediator = new InstagramTwitterMediator(logger);

            // Création des utilisateurs
            TwitterUser thomas = new TwitterUser(mediator, "Thomas", logger);
            InstagramUser elodie = new InstagramUser(mediator, "Elodie", logger);

            // Affectation des users au médiateur
            mediator.TwitterUser = thomas;
            mediator.InstagramUser = elodie;

            // Envois des messages
            thomas.Send("Salut Elodie !");
            elodie.Send("Salut Thomas !");
        }
    }
}
