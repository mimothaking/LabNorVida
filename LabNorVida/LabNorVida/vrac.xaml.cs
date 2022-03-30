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
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `echantillon`(`referance `, `dateEssai`, `classeGra`,`typeConteneur `,`vrac `,`porosite `,`cBalance `,`cConteneur `,`cThermo `,`cEtuve ` ) VALUES (@ref, @date, @classe, @type, @cbalance, @cconteneur, @cthermo, @cetuve)", db.GetConnection());

            command.Parameters.Add("@ref", MySqlDbType.Int32).Value = referance.Text ;
            command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dateEchantillon.Text;
            command.Parameters.Add("@classe", MySqlDbType.Float).Value = classGra.Text;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = typeConteneur.Text;
            command.Parameters.Add("@cbalance", MySqlDbType.VarChar).Value = balance.Text;
            command.Parameters.Add("@cconteneur", MySqlDbType.VarChar).Value = conteneur.Text;
            command.Parameters.Add("@cthermo", MySqlDbType.VarChar).Value = thermo.Text;
            command.Parameters.Add("@cetuve", MySqlDbType.VarChar).Value = etuve.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);


            //open Connection
            db.openConnection();

            
                //execute query
                if (command.ExecuteNonQuery() == 1)
                {
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
