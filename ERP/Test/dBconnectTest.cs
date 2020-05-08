using MySql.Data.MySqlClient;
using NUnit.Framework;
using System;
using System.Collections.Generic;

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


        public dBconnectTest()
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

        public List<string>[] Select(string attributes, string table, string[] lignes, string condition)
        {
            string query = "SELECT " + attributes + " FROM " + table + " WHERE " + condition;
            List<string>[] info = new List<string>[lignes.Length];
            //info[0] = new List<string>();
            for (int i = 0; i < lignes.Length; i++)
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
        public List<string>[] Select(string attributes, string table, string[] lignes)
        {
            string query = "SELECT " + attributes + " FROM " + table;
            List<string>[] info = new List<string>[lignes.Length];
            //info[0] = new List<string>();
            for (int i = 0; i < lignes.Length; i++)
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
        public List<string>[] Select(string attributes, string table, string table2, string[] lignes, string premiereCondition, string condition)
        {
            string query = "SELECT " + attributes + " FROM " + table + " INNER JOIN " + table2 + " ON " + premiereCondition + " WHERE " + condition;
            List<string>[] info = new List<string>[lignes.Length];
            //info[0] = new List<string>();
            for (int i = 0; i < lignes.Length; i++)
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
        public void update(string nomTable, string colonne, int value, string condition)
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
        public void insert(string table, string[] nomLigne, string[] values)
        {
            string query = "INSERT INTO " + table + "(" + string.Join(",", nomLigne) + ") VALUES ('" + string.Join("','", values) + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }
    }
}
