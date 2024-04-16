namespace ndupcopy
{
    public class upFilePath
    {
        public string _originPath = "";
        public string _partialPath = "";
        public string _fileName = "";


        public static void GetPath(string path, string userFolder, out string relativePath, out string fileName)
        {
            relativePath = "";
            int userFolderCount = userFolder.Length;
            string completeRelative = path.Substring(userFolderCount);


            int fileNameCount = 0;
            for (int i = completeRelative.Length - 1; i > 0; i--)
            {
                if (completeRelative[i] == '\\')
                    break;
                fileNameCount++;
            }
            fileName = completeRelative.Substring(completeRelative.Length - fileNameCount);
        }
    }
}
