using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MySql.Data.MySqlClient;


namespace Test
{
    class dBconnectTest
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        [SetUp]
        public void setup()
        {
            
        }

        
        public  dBconnectTest()
        {
            
            Initialize();
        }

        [Test]
        public void Initialize()
        {
            server = "localhost";
            database = "erp";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            Assert.IsNotNull(connection);
        }
        
        public bool OpenConnection()
        {
           
            try
            {
                connection.Open();
                
                return true;
            }catch(MySqlException ex)
            {
                switch(ex.Number)
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
        
        public List<string>[] Select()
        {
            string query = "SELECT Soc_id,Soc_nom,Soc_mail FROM T_Societe WHERE Soc_nom='Google'";
            List<string>[] info = new List<string>[3];
            info[0] = new List<string>();
            info[1] = new List<string>();
            info[2] = new List<string>();
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    info[0].Add(dataReader["Soc_id"] + "");
                    info[1].Add(dataReader["Soc_nom"] + "");
                    info[2].Add(dataReader["Soc_mail"] + "");


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
    }
}
