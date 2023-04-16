namespace CourseWork_With_SQLite.Classes
{
    public class Subject
    {
        public Subject(string specialityID, string name)
        {
            Id = Guid.NewGuid();
            SpecialityID = specialityID;
            Name = name;
        }
        public Guid Id { get; set; }
        public string SpecialityID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public void AddInDataBase()
        {
            using (var db = new Context.CourseWorkContext())
            {
                db.Subjects.Add(this);
                db.SaveChanges();
            }
        }
    }
}
