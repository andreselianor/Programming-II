﻿using ndupcopy;
namespace ndupcopyTests
{
    public delegate void Delegado(string[] text);

    internal class Program
    {
        static void Main(string[] args)
        {

            #region PRUEBAS DE UNIDAD
            Delegado del1 = delegate (string[] text)
            {
                foreach (string s in text)
                    Console.WriteLine(s);
            };

            del1(args);
            del1(args);

            /*
             * 
             * /*
            
            --TEST 01
            string pathOrigen = "C:\\Andres\\DAM\\Programming-II\\PROG\\EV3\\ndupCopy\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "C:\\Andres\\DAM\\Programming-II\\PROG\\EV3\\ndupCopy\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
            
            */

            /*
             
            --TEST 02
            string pathOrigen = "..\\..\\..\\..\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "..\\..\\..\\..\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);

            */
            string origen = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\UpFileTests";
            string destino = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\copia1";

            var result = Directory.EnumerateDirectories(origen, "*.*", SearchOption.AllDirectories);
            foreach(string s in result)
            {
                CreateDirectories(s, destino, origen);
            }

            var result2 = Directory.EnumerateFiles(origen, "*.*", SearchOption.AllDirectories);
            foreach(string s2 in result2)
            {
                CreateFile(s2, destino, origen);
            }

            public static void CreateDirectories(string completePath, string destino, string origen)
        {
            string complete = completePath;
            int completeint = completePath.Length;

            string original = origen;
            int originalint = original.Length;

            string result = complete.Substring(originalint);
            Directory.CreateDirectory(destino + result);
        }
        public static void CreateFile(string completePath, string destino, string origen)
        {
            string complete = completePath;
            int completeint = completePath.Length;

            string original = origen;
            int originalint = original.Length;

            string relativa = complete.Substring(originalint);

            byte[] result = File.ReadAllBytes(completePath);
            File.WriteAllBytes(destino + relativa, result);
        }
        

            public void SetPath(string completePath, string targetPath, string origen, out string partialPath, out string fileName, out string finalPath)
            {

                int originalPathCount = completePath.Length;
                relativePath = completePath.Substring(originalPathCount);

                int fileNameCount = 0;
                for (int i = completePath.Length - 1; i > 0; i--)
                {
                    if (completePath[i] == '\\')
                        break;
                    fileNameCount++;
                }
                fileName = completePath.Substring(completePath.Length - fileNameCount);

                finalPath = relativePath + targetPath + fileName;

                _sourcePath = completePath;
                _targetPath = targetPath;

                int originalPathCount = origen.Length;
                partialPath = completePath.Substring(originalPathCount);
                _partialPath = partialPath;

                int fileNameCount = 0;
                for (int i = completePath.Length - 1; i > 0; i--)
                {
                    if (completePath[i] == '\\')
                        break;
                    fileNameCount++;
                }
                fileName = completePath.Substring(completePath.Length - fileNameCount);

                _fileName = fileName;

                finalPath = partialPath + targetPath + fileName;
                _completeTargetPath = finalPath;
                */
            #endregion

            IUpCopy upCopy = new upCopy();
            Controller.Launch(upCopy);
        }        
    }
}