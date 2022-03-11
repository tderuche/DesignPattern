using DesignPatternApp;

namespace DPCore.StructuralPatterns.Decorator
{
    /// <summary>
    /// Implémentation du design pattern "Decorator"
    /// </summary>
    public class DPDecorator : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public void Execute(IDpAppLogger logger)
        {
            // Création de la personne
            Personne personne = new Personne();

            // Décoration de la même personne
            PersonneAvecLunettes personneAvecLunettes = new PersonneAvecLunettes(personne);
            PersonneAvecChapeau personneAvecChapeau = new PersonneAvecChapeau(personne);
            PersonneAvecChapeau personneAvecChapeauEtLunettes = new PersonneAvecChapeau(personneAvecLunettes);

            logger.Log(personneAvecLunettes.Description());
            logger.Log(personneAvecChapeau.Description());
            logger.Log(personneAvecChapeauEtLunettes.Description());
            logger.Log(personne.Description());
        }
    }
}
