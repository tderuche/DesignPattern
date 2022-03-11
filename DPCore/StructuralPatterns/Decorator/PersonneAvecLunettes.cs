namespace DPCore.StructuralPatterns.Decorator
{
    /// <summary>
    /// Decoration d'une personne en lui mettant un chapeau
    /// </summary>
    public class PersonneAvecLunettes : PersonneDecorator
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="personne">Personne dont il faut ajouter un chapeau</param>
        public PersonneAvecLunettes(IPersonne personne) : base(personne) { }

        /// <summary>
        /// Retourne la description de la personne
        /// </summary>
        /// <returns>Description de la personne</returns>
        public override string Description()
        {
            return this._personne.Description() + " et je porte une paire de lunettes";
        }
    }
}
