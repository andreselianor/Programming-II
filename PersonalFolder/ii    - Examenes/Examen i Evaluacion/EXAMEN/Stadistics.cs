namespace EXAMEN
{
    public class Stadistics
    {
        public static double GetAverageIMC(Classroom classroom)
        {
            double result = 0.0;
            int count = 0;

            List<Student> list = classroom.StudentList;
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i].GetIMC();
                count++;
            }

            if (count == 0)
                return 0.0;

            return result / count;
        }

        public static Student GetBestStudent(Classroom classroom)
        {
            List<Student> list = classroom.StudentList;
            Student studentResult = new Student();

            double bestNote = 0.0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Notes.GetMajorNote(list[i].Notes.ListSignatures) >= bestNote)
                    studentResult = list[i];
            }

            return studentResult;
        }

        public static Student GetYoungestStudent(Classroom classroom)
        {
            List<Student> list = new List<Student>();
            Student studentResult = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Age < studentResult.Age)
                    studentResult = list[i];
            }
            return studentResult;
        }

        public static List<Student> GetSortStudentsWithSignature(Classroom classroom, Subject subject)
        {
            List<Student> listResult = classroom.StudentList;


            for (int i = 0; i < listResult.Count; i++)
            {
                List<Signature> listSignatures = listResult[i].Notes.ListSignatures;

                for (int j = 0; j < listSignatures.Count; j++)
                    if (listSignatures[j].Subject == subject)
                    {
                        listResult.RemoveAt(i);
                    }
            }

            for (int i = 0; i < listResult.Count; i++)
            {
                Student studentAux = new Student();
                if (listResult[i].Notes.ListSignatures[0].NotesSubject < listResult[i + 1].Notes.ListSignatures[0].NotesSubject)
                {
                    studentAux = listResult[i];
                    listResult[i] = listResult[j];
                    listResult[j] = studentAux;
                }
            }
            return listResult;
        }

        public static List<Student> GetStudentsWithGender(Classroom classroom, Gender gender)
        {
            List<Student> listResult = classroom.StudentList;
            for (int i = 0; i < listResult.Count; i++)
            {
                if (listResult[i].Gender != gender)
                {
                    listResult.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < listResult.Count - 1; i++)
            {
                Student studentAux = new Student();
                for (int j = i + 1; j < listResult.Count; j++)
                {
                    if (listResult[i].Age < listResult[j].Age)
                    {
                        studentAux = listResult[i];
                        listResult[i] = listResult[j];
                        listResult[j] = studentAux;
                    }
                }
            }

            return listResult;
        }

        public static string GetStadistics(Classroom classroom)
        {
            List<Student> listResult9 = new List<Student>();
            List<Student> listResult7 = new List<Student>();
            List<Student> listResult5 = new List<Student>();
            List<Student> listResult3 = new List<Student>();
            List<Student> listResult0 = new List<Student>();

            for (int i = 0; i < classroom.StudentList.Count; i++)
            {
                if (classroom.StudentList[i].Notes.GetAverageNotes() >= 9)
                    listResult9.Add(classroom.StudentList[i]);

                if (classroom.StudentList[i].Notes.GetAverageNotes() >= 7 &&
                    classroom.StudentList[i].Notes.GetAverageNotes() < 9)
                    listResult7.Add(classroom.StudentList[i]);

                if (classroom.StudentList[i].Notes.GetAverageNotes() >= 5 &&
                    classroom.StudentList[i].Notes.GetAverageNotes() < 7)
                    listResult5.Add(classroom.StudentList[i]);

                if (classroom.StudentList[i].Notes.GetAverageNotes() >= 3 &&
                   classroom.StudentList[i].Notes.GetAverageNotes() < 5)
                    listResult3.Add(classroom.StudentList[i]);

                if (classroom.StudentList[i].Notes.GetAverageNotes() >= 0 &&
                   classroom.StudentList[i].Notes.GetAverageNotes() < 3)
                    listResult0.Add(classroom.StudentList[i]);
            }

            string result = "";

            result += "El numero de estudiantes con nota media superior a nueve es: " + listResult9.Count + "\n";
            result += "El numero de estudiantes con nota media superior a siete es: " + listResult7.Count + "\n";
            result += "El numero de estudiantes con nota media superior a cinco es: " + listResult5.Count + "\n";
            result += "El numero de estudiantes con nota media superior a tres es: " + listResult3.Count + "\n";
            result += "El numero de estudiantes con nota media superior a cero es: " + listResult0.Count + "\n";

            return result;
        }
    }
}
