using System.Data.SqlClient;

namespace ConnectingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConnection4();
        }

        public const string conectionString = "Data Source=192.168.56.101,1433;Database=SUPERTIENDA;User ID=sa;Password=SqlServer123;";

        //192.168.56.101
        //nombre de la base de datos, STUDENTS
        //userID = sa
        //PASS = SqlServer123

        public static void TestConnection1()
        {
            SqlConnection connection = new SqlConnection(conectionString);
            connection.Open();
            connection.Dispose();
        }

        public static void TestConnection2()
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CLASEDAM", connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void TestConnectionCHATGPT()
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CLASEDAM WHERE NAME = 'andres'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["NAME"].ToString());
                        }
                    }
                }
            }
        }

        public static void TestConnection3()
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM CLASEDAM", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[1].ToString());
                }
            }
        }

        public static void TestConnection4()
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM PRODUCTOS", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString());
                }
            }
        }
    }
}