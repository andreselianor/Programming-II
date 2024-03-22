namespace RepasoGeneral
{
    public class Coleccion3
    {
        private List<Dato> list = new List<Dato>();

        private class Dato
        {
            public int Atributo;
        }

        public Coleccion3 Clone()
        {
            Coleccion3 clone = new Coleccion3();
            for (int i = 0; i < list.Count; i++)
            {
                clone.list.Add(this.list[i]);
            }

            return clone;
        }

        public void AddDato(int atributo)
        {
            Dato dato = new Dato();
            dato.Atributo = atributo;
            list.Add(dato);
        }
    }
}
