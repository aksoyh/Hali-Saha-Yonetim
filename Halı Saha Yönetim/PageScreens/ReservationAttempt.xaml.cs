﻿using System;
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
    /// Interaction logic for ReservationAttempt.xaml
    /// </summary>
    public partial class ReservationAttempt : Page
    {
        public ReservationAttempt()
        {
            InitializeComponent();
        }

        private void BtnSaveResAttempt_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Seçtiğiniz saate rezervasyon dolu!");

            if(cmbSaat.SelectedItem == null || cmbSaha.SelectedItem == null)
            {
                //MessageBox.Show("Tüm alanları eksiksiz giriniz.");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbSaha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
