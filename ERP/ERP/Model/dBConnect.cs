using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Renci.SshNet.Messages;

namespace ERP.Model
{
    class dBConnect
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        
        public dBConnect()
        {

            Initialize();
        }

       
        public void Initialize()
        {
            server = "localhost";
            database = "erp";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            
        }

        public bool OpenConnection()
        {

            try
            {
                connection.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Connexion impossible");

                        break;
                    case 1045:
                        Console.WriteLine("Mauvais identifiant");

                        break;
                }
            }

            return false;
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public void insert(string table, string[] nomLigne, string[] values)
        {
            string query = "INSERT INTO " + table + "(" + string.Join(",", nomLigne) + ") VALUES ('" + string.Join("','", values) + "')";
            Console.WriteLine(query);
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            else
            {

            }
        }
        public List<string>[] Select(string attributes,string table,string condition,string[] lignes)
        {
            string query = "SELECT "+attributes+" FROM "+table+" WHERE " +condition;
            List<string>[] info = new List<string>[lignes.Length];
            //info[0] = new List<string>();
            for(int i=0; i<lignes.Length; i++)
            {
                info[i] = new List<string>();
            }

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < lignes.Length; i++)
                    {
                        info[i].Add(dataReader[lignes[i]] + "");
                    }
                   // info[0].Add(dataReader["Soc_id"] + "");
                }

                dataReader.Close();
                this.CloseConnection();

                return info;

            }
            else
            {

                return info;
            }
        }
        public void update(string nomTable, string colonne, string value, string condition)
        {
            string query = "UPDATE " + nomTable + " SET " + colonne + " = '" + value + "' WHERE " + condition;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }
            else
            {

            }
        }
        public void delete(string table, string condition)
        {
            string query = "DELETE FROM " + table + " WHERE " + condition;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            else
            {

            }
        }
    }
}

