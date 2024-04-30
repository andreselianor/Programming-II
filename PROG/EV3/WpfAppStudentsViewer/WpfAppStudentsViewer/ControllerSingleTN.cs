using Library;

namespace WpfAppStudentsViewer
{
    public class ControllerSingleTN
    {
        private static ControllerSingleTN _controller = new ControllerSingleTN();

        public IDatabase _database = new Database();

        public static ControllerSingleTN Controller => _controller;
        public IDatabase Database => _database;

        private ControllerSingleTN()
        {

        }
    }
}