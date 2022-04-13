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

namespace LabNorVida
{
    
    public partial class Validation : Window
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            //Replacing labels (vrac) with values !
            mvrac1.Content = Globals.vrac1;
            mvrac2.Content = Globals.vrac2;
            mvrac3.Content = Globals.vrac3;
            moyennevrac.Content = Globals.mVrac;

            //Replacing labels (porosité) with values !
            poro1.Content = Globals.pi1;
            poro2.Content = Globals.pi2;
            poro3.Content = Globals.pi3;
            moyenneporo.Content = Globals.mporosite;

            //Conditional styling vrac
            if (Globals.mVrac > 10)
            {
                vracBorder.BorderBrush = new SolidColorBrush(Colors.Red);
                vracLabel.Foreground = new SolidColorBrush(Colors.Red);
                vracPath1.Stroke = new SolidColorBrush(Colors.Red);
                vracPath2.Stroke = new SolidColorBrush(Colors.Red);
                vracPath3.Stroke = new SolidColorBrush(Colors.Red);
                vracPath4.Stroke = new SolidColorBrush(Colors.Red);

            }

            //Conditional styling poro
            if (Globals.mporosite > 10)
            {
                poroBorder.BorderBrush = new SolidColorBrush(Colors.Red);
                poroLabel.Foreground = new SolidColorBrush(Colors.Red);
                poroPath1.Stroke = new SolidColorBrush(Colors.Red);
                poroPath2.Stroke = new SolidColorBrush(Colors.Red);
                poroPath3.Stroke = new SolidColorBrush(Colors.Red);
                poroPath4.Stroke = new SolidColorBrush(Colors.Red);
            }


        }
        private void imp_button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_ter_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Printform pf = new Printform();
            pf.Show();
        }
    }
}
