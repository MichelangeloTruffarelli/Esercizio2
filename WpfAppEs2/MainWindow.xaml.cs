﻿using LibreriaEsercizio2;
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

namespace WpfAppEs2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(TxtNumero.Text);
            if (LibreriaEs2.VerificaIntero(n))
            {
                LblRisultato.Content = "Il numero è intero";
            }
            else
            {
                LblRisultato.Content = "Il numero è decimale";
            }
            if(LibreriaEs2.)
        }
    }
}
