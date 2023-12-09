namespace ExamenNoviembre
{
    public class Stadistics
    {

        public static double GetAverageIMC(Classroom classroom)
        {
            double classroomIMC = 0.0;

            List<Student> classList = classroom.StudentList;

            for (int i = 0; i < classList.Count; i++)
            {
                classroomIMC += classList[i].GetIMC();
            }

            double studentsCount = classroom.GetStudentsCount();

            return classroomIMC / studentsCount;
        }

        public static Student GetBestStudent(Classroom classroom)
        {
            List<Student> classList = classroom.StudentList;
            Student bestStudent = new Student();

            double bestNote = 0.0;

            for (int i = 0; i < classList.Count; i++)
            {
                if (classList[i].Notes.GetBestNote() > bestNote)        // HE LLAMADO A LA FUNCION PORQUE! ME RESULTA MAS SENCILLO QUE UTILIZAR LA SINTAXIS DE LOS DICTIONARIOS.
                    bestStudent = classList[i];
            }
            return bestStudent;
        }

        public static Student GetYoungestStudent(Classroom classroom)
        {
            List<Student> listResult = SortListAscendingAge(classroom.StudentList); // La Funcion Sort se define mas abajo

            return listResult[0];
        }

        public static List<Student> GetStudentsWithGender(Gender gender, Classroom classroom)
        {
            List<Student> listResult = new List<Student>();

            List<Student> classList = classroom.StudentList;

            for (int i = 0; i < classList.Count; i++)
            {
                if (classList[i].Gender == gender)
                {
                    listResult.Add(classList[i]);
                }
            }

            listResult = SortListAscendingAge(listResult);

            return listResult;
        }

        public static List<Student> SortListAscendingAge(List<Student> listStudent)
        {
            Student aux = new Student();

            for (int i = 0; i < listStudent.Count - 1; i++)
            {
                for (int j = i + 1; j < listStudent.Count; j++)
                {
                    if (listStudent[i].Age > listStudent[j].Age)
                    {
                        aux = listStudent[i];
                        listStudent[i] = listStudent[j];
                        listStudent[j] = aux;
                    }
                }
            }
            return listStudent;
        }

        // ESTA SERIA LA APROXIMACION QUE HARIA EL AÑO PASADO
        public static void GetStadistics(Classroom classroom)
        {
            Console.WriteLine("Lista de alumnos y notas");

            double count = 0;
            for (int i = 0; i < classroom.StudentList.Count; i++)
            {
                if (classroom.StudentList[i].Notes.GetAverageNote() > 9)
                    count++;
            }
            Console.WriteLine($"Alumnos con nota media mayor a 9: {count}");

            count = 0;
            for (int i = 0; i < classroom.StudentList.Count; i++)
            {
                if (classroom.StudentList[i].Notes.GetAverageNote() > 7)
                    count++;
            }
            Console.WriteLine($"Alumnos con nota media mayor a 7: {count}");
        }

        // AHORA ESTOY PENSANDO EN ALGO COMO ESTO        
        public static List<Student> GetStadisticsAlt(Classroom classroom)
        {
            
            List<Student> listStudents = new List<Student>();
            List<Tag> listResult = new List<Tag>();
            // <"alumnos de 9" | tag | "alumnos de 7" | tag |...>
            // es decir una lista que contenga Students y contenga Tags             
            // Creo personalmente que la mejor opcion es devolver una lista,
            // lo que aun no se, es como dividir dicha lista en distintas secciones

            return listStudents;
        }

        public static (string,int) GetStadisticsAlternative(Classroom classroom)
        {
            // Sigo pensando que una Lista es la manera más correcta, pero
            // personalmente esta me gusta mucho.


            (string, int) result = ("Estos son todos los alumnos de un clase", classroom.StudentList.Count);


            int count = 0;
            for(int i = 0; i < classroom.StudentList.Count; i++)
            {
                if (classroom.StudentList[i].Notes.GetAverageNote() > 9)
                    count++;
            }
            result = ("Alumnos con nota media mayor de 9: ", count);
            //Console.WriteLine(result); OPCIONAL O EN CASO QUE TE GUSTEN LOS RESULTADOS POR CONSOLA.            


            count = 0;
            for (int i = 0; i < classroom.StudentList.Count; i++)
            {
                if (classroom.StudentList[i].Notes.GetAverageNote() > 7)
                    count++;
            }
            result = ("Alumnos con nota media mayor de 7: ", count);
            // Y ASI HASTA TERMINAR CON TODOS LOS ALUMNOS

            return result;
        }        
    }
}
