using System.Data.SqlClient;

namespace ConnectingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConnection();
        }
        public const string conectionString = "Data Source=192.168.56.101,1433;Database=STUDENT;User ID=sa;Password=SqlServer123;";
        //192.168.56.101
        //nombre de la base de datos, STUDENTS
        //userID = sa
        //PASS = SqlServer123

        public static void TestConnection()
        {
            
            SqlConnection connection = new SqlConnection(conectionString);

            connection.Open();

            connection.Dispose();
            /*
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employees", connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            */
        }

    }


    public class TestSQL
    {
        public void Test()
        {
            using (SqlConnection connection = new SqlConnection("../../../sampleDB/sampleDatabase.sql"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employees", connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
