namespace ndupcopy
{
    public class upCopy
    {
        private List<upFile> _filesList = new List<upFile>();
        private string _outputFolder = "";


        public void SetOutputFolder(string path)
        {
            _outputFolder = path;
        }        
    }
}