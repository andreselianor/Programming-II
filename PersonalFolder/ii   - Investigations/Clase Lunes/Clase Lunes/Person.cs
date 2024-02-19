namespace Clase_Lunes
{
    public enum TypePerson
    {
        STUDENT,
        TEACHER
    }
    public abstract class Person
    {
        protected TypePerson _typePerson;

        public TypePerson TypePerson => _typePerson;
    }
}
