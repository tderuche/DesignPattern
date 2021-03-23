using DesignPatternApp.Model;
using DesignPatternApp.ViewModel;
using System.Windows;

namespace DesignPatternApp.View
{
    /// <summary>
    /// Interaction logic for DiagrammeEAView.xaml
    /// </summary>
    public partial class DiagrammeEAView : Window
    {
        public DiagrammeEAView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fermeture custom de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Affichage du diagramme EA
        /// </summary>
        /// <param name="model"></param>
        public void ShowDiagramme(DiagrammeEAModel model)
        {
            DiagrammeEAViewModel viewModel = new DiagrammeEAViewModel
            {
                Model = model
            };
            this.DataContext = viewModel;

            this.Show();
        }
    }
}
