namespace DragonBall
{
    public interface ITorneo
    {
        public void Init();
        public List<Persona> Execute();
        public void Visit();
        public Persona Winner();
    }
}
