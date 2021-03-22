using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

namespace DesignPatternApp.Model
{
    /// <summary>
    /// Model pour afficher le diagramme EA d'un Design Pattern
    /// </summary>
    public class DiagrammeEAModel : INotifyPropertyChanged
    {
        #region Implémentation INotifyPropertyChanged

        /// <summary>
        /// Survient quand une valeur change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Survient quand une valeur change
        /// </summary>
        /// <param name="str">Nom de la propriété ayant changé</param>
        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        #endregion

        #region NomDesignPattern

        private string _nomDesignPattern;
        public string NomDesignPattern
        {
            get { return _nomDesignPattern; }
            set
            {
                if (!string.Equals(_nomDesignPattern, value))
                {
                    _nomDesignPattern = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region ImageEA

        private BitmapImage _imageEA;
        public BitmapImage ImageEA
        {
            get { return _imageEA; }
            set
            {
                if (_imageEA != value)
                {
                    _imageEA = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion
    }
}
