namespace DPCore.StructuralPatterns.Decorator
{
    /// <summary>
    /// Description d'une personne
    /// </summary>
    public class Personne : IPersonne
    {
        /// <summary>
        /// Retourne la description de la personne
        /// </summary>
        /// <returns>Description de la personne</returns>
        public string Description()
        {
            return "Je suis une personne";
        }
    }
}
