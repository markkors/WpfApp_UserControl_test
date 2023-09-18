using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_UserControl_test
{
    /// <summary>
    /// Interaction logic for EuroTextbox.xaml
    /// </summary>
    public partial class EuroTextbox : UserControl, INotifyPropertyChanged
        
    {

        private string _euroValue;
        public EuroTextbox()
        {
            InitializeComponent();
            initEvents();
        }

        private void initEvents()
        {
            txtEuro.KeyDown += TxtEuro_KeyDown;
            txtEuro.KeyUp += TxtEuro_KeyUp;
            txtEuro.PreviewKeyDown += TxtEuro_PreviewKeyDown;
        }

        private void TxtEuro_PreviewKeyDown(object sender, KeyEventArgs e)
        {


            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Back))
            {
                // If the key is not a number or backspace, mark the event as handled.
                e.Handled = true;
            }
        }

        private void TxtEuro_KeyUp(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void TxtEuro_KeyDown(object sender, KeyEventArgs e)
        {
           //
        }

        public string EuroValue { 
            get { return _euroValue; }
            set { 
                _euroValue = value;
                OnPropertyChanged("EuroValue");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;



        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
