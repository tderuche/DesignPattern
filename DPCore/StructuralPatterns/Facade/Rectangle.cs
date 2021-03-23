namespace DPCore.StructuralPatterns.Facade
{
    /// <summary>
    /// Représentation d'un rectangle
    /// </summary>
    public class Rectangle : IForme
    {
        /// <summary>
        /// Dessine un rectangle
        /// </summary>
        /// <returns>Le rectangle dessiné</returns>
        public string Dessiner()
        {
            return "Rectangle dessiné.";
        }
    }
}
