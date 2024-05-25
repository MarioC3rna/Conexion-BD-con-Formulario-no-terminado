using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinCurso.data.data_acces
{
    internal class ConexionBD
    {
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=53150944cerna";

        public DataTable LeerBD()
        {

            DataTable  consolas = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM catalogo_consolas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(consolas);
                  
                    }
                }

                return consolas;

            }
















        }


    }

  }