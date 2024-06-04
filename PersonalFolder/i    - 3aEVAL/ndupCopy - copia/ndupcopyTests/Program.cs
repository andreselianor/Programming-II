using ndupcopy;
namespace ndupcopyTests
{
    public delegate void Delegado(string[] text);

    internal class Program
    {
        static void Main(string[] args)
        {
            // ESTE PROYECTO DE TESTS ESTA DEDICADA A LAS PRUEBAS DE UNIDAD_

            // HE SEPARADO LAS PRUEBAS EN PRUEBAS UNITARIAS, DE CADA FUNCION EN PARTICULAR
            // Y PRUEBAS DE INTEGRACION, DE TODO EL PROGRAMA EN GENERAL_

            #region PRUEBAS INTEGRACION
            // Este es el codigo que ejecuta el programa.
            // el parametro 'args' contiene las rutas de las carpetas contenedoras de los archivos que quiero copiar.

            // Test1:
            // En el primer caso, le pasamos por argumentos la direccion de UNA carpeta:
            // ..\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\
            // IUpCopy upCopy = new upCopy();
            // Controller.Launch(upCopy, args);

            // Test2:
            // Se realiza otra prueba general para comprobar que elimina archivos duplicados.

            // Test3:
            // Se realiza otra prueba general para comprobar que elimina archivos duplicados en distintas carpetas.

            IUpCopy upCopy = new upCopy();
            Controller.Launch(upCopy, args);

            #endregion

            #region PRUEBAS UNITARIAS 

            // PROCESO DE LAS PRUEBAS DE TEST UNITARIAS:
            
            // Test1: detecta archivos que tienen el mismo contenido.
            // El test devuelve que NO COPIA los archivos repetidos, pero mantiene el archivo listado en primer lugar.
            // Es posible realizar una funcion que copie el archivo que contenga el nombre mas corto.

            // Test2: Este test comprueba una estructura mas compleja de carpetas, con dos carpetas anidadas dentro del origen.
            // Tambien contiene archivos duplicados.

            // Test3: El siguiente Test comprueba el funcionamiento del programa si la carpeta que le paso por parametros NO EXISTE
            // El programa lanza una excepcion.

            // Test4: El siguiente Test comprueba el funcionamiento del programa con dos carpetas diferentes,
            // pasandolas por parametros 'args' de la funcion Main.

            // Test5: Se destinan pruebas para comprobar que la salida grafica por consola de los mensajes de texto son correctos.

            // Test6: Hay que testear la entrada por consola con la direccion de destino de los archivos.
            // En caso de fallo, se lanza un mensaje de error.

            // Test7: Se le pregunta al usuario si quiere mantener la estructura de carpetas. Es necesario comprobar que las entradas
            // no son null y se adaptan a la interfaz de usuario.

            // Test8:
            // upFile.CreateFile() Test de creacion de archivos tipo UpFile.

            // Test9: 
            // upFile file = new upFile();
            // string filepath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\Archivo2.txt";
            // byte[] result = file.CreateFile(filepath);

            // Test10:
            // string filepath2 = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaDestino\Archivo2.txt";
            // File.WriteAllBytes(filepath2, result);

            // Test11:
            // upFile file = new upFile();
            // string filepath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaOrigen\Archivo1.txt";
            // byte[] result = file.CreateFile(filepath);

            // Test12:
            // string filepath2 = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaDestino\Archivo1.txt";
            // File.WriteAllBytes(filepath2, result);
            #endregion
        }
    }
}