using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNorVida
{

    

    class DB
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=norvida");


        //Function to open connection
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //Function to close connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


        //Function to return the connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
