namespace Genericos1
{
    public class AlmacenBase
    {
        private Object[] almacenObjetos;
        private int i = 0;

        public AlmacenBase(int z)
        {
            almacenObjetos = new Object[z];
        }

        public void AddElement(Object o)
        {
            almacenObjetos[i] = o;
            i++;
        }

        public Object GetElement(int index)
        {
            return almacenObjetos[index];
        }
    }
}
