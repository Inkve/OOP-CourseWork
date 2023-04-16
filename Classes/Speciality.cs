namespace CourseWork_With_SQLite.Classes
{
    public class Speciality
    {
        public Speciality(string specialityCode, string name, string facultyId)
        {
            Id = Guid.NewGuid();
            SpecialityCode = specialityCode;
            Name = name;
            FacultyId = facultyId;
        }

        public Guid Id;
        public string SpecialityCode;
        public string Name;
        public string FacultyId;

        public override string ToString()
        {
            return SpecialityCode.ToString() + " - " + Name.ToString();
        }

        public void AddInDataBase()
        {
            using (var db = new Context.CourseWorkContext())
            {
                db.Specialities.Add(this);
                db.SaveChanges();
            }
        }
    }
}
