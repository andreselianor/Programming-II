namespace ndupcopy
{
    public interface INDupcopy
    {
        upFile CreateUpFile(string filePath, string folderPath);
        void SetOutputFolder(string path);


        void AddupFilesToList(upFile upFile);
        void RemoveDuplicates();
        void CopyupFiles();
    }
}