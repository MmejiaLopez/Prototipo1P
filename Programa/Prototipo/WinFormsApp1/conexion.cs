using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace LaboratorioClinico
{
    class conexion
    {
        public MySqlConnection con;
        
        public conexion()//conexion 
        {
            try
            {
                MySqlConnectionStringBuilder b = new MySqlConnectionStringBuilder();
                b.Server = "b9mltnosyl53bhn4vtfj-mysql.services.clever-cloud.com";
                b.UserID = "uezjxmffxlvcgkps";//cambiar el usuario
                b.Password = "F3YKq0s1qQ7NRpF5iiqM";//cambiar contraseña
                b.Database = "b9mltnosyl53bhn4vtfj";
                con = new MySqlConnection(b.ToString());
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        public void IDU(String sql)//funcion para insercion, eliminacion y actualizacion en base de datos
        {
            try 
            {
                MySqlCommand cmd = this.con.CreateCommand();
                cmd.CommandText = sql;
                this.con.Open();
                cmd.ExecuteNonQuery();
                this.con.Close();
                MessageBox.Show("Realizado con exito");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: "+e);
            }
           
        }


        public string[] buscar(String sql, int columna)//funcion para busqueda en BD parametros uno para el select y el otro para el numero de columna de la tabla de BD
        {
            string[] cadena = new string[columna];


            try
            {
                MySqlCommand cmd = this.con.CreateCommand();
                cmd.CommandText = sql;
                this.con.Open();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    for (int x = 0; x < columna; x++)
                    {

                       cadena[x] = leer.GetString(x);
                                             

                    }

                }
                this.con.Close();


            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);

            }


            return cadena;
        }


        public void IDU2(String sql)//funcion para insercion, eliminacion y actualizacion en base de datos
        {
            try
            {
                MySqlCommand cmd = this.con.CreateCommand();
                cmd.CommandText = sql;
                this.con.Open();
                cmd.ExecuteNonQuery();
                this.con.Close();
                
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        public DataTable Busqueda(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);        
                MySqlDataAdapter adapatador = new MySqlDataAdapter();
                adapatador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adapatador.Fill(tabla);

                return tabla;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e);
                return null;

            }
        }

        
    }
}
