namespace DPCore.StructuralPatterns.Decorator
{
    /// <summary>
    /// Decoration d'une personne en lui mettant des lunettes
    /// </summary>
    public class PersonneAvecChapeau : PersonneDecorator
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="personne">Personne dont il faut ajouter des lunettes</param>
        public PersonneAvecChapeau(IPersonne personne) : base(personne) { }

        /// <summary>
        /// Retourne la description de la personne
        /// </summary>
        /// <returns>Description de la personne</returns>
        public override string Description()
        {
            return this._personne.Description() + " et je porte un chapeau";
        }
    }
}
