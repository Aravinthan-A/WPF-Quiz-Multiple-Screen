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
using System.Windows.Shapes;

namespace PageScreen.Main
{
    /// <summary>
    /// Interaction logic for Language.xaml
    /// </summary>
    public partial class Language : Window
    {
        Cprogram ocprogram;
        Java ojava;
        Html ohtml;
        Csharp ocsharp;
        public Language()
        {
            InitializeComponent();
            ocprogram = new Cprogram();
            ojava = new Java();
            ohtml = new Html();
            ocsharp= new Csharp();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmname.Content = ocprogram;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frmname.Content = ojava;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmname.Content = ohtml;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frmname.Content = ocsharp;
        }
    }
}
