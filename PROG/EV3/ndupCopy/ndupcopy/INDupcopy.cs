namespace ndupcopy
{
    public interface INDupcopy
    {
        upFile CreateUpFile(string filePath, string folderPath);
        void AddUpFile(upFile upfile);


        bool ListContainsUpFile(upFile upfile);
        void RemoveDuplicates();


        void SetOutputFolder(string path);
        void CopyValidUpFiles();
    }
}