namespace ExercismII
{

    public enum ProteinType
    {
        METHIONINE,
        PHENYLALANINE,
        LEUCINE,
        SERINE,
        TYROSINE,
        CYSTEINE,
        TRYPTOPHAN,
        STOP,
        DEFAULT
    }

    public static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            string[] arrayResult = new string[0];
            bool stopCodons = false;

            string actualStrand = strand;
            string strandProtein = "";
            string leftStrand = "";

            while (!stopCodons)
            {
                actualStrand = BrokeStrand(actualStrand);
                strandProtein = actualStrand;

                ProteinType proteinResult = TranslateToProtein(strandProtein);

                if (proteinResult == ProteinType.STOP)
                    stopCodons = true;
                else
                    arrayResult = AddElementToArray(arrayResult, proteinResult);

                leftStrand = RemoveBrokeStrand(strand);

                if (leftStrand.Length < 3)
                    stopCodons = true;

                actualStrand = leftStrand;
            }

            return arrayResult;
        }

        public static string BrokeStrand(string strand)
        {
            // Retorna una cadena de 3 nucleotidos
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                result += strand[i];
            }
            return result;
        }

        public static ProteinType TranslateToProtein(string brokeStrand)
        {
            if (brokeStrand == "AUG")
                return ProteinType.METHIONINE;

            if (brokeStrand == "UUU" || brokeStrand == "UUC")
                return ProteinType.PHENYLALANINE;

            if (brokeStrand == "UUA" || brokeStrand == "UUG")
                return ProteinType.LEUCINE;

            if (brokeStrand == "UCU" || brokeStrand == "UCC" ||
               brokeStrand == "UCA" || brokeStrand == "UCG")
                return ProteinType.SERINE;

            if (brokeStrand == "UAU" || brokeStrand == "UAC")
                return ProteinType.TYROSINE;

            if (brokeStrand == "UGU" || brokeStrand == "UGC")
                return ProteinType.CYSTEINE;

            if (brokeStrand == "UGG")
                return ProteinType.TRYPTOPHAN;

            if (brokeStrand == "UAA" || brokeStrand == "UAG" ||
               brokeStrand == "UGA")
                return ProteinType.STOP;

            return ProteinType.DEFAULT;
        }

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

