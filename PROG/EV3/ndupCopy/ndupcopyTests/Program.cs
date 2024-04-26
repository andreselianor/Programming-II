using ndupcopy;
namespace ndupcopyTests
{
    public delegate void Delegado(string[] text);

    internal class Program
    {
        static void Main(string[] args)
        {
            // ESTA CLASE PROGRAM ESTA DEDICADA A LAS PRUEBAS DE UNIDAD

            // HE SEPARADO LAS PRUEBAS EN PRUEBAS UNITARIAS, DE CADA FUNCION EN PARTICULAR
            // Y PRUEBAS DE INTEGRACION, DE TODO EL PROGRAMA EN GENERAL

            #region PRUEBAS INTEGRACION
            // Este es el codigo que ejectua el programa.
            // el parametro 'args' contiene las rutas de las carpetas contenedoras d elos archivos que quiero copiar.

            // la primera prueba corresponde a la carpeta
            // ..\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\
            // En esta caso, le pasamos por argumentos la direccion de UNA carpeta
            // ..\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\
            //IUpCopy upCopy = new upCopy();
            //Controller.Launch(upCopy, args);

            // La segunda prueba corresponde a la eliminacion de archivos duplicados
            IUpCopy upCopy = new upCopy();
            Controller.Launch(upCopy, args);

            // El Test1 comprueba archivos con el mismo contenido de archivo
            // El test devuelve que NO COPIA los archivos repetidos, pero mantiene el archivo listado en primer lugar.
            // Es posible realizar una funcion que copie el archivo que contenga el nombre mas corto.

            // Este test comprueba una estructura mas compleja de carpetas, con dos carpetas anidadas dentro del origen.
            // Tambien contiene archivos duplicados.

            // El siguiente Test comprueba el funcionamiento del programa si la carpeta que le paso por parametros NO EXISTE
            // El programa lanza una excepcion
            #endregion

            #region PRUEBAS UNITARIAS 

            // TEST 01
            // upFile.Create() Funciona correctamente

            //upFile file = new upFile();
            //string filepath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\Archivo2.txt";
            //byte[] result = file.CreateFile(filepath);

            //string filepath2 = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaDestino\Archivo2.txt";
            //File.WriteAllBytes(filepath2, result);

            //upFile file = new upFile();
            //string filepath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\Archivo1.txt";
            //byte[] result = file.CreateFile(filepath);

            //string filepath2 = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaDestino\Archivo1.txt";
            //File.WriteAllBytes(filepath2, result);



            #endregion

        }
    }
}