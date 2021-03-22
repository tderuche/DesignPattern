using DPCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

namespace DesignPatternApp.Model
{
    /// <summary>
    /// Model d'un design pattern
    /// </summary>
    public class DesignPatternModel : INotifyPropertyChanged
    {
        #region Description

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.Equals(_description, value))
                {
                    _description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Nom

        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set
            {
                if (!string.Equals(_nom, value))
                {
                    _nom = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region MainArticle

        private string _mainArticle;
        public string MainArticle
        {
            get { return _mainArticle; }
            set
            {
                if (!string.Equals(_mainArticle, value))
                {
                    _mainArticle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region UsageCSharp

        private string _usageCSharp;
        public string UsageCSharp
        {
            get { return _usageCSharp; }
            set
            {
                if (!string.Equals(_usageCSharp, value))
                {
                    _usageCSharp = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region ExempleCSharp

        private string _exempleCSharp;
        public string ExempleCSharp
        {
            get { return _exempleCSharp; }
            set
            {
                if (!string.Equals(_exempleCSharp, value))
                {
                    _exempleCSharp = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Image

        private BitmapImage _image;
        public BitmapImage Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region ImageArchi

        private BitmapImage _imageArchi;
        public BitmapImage ImageArchi
        {
            get { return _imageArchi; }
            set
            {
                if (_imageArchi != value)
                {
                    _imageArchi = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Implementation IDPBase

        private IDPBase _dpImplementation;

        public IDPBase DPImplementation
        {
            get { return _dpImplementation; }
            set
            {
                if (_dpImplementation != value)
                {
                    _dpImplementation = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

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
    }
}
