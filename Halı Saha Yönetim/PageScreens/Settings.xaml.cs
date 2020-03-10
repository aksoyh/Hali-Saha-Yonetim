using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Halı_Saha_Yönetim.PageScreens
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void HaliSaha_Click(object sender, RoutedEventArgs e)
        {
            if(txtPrice.Text == null || txtPrice.Text == "")
            {
                MessageBox.Show("Fiyat giriniz!");
            }
        }

        private void BtnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            if(txtHaliSahaName.Text == null || txtHaliSahaName.Text == "")
            {
                settings_warning.Visibility = Visibility.Visible;
            }
            if(cmbSaha.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce saha seçiniz!");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
