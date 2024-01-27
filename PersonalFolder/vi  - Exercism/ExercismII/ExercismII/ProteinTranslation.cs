namespace ExercismII
{
	public enum ProteinType
    {        
        Methionine,
        Phenylalanine,
        Leucine,
        Serine,
        Tyrosine,
        Cysteine,
        Tryptophan,
        Stop,
        Default
    }

    public static class ProteinTranslation
    {
        // Funcion que devuelve el tipo de las proteinas que componen una cadena de nucleotidos.
        public static string[] Proteins(string strand)
        {            
            string[] arrayResult = new string[0];
            bool stopCodons = false;

            if(strand == null || strand.Length == 0)                
                 return arrayResult;
            
            string actualStrand = strand;
            string strandProtein = "";
            string leftStrand = "";

            while (!stopCodons)
            {
                strandProtein = BrokeStrand(actualStrand);

                ProteinType proteinResult = TranslateToProtein(strandProtein);

                if (proteinResult == ProteinType.Stop)
                    stopCodons = true;
                else
                    arrayResult = AddElementToArray(arrayResult, proteinResult);

                leftStrand = RemoveBrokeStrand(actualStrand);

                if (leftStrand.Length < 3)
                    stopCodons = true;

                actualStrand = leftStrand;
            }

            return arrayResult;
        }

        // Funcion que devuelve una cadena de 3 nucleotidos.
        public static string BrokeStrand(string strand)
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                result += strand[i];
            }
            return result;
        }

        // Funcion que transforma la cadena de nucleotidos en un tipo de proteina.
        public static ProteinType TranslateToProtein(string brokeStrand)
        {
            if (brokeStrand == "AUG")
                return ProteinType.Methionine;

            if (brokeStrand == "UUU" || brokeStrand == "UUC")
                return ProteinType.Phenylalanine;

            if (brokeStrand == "UUA" || brokeStrand == "UUG")
                return ProteinType.Leucine;

            if (brokeStrand == "UCU" || brokeStrand == "UCC" ||
               brokeStrand == "UCA" || brokeStrand == "UCG")
                return ProteinType.Serine;

            if (brokeStrand == "UAU" || brokeStrand == "UAC")
                return ProteinType.Tyrosine;

            if (brokeStrand == "UGU" || brokeStrand == "UGC")
                return ProteinType.Cysteine;

            if (brokeStrand == "UGG")
                return ProteinType.Tryptophan;

            if (brokeStrand == "UAA" || brokeStrand == "UAG" ||
               brokeStrand == "UGA")
                return ProteinType.Stop;

            return ProteinType.Default;
        }

        // Funcion que añade una proteina al array resultante.
        public static string[] AddElementToArray(string[] array, ProteinType proteinResult)
        {
            int count = array.Length;
            string[] arrayResult = new string[count + 1];
            for (int i = 0; i < count; i++)
            {
                arrayResult[i] = array[i];
            }
            arrayResult[count] = "" + proteinResult;

            return arrayResult;
        }

        // Funcion que devuelve una nueva cadena sin las proteinas calculadas.
        public static string RemoveBrokeStrand(string brokeStrand)
        {
            string result = "";
            for (int i = 3; i < brokeStrand.Length; i++)
            {
                result += brokeStrand[i];
            }
            return result;
        }
    }
}