namespace DPCore.StructuralPatterns.Facade
{
    /// <summary>
    /// Représentation d'un cercle
    /// </summary>
    public class Cercle : IForme
    {
        /// <summary>
        /// Dessine un cercle
        /// </summary>
        /// <returns>Le cercle dessiné</returns>
        public string Dessiner()
        {
            return "Cercle dessiné.";
        }
    }
}
