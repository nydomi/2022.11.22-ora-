using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace gyomolcsokDB
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Database(string server = "localhost", string user = "root", string password = "", string db = "gyumolcsok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (KapcsolatOK())
            {
                command = connection.CreateCommand();
            }
            
        }
        public List<Gyumolcs> getGyomolcs()
        {
            List<Gyumolcs> list = new List<Gyumolcs>();
            command.CommandText = "SELECT * FROM gyumolcsok";
            Nyitas();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Gyumolcs gyumolcs = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                    list.Add(gyumolcs);
                }
            }
            Zaras(); 
            return list;    

        }
        private void Nyitas()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void Zaras()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private bool KapcsolatOK()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;    
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal bool addGyumolcs(Gyumolcs ujGyumolcs)
        {
            command.CommandText = "INSERT INTO gyumolcsok (id, nev, mennyiseg, egysegar) VALUE (null, @nev, @mennyiseg, @egysegar);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", ujGyumolcs.Nev);
            command.Parameters.AddWithValue("@mennyiseg", ujGyumolcs.Menyiseg);
            command.Parameters.AddWithValue("@egysegar", ujGyumolcs.Egysegar);
            Nyitas();
            if (command.ExecuteNonQuery()==1)
            {
                Zaras();

                return true;
            }
            else
            {
                Zaras();
                return false;
            }
        }
        internal bool updataGyumolcs(Gyumolcs gyumolcs)
        {
            command.CommandText = "UPDATE `gyumolcsok` SET `nev`=@nev,`egysegar`=@egysegar,`mennyiseg`=@mennyiseg WHERE id=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", gyumolcs.Id);
            command.Parameters.AddWithValue("@nev" , gyumolcs.Nev);
            command.Parameters.AddWithValue("@mennyiseg", gyumolcs.Menyiseg);
            command.Parameters.AddWithValue("@egysegar", gyumolcs.Egysegar);
            Nyitas();
            if (command.ExecuteNonQuery() == 1)
            {
                Zaras();
                return true;
            }
            else
            {
                Zaras();
                return false;
            }
        }
        internal bool deletGyumolcs(Gyumolcs gyumolcs)
        {
            command.CommandText = "DELETE FROM `gyumolcsok` WHERE 0";
            return true;
        }
    }
}
