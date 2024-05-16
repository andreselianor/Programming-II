using System.Text.Json;

namespace JSONTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("../../../RSC/TestJson2.json"))
            {
                string json = sr.ReadToEnd();
                Test2 t2 = JsonSerializer.Deserialize<Test2>(json);

                Console.WriteLine(t2.user[0].security.userName);
                Console.WriteLine(t2.user[0].security.userPassword);
                // Console.WriteLine(t2.user[0].id);
                //Console.WriteLine(t2.user[0].security["userPassword"]);
                //Console.WriteLine(t1.user[0].lastName);
            }

            string json2 = File.ReadAllText("../../../RSC/TestJson2.json");
            Test2 t22 = JsonSerializer.Deserialize<Test2>(json2);

            Console.WriteLine(t22.user[0].security.userName);
            Console.WriteLine(t22.user[0].security.userPassword);

            FileStream fs = new FileStream("../../../RSC/TestJson2.json", FileMode.Open);

            //string json3 = fs.Read();
            //Test2 t23 = JsonSerializer.Deserialize<Test2>(json3);

            Console.WriteLine(t23.user[0].security.userName);
            Console.WriteLine(t23.user[0].security.userPassword);
        }
    }
}