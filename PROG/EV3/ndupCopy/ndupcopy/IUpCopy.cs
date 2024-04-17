namespace ndupcopy
{
    public interface IUpCopy
    {
        void SetOriginPath(string originPath);
        void SetTargetPath(string targetPath);
        void AddToListUpFiles();
        void RemoveDuplicateUpFiles();
        void CopyValidUpFiles();
    }
}