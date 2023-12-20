using System.Data.SqlClient;
using System;

namespace Tinder
{
    public class Controlador
    {
        string connectionString = "Data Source=192.168.56.101,1433;Initial Catalog=TINDER;User ID=sa;Password=SqlServer123;Connection Timeout=30";                      // DESKTOP ESCUELA CLASE
        //string connectionString = "Data Source=192.168.56.102,1433;Initial Catalog=TINDER;User ID=sa;Password=SqlServer123;Connection Timeout=30";                      // PORTATIL BASE DATOS MAQUINA VIRTUAL
        //string connectionString = @"Data Source=PORTATILHP;Initial Catalog=JARDINERIA;User ID=MicrosoftAccount\andreselianor@gmail.com;Password=;Connection Timeout=30"; // PORTATIL

        public void Conectar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    // FUNCIONAMIENTO DE UNA SELECT
                    Console.WriteLine("Select 1");
                    using (SqlCommand Select1 = new SqlCommand("SELECT name, valoration FROM USERS", connection))
                    {
                        using (SqlDataReader reader = Select1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetFieldValue<string>(0);
                                byte valoration = reader.GetFieldValue<byte>(1);
                                Console.WriteLine("Name = " + name);
                                Console.WriteLine("Nombre = " + valoration);
                            }
                        }
                    }

                    /*
                    //  METODO II
                    Console.WriteLine("Select 2");
                    string parametro = "an";
                    using (SqlCommand Select2 = new SqlCommand($"SELECT nombre_cliente FROM CLIENTES WHERE nombre_cliente LIKE '%{parametro}%'", connection))
                    {

                        using (SqlDataReader reader = Select2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetFieldValue<string>(0);
                                Console.WriteLine("an = " + name);
                            }
                        }
                    }

                    Console.WriteLine("Select 3");
                    string insertQuery = "SELECT nombre_cliente FROM CLIENTES WHERE nombre_cliente LIKE @nombreCliente";

                    using (SqlCommand Select3 = new SqlCommand(insertQuery, connection))
                    {
                        Select3.Parameters.AddWithValue("@nombreCliente", "%jardin%");

                        using (SqlDataReader reader = Select3.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetFieldValue<string>(0);
                                Console.WriteLine(name);
                            }
                        }
                    }

                    Console.WriteLine("Select 4");
                    string @nombreCliente = "Agrojardin";
                    string insertQuery2 = "SELECT nombre_cliente FROM CLIENTES WHERE nombre_cliente = @nombreCliente";
                    using (SqlCommand Select4 = new SqlCommand(insertQuery2, connection))
                    {
                        Select4.Parameters.Add("@nombreCliente", SqlDbType.VarChar);
                        Select4.Parameters["@nombreCliente"].Value = @nombreCliente;
                        using (SqlDataReader reader = Select4.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetFieldValue<string>(0);
                                Console.WriteLine(name);
                            }
                        }
                    }

                    Console.WriteLine("Select 5");
                    string insertQuery3 = "SELECT nombre_cliente FROM CLIENTES WHERE nombre_cliente LIKE @nombreCliente";
                    using (SqlCommand Select5 = new SqlCommand(insertQuery3, connection))
                    {
                        Select5.Parameters.Add("@nombreCliente", SqlDbType.VarChar);
                        Select5.Parameters["@nombreCliente"].Value = "%gr%";
                        using (SqlDataReader reader = Select5.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetFieldValue<string>(0);
                                Console.WriteLine(name);
                            }
                        }
                    }*/
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}


