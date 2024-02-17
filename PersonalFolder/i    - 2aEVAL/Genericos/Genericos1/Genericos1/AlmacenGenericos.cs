namespace Genericos1
{
    public class AlmacenGenericos<T>
    {
        //private Object[] almacenObjetos;      Eliminamos Object
        private T[] almacenGenericos;

        private int i = 0;

        public AlmacenGenericos(int z)
        {
            //almacenObjetos = new Object[z];   Eliminamos Object
            almacenGenericos = new T[z];
        }

        //public void AddElement(Object o)      Eliminamos Object
        public void AddElement(T element)
        {
            almacenGenericos[i] = element;
            i++;
        }

        //public Object GetElement(int index)   Eliminamos Object
        public T GetElement(int index)
        {
            return almacenGenericos[index];
        }
    }
}
