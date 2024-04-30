namespace Library
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Student(string name, int age, string description, int id) 
        {
            Name = name;
            Age = age;
            Description = description;
            Id = id;
        }
    }
}