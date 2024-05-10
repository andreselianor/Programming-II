namespace DelegadosResumen
{
    public class Country
    {
        private List<City> _citiesList = new List<City>();

        public void CreateCitiesList()
        {
            City c1 = new City("Alicante", 350000);
            City c2 = new City("Valencia", 850000);
            City c3 = new City("Madrid", 1250000);
            City c4 = new City("Sevilla", 950000);
            City c5 = new City("Barcelona", 1100000);
            City c6 = new City("Bilbao", 870000);
            City c7 = new City("Pontevedra", 250000);

            _citiesList = new List<City>() { c1, c2, c3, c4, c5, c6, c7 };
        }

        // Podemos implementar una funcion 'FILTER' que ordena nuestra coleccion de datos
        // según una 'FUNCION DELEGADA' que introduce el usuario a traves de una 'LAMBDA'

        // public List Filter(FUNCION LAMBDA)
        // la funcion 'Filter' devuelve una lista segun los criterios de la 'FUNCION LAMBDA.


        #region Delegate Filter
        // CREAMOS UN CODIGO FUENTE QUE:
        // FILTRA ->
        // UNA COLECCION EXISTENTE MEDIANTE UNA FUNCION FILTER ->
        // A TRAVES DE UNA FUNCION DELEGADA
        // ======================================================

        // A. Definicion de la FUNCION DELEGADA:
        // La funcion NO RECIBE PARAMETROS y devuelve un BOOL.
        public delegate bool DelegateFilterPlain();


        // B. Definicion de la funcion que FILTRA:
        // Si la funcion delegada devuelve 'TRUE' para un elemento, lo añade a la lista resultado.
        public List<City> Filter(DelegateFilterPlain filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter())
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }


        // C. Definicion de los parametros de la FUNCION DELEGADA:
        // Existen distintas sintaxis para la funcion filter.
        public void FilterTest()
        {
            Country countryTest = new Country();
            List<City> listResult = new List<City>();

            // sintaxis 1
            DelegateFilterPlain delegado = delegate () { return true; };
            DelegateFilterPlain filter = new DelegateFilterPlain(delegado);
            listResult = countryTest.Filter(filter);

            // sintaxis 2
            DelegateFilterPlain filter2 = new DelegateFilterPlain(() => { return true; });
            listResult = countryTest.Filter(filter2);

            // sintaxis 3
            DelegateFilterPlain filter3 = new DelegateFilterPlain(() => true );
            listResult = countryTest.Filter(filter3);
        }


        // A'. Definicion de la FUNCION DELEGADA:
        // La funcion RECIBE UN INT y devuelve un BOOL.
        public delegate bool DelegateFilterWithInt(int population);
        public List<City> Filter(DelegateFilterWithInt filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter(_citiesList[i].Population))
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }







        // A''. Definicion de la FUNCION DELEGADA:
        // La funcion RECIBE UN STRING y devuelve un BOOL.
        public delegate bool DelegateFilterWithString(string name);
        public List<City> Filter(DelegateFilterWithString filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter(_citiesList[i].Name))
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }
        #endregion


        #region Delegate Sort
        // CREAMOS UN CODIGO FUENTE QUE:
        // ORDENA ->
        // UNA COLECCION EXISTENTE MEDIANTE UNA FUNCION SORT ->
        // A TRAVES DE UNA FUNCION DELEGADA
        // ======================================================

        // A. Definicion de la FUNCION DELEGADA:
        // La funcion recibe DOS ELEMENTOS DE LA COLECCION y devuelve un INT.
        public delegate int DelegateSort(City city1, City city2);


        // B. Definicion de la funcion que ORDENA:
        // Si la funcion delegada devuelve '-1' se mantiene la posición, si devuelve '1' mueve el elemento a la derecha.
        public List<City> Sort(DelegateSort filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                for(int j = i + 1; j < _citiesList.Count; j++)
                {
                    if (filter(_citiesList[i], _citiesList[j]) > 0)
                    {
                        City aux;
                        aux = _citiesList[i];
                        _citiesList[i] = _citiesList[j];
                        _citiesList[j] = aux;
                    }
                }                
            }
            return result;
        }

        // C. Definicion de los parametros de la FUNCION DELEGADA:
        // Existen distintas sintaxis para la funcion filter.
        public void SortTest()
        {
            Country countryTest = new Country();
            List<City> listResult = new List<City>();

            // sintaxis 1
            DelegateSort delegado = delegate (City city1, City city2) { return 0; };
            DelegateSort filter = new DelegateSort(delegado);
            listResult = countryTest.Sort(filter);

            // sintaxis 2
            DelegateSort filter2 = new DelegateSort((City city1, City city2) => { return 0; });
            listResult = countryTest.Sort(filter2);

            // sintaxis 3
            DelegateSort filter3 = new DelegateSort((City city1, City city2) => 0);
            listResult = countryTest.Sort(filter3);
        }
        #endregion


        #region Delegate Visit
        // CREAMOS UN CODIGO FUENTE QUE:
        // VISITA ->
        // TODA LA COLECCION EXISTENTE MEDIANTE UNA FUNCION DEFINIDA POR EL USUARIO ->
        // A TRAVES DE UNA FUNCION DELEGADA
        // ======================================================

        // A. Definicion de la FUNCION DELEGADA:
        // La funcion recibe UN ELEMENTO DE LA COLECCION y devuelve VOID.
        public delegate void DelegateVisit(City visitor);


        // B. Definicion de la funcion que VISITA:
        // El usuario definirá la FUNCIÓN que se realiza sobre CADA UNO DE LOS ELEMENTOS
        // de la colección.
        public void Visit(DelegateVisit visitor)
        {
            for(int i = 0; i < _citiesList.Count; i++)
            {
                visitor(_citiesList[i]);
            }
        }

        // C. Definicion de los parametros de la FUNCION DELEGADA:
        // Existen distintas sintaxis para la funcion filter.
        public void VisitTest()
        {
            Country countryTest = new Country();
            List<City> listResult = new List<City>();

            // sintaxis 1
            DelegateVisit delegado = delegate (City city1) { Console.WriteLine(city1.Name + ": " + city1.Population) };
            DelegateVisit filter = new DelegateVisit(delegado);
            countryTest.Visit(filter);

            // sintaxis 2
            DelegateVisit filter2 = new DelegateVisit((City city1) => { Console.WriteLine(city1.Name + ": " + city1.Population) });
            countryTest.Visit(filter2);

            // sintaxis 3
            DelegateVisit filter3 = new DelegateVisit((City city1) => Console.WriteLine(city1.Name + ": " + city1.Population));
            countryTest.Visit(filter3);
        }
        #endregion
    }
}