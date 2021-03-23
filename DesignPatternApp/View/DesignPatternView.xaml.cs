using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace DesignPatternApp.View
{
    /// <summary>
    /// Interaction logic for DesignPatternView.xaml
    /// </summary>
    public partial class DesignPatternView : Window
    {
        /// <summary>
        /// Création de la View
        /// </summary>
        public DesignPatternView()
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
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Ouverture d'un lien HTTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // for .NET Core you need to add UseShellExecute = true
            // see https://docs.microsoft.com/dotnet/api/system.diagnostics.processstartinfo.useshellexecute#property-value
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
