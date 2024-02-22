namespace PruebasBorrar
{
    public class FuncionAnonimaTeoria
    {
        // 1. Definicion del 'prototipo' delegado.
        // public 'delegate' [tipo de salida] [nombre de delegado] (tipo y parametro de entrada)
        public delegate int DelegateName(int parameter);

        public int Anonima(int number)
        {
            // 2. Definicion de la funcion anonima.
            // [nombre delegado] [nombre variable] = 'delegate' (tipo parametro) { cuerpo de la funcion anonima };
            DelegateName del = delegate (int value)
            {
                if (value < 50)
                    return -1;
                else
                {
                    return 1;
                }
            };

            // 3. Llamada al delegado.
            return del(number);             
        }
    }
}