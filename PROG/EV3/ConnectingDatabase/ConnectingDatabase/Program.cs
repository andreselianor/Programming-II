using System.Data.SqlClient;

namespace ConnectingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestSQL test = new TestSQL();
            test.Test();
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
