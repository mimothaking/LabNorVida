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
    
    public partial class Printform : Window
    {
        public Printform()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            reference.Content = Globals.referance;
            reference_Copy.Content = Globals.referance;
            Date.Content = Globals.dateEssai;
            ClassGra.Content = Globals.classGra;
            TypeConteneur.Content = Globals.typeConteneur;
            mcv1.Content = Globals.mcv1;
            mcv2.Content = Globals.mcv2;
            mcv3.Content = Globals.mcv3;
            mce1.Content = Globals.mce1;
            mce2.Content = Globals.mce2;
            mce3.Content = Globals.mce3;
            me1.Content = Globals.me1;
            me2.Content = Globals.me2;
            me3.Content = Globals.me3;
            vc1.Content = Globals.vc1;
            vc2.Content = Globals.vc2;
            vc3.Content = Globals.vc3;
            vrac1.Content = Globals.vrac1;
            vrac2.Content = Globals.vrac2;
            vrac3.Content = Globals.vrac3;
            mvrac.Content = Globals.mVrac;
            mvrac1.Content = Globals.mVrac;
            mvrac2.Content = Globals.mVrac;
            mvrac3.Content = Globals.mVrac;
            mvr1.Content = Globals.mvreelle1;
            mvr2.Content = Globals.mvreelle2;
            mvr3.Content = Globals.mvreelle3;
            poro1.Content = Globals.pi1;
            poro2.Content = Globals.pi2;
            poro3.Content = Globals.pi3;
            mporo.Content = Globals.mporosite;
            cBalance.Content = Globals.cBalance;
            cConteneur.Content = Globals.cConteneur;
            cThermo.Content = Globals.cThermo;
            cEtuve.Content = Globals.cEtuve;




        }
    }
}
