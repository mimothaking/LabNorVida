using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace LabNorVida
{
   
    public partial class MainWindow : Window
    {

        



        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();

            String username = Username.Text;
            String password = Password.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `technicien` WHERE `Username` = @Username AND `Password` = @Password", db.GetConnection());

            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);


            //Checking if the user exists or not !
            if (table.Rows.Count > 0)
            {
                this.Hide();
                vrac vracpage = new vrac();
                vracpage.Show();    
            }
            else
            {
                LoginERROR le = new LoginERROR();
                le.Show();
            }

        }

        private void Password_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Username_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Username_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            String uname = Username.Text;
            if (uname.Equals("Username"))
            {
                Username.Text = "";
            }
        }

        private void Password_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            String pswd = Password.Text;
            if (pswd.Equals("Password"))
            {
                Password.Text = "";
            }
        }



        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RegisterButton_Click_1(object sender, RoutedEventArgs e)
        {
            //Adding a new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `technicien`(`Fullname`, `Username`, `Password`) VALUES (@Fullname, @usn, @pass)", db.GetConnection());

            command.Parameters.Add("@Fullname", MySqlDbType.VarChar).Value = Fullname.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = UsernameR.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordR.Text;

            //open Connection
            db.openConnection();

            if(checkUsername())
            {
                UserAlreadyUsed uae = new UserAlreadyUsed();
                uae.Show();
            }
            else
            {
                 //execute query
                  if (command.ExecuteNonQuery() == 1)
                   {
                    AccountCreated ac = new AccountCreated();
                    ac.Show();
                   }
                  else
                  {
                      MessageBox.Show("Error!");
                  }
            }

            //close conn
            db.closeConnection();


        }

        //Checking if username already exists
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = UsernameR.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `technicien` WHERE `Username` = @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;


            adapter.SelectCommand = command;

            adapter.Fill(table);


            //Checking if this user already exists or not !
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }


}
            
          
    

