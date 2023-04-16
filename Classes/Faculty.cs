namespace CourseWork_With_SQLite.Classes
{

    public class Faculty
    {
        public Faculty(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public void AddInDataBase()
        {
            using (var db = new Context.CourseWorkContext())
            {
                db.Faculties.Add(this);
                db.SaveChanges();
            }
        }
    }
}
