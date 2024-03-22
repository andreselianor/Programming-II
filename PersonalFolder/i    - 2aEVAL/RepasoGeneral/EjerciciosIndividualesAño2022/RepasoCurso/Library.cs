using Microsoft.VisualBasic;

namespace RepasoCurso
{
    public class Library
    {
        public class Book
        {
            private string _title;
            private string _writer;
            private int _year;

            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }
            public string Writer
            {
                get { return _writer; }
                set { _writer = value; }
            }
            public int Year
            {
                get { return _year; }
                set { _year = value; }
            }

            public Book()
            {

            }
            public Book (string title, string writer, int year)
            {
                _title = title;
                _writer = writer;
                _year = year;
            }

            public bool IsOld()
            {
                return _year < 1500;
            }

            public bool IsValid()
            {
                if (_writer == null || _title == null)
                    return false;
                return true;
            }

            public Book Clone()
            {
                Book clone = new Book();
                clone._writer = _writer;
                clone._title = _title;
                clone._year = _year;
                return clone;
            }
        }

        private List<Book> _listBooks = new List<Book>();

        public int ListCount => _listBooks.Count;
        public bool IsEmpty => _listBooks.Count < 0;

        public Book GetBookAt(int index)
        {
            if (index < 0 || index > _listBooks.Count)
                return null;
            return _listBooks[index];
        }

        public int GetIndexOf(Book book)
        {
            for (int i = 0; i < _listBooks.Count; i++)
            {
                if (_listBooks[i] == book)
                    return i;
            }
            return -1;
        }

        public bool ContainsBook(Book book)
        {
            return GetIndexOf(book) >= 0;
        }

        public int ContainsBookWithTitle(string title)
        {
            for (int i = 0; i < _listBooks.Count; i++)
            {
                if (_listBooks[i].Title == title)
                    return i;
            }
            return -1;
        }

        public int ContainsBookWithTitle(string title, string writer)
        {
            for (int i = 0; i < _listBooks.Count; i++)
            {
                if (_listBooks[i].Title == title && _listBooks[i].Writer == writer)
                    return i;
            }
            return -1;
        }

        public void AddBook(Book book)
        {
            if (book == null || book.IsValid() == false)
                return;
            _listBooks.Add(book);
        }

        public int RemoveBookAt(int index)
        {
            if (index < 0 || index > _listBooks.Count)
                return -1;
            _listBooks.RemoveAt(index);
            return 1;
        }

        public void Clear()
        {
            _listBooks = new List<Book>();
        }

        public List<Book> Clone()
        {
            List<Book> cloneLibrary = new List<Book>();
            cloneLibrary = _listBooks;
            return cloneLibrary;
        }
    }
}
