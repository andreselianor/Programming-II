namespace ndupcopy
{
    public interface IUpCopy
    {
        upFile CreateUpFile(string filePath, string folderPath);
        void SetOutputFolder(string path);


        void AddupFilesToList(upFile upFile);
        void RemoveDuplicates();
        void CopyupFiles();
    }
}