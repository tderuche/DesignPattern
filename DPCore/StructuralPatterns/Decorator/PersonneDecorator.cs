namespace DPCore.StructuralPatterns.Decorator
{
    /// <summary>
    /// Classe de base pour décorer une personne
    /// </summary>
    public abstract class PersonneDecorator : IPersonne
    {
        /// <summary>
        /// Personne décoré
        /// </summary>
        protected IPersonne _personne;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="personne">Personne dont il faut décorer</param>
        public PersonneDecorator(IPersonne personne)
        {
            this._personne = personne;
        }

        /// <summary>
        /// Retourne la description de la personne
        /// </summary>
        /// <returns>Description de la personne</returns>
        public virtual string Description()
        {
            return string.Empty;
        }
    }
}
