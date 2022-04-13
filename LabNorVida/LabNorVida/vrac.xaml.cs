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
using MySql.Data.MySqlClient;
using System.Data;

namespace LabNorVida
{
   
    public partial class vrac : Window
    {
        public vrac()
        {
            InitializeComponent();


        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            label.Content = Globals.usrName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Adding a new echantillon
            DB db = new DB();
          

            MySqlCommand command = new MySqlCommand("INSERT INTO `echantillon`(`referance`, `dateEssai`, `classeGra`,`typeConteneur`,`cBalance`,`cConteneur`,`cThermo`,`cEtuve` ) VALUES (@ref, @date, @classe, @type, @cbalance, @cconteneur, @cthermo, @cetuve)", db.GetConnection());

            command.Parameters.Add("@ref", MySqlDbType.Int32).Value = referance.Text ;
            command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dateEchantillon.Text;
            command.Parameters.Add("@classe", MySqlDbType.Float).Value = classGra.Text;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = typeConteneur.Text;
            command.Parameters.Add("@cbalance", MySqlDbType.VarChar).Value = balance.Text;
            command.Parameters.Add("@cconteneur", MySqlDbType.VarChar).Value = conteneur.Text;
            command.Parameters.Add("@cthermo", MySqlDbType.VarChar).Value = thermo.Text;
            command.Parameters.Add("@cetuve", MySqlDbType.VarChar).Value = etuve.Text;




            //open Connection
            db.openConnection();

            
                //execute query
                if (command.ExecuteNonQuery() == 1)
                {

                //Stocking variables ! 
                Globals.mce1 = float.Parse(mce1.Text);
                Globals.mce2 = float.Parse(mce2.Text);
                Globals.mce3 = float.Parse(mce3.Text);
                Globals.mcv1 = float.Parse(mcv1.Text);
                Globals.mcv2 = float.Parse(mcv2.Text);
                Globals.mcv3 = float.Parse(mcv3.Text);
                Globals.me1 = float.Parse(me1.Text);
                Globals.me2 = float.Parse(me2.Text);
                Globals.me3 = float.Parse(me3.Text);
                Globals.vc1 = float.Parse(vc1.Text);
                Globals.vc2 = float.Parse(vc2.Text);
                Globals.vc3 = float.Parse(vc3.Text);
                Globals.mvreelle1 = float.Parse(mvr1.Text);
                Globals.mvreelle2 = float.Parse(mvr2.Text);
                Globals.mvreelle3 = float.Parse(mvr3.Text);
                Globals.referance = int.Parse(referance.Text);
                Globals.dateEssai = DateTime.Parse(dateEchantillon.Text);
                Globals.classGra =float.Parse( classGra.Text);
                Globals.typeConteneur = int.Parse(typeConteneur.Text);
                Globals.cBalance = balance.Text;
                Globals.cConteneur = conteneur.Text;
                Globals.cThermo = thermo.Text;
                Globals.cEtuve = etuve.Text;


                //calling vrac calculation methode !
                Calculations calc = new Calculations();
                calc.CalculerVrac();
                calc.CalculerPorosite();

                //Opening the validation tab
                Validation valid = new Validation();
                       this.Hide();
                      valid.Show();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            

            //close conn
            db.closeConnection();


        }
    }
}
