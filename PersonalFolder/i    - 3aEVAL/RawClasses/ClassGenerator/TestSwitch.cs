namespace ClassGenerator
{
    public class TestSwitch
    {


        public static string AnalyzeOffField(object report)
        {
            string result = "";

            switch (report)
            {
                case Incident report when report is int:
                    result = "Incidente";
                    break;
                default:
                    result = "Nothing";
                    break;
            }
            return result;
        }
    }

}
