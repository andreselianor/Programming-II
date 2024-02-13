namespace RepasoCurso
{
    public class Genericos<T>
    {
        private T _content;

        public Genericos(T content)
        {
            _content = content;
        }

        public Genericos()
        {

        }

        public void SetContent(T content)
        {
            if(content == null)
                throw new ArgumentNullException("content");
            _content = content;
        }
    }
}
