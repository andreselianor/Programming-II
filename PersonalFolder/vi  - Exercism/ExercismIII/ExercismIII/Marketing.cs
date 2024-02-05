namespace ExercismIII
{
    public class Marketing
    {
        public static string Print(int? id, string name, string? department)
        {
            //STRING INTERPOLATION!!!!
            string result = "";

            string SIGNS = " - ";
            string ID = "[" + id + "]";
            string completeName = name;
            string DEPARTMENT = department?.ToUpper();
            string DEPARTMENTOWNER = "OWNER";

            if (department == null)
            {
                if (id == null)
                    result = completeName + SIGNS + DEPARTMENTOWNER;
                else
                    result = ID + SIGNS + completeName + SIGNS + DEPARTMENTOWNER;
            }

            else if (id == null)
            {
                result = completeName + SIGNS + DEPARTMENT;
            }

            else
            {
                result = ID + SIGNS + completeName + SIGNS + DEPARTMENT;
            }

            return result;
        }
    }
}
