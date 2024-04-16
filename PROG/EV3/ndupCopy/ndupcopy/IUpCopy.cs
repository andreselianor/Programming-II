namespace ndupcopy
{
    public interface IUpCopy
    {
        //upFile CreateUpFile(string filePath);
        void SetOutputFolder(string path);


        void AddUpFilesToControlList(upFile upFile);
        void RemoveDuplicates();
        void CopyUpFiles();


        void GetPathTargetFiles();
    }
}