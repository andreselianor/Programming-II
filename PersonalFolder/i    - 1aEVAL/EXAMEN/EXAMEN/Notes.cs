namespace EXAMEN
{
    public class Notes
    {
        private List<Signature> _listSignature = new List<Signature>();

        public List<Signature> ListSignatures => _listSignature;

        public double GetQualifications(Subject subject)
        {
            List<Signature> list = _listSignature;

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Subject == subject)
                    return list[i].NotesSubject;
            }
            return 0.0;
        }

        public void SetQualifications(Subject subject, double value)
        {
            List<Signature> list = _listSignature;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Subject == subject)
                    list[i].SetQualification(value);
            }
        }

        public int SetQualificationsALT(Subject subject, double value)
        {
            List<Signature> list = _listSignature;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Subject == subject)
                    list[i].SetQualification(value);
                return 1;
            }
            return -1;
        }

        public double GetAverageNotes()
        {
            double result = 0;
            int count = 0;

            List<Signature> list = _listSignature;

            for(int i = 0; i < list.Count; i++)
            {
                result += list[i].NotesSubject;
                count++;
            }

            return result / count;
        }

        public List<Signature> SortASCList()
        {
            List<Signature> list = _listSignature;
            Signature aux = new Signature();

            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].NotesSubject > list[j].NotesSubject)
                    {
                        aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
            return list;
        }

        public double GetMajorNote(List<Signature> list)
        {
            return list[list.Count - 1].NotesSubject;
        }

        public Subject GetBestSubject(List<Signature> list)
        {
            return list[list.Count - 1].Subject;
        }

        public double GetMinorNote(List<Signature> list)
        {
            return list[0].NotesSubject;
        }

        public Subject GetWorseSubject(List<Signature> list)
        {
            return list[0].Subject;
        }
    }
}
