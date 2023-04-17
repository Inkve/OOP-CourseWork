using CourseWork_With_SQLite.Context;

namespace CourseWork_With_SQLite.Classes
{
    /// <summary>
    /// Класс для реализации специальности
    /// </summary>
    public class Speciality
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="specialityCode">Код специальности</param>
        /// <param name="name">Название специальноссти</param>
        /// <param name="facultyId">ID факультета</param>
        public Speciality(string specialityCode, string name, string facultyId)
        {
            Id = Guid.NewGuid();
            SpecialityCode = specialityCode;
            Name = name;
            FacultyId = facultyId;
        }
        /// <summary>
        /// ID специальности
        /// </summary>
        public Guid Id;
        /// <summary>
        /// Код специальности
        /// </summary>
        public string SpecialityCode;
        /// <summary>
        /// Название специальности
        /// </summary>
        public string Name;
        /// <summary>
        /// ID факультета
        /// </summary>
        public string FacultyId;
        /// <summary>
        /// Приведение объекта к строке
        /// </summary>
        /// <returns>Код специальности - Название специальности</returns>
        public override string ToString()
        {
            return SpecialityCode.ToString() + " - " + Name.ToString();
        }
        /// <summary>
        /// Добавление объекта в базу данных
        /// </summary>
        public void AddInDataBase()
        {
            using (CourseWorkContext db = new Context.CourseWorkContext())
            {
                db.Specialities.Add(this);
                db.SaveChanges();
            }
        }
    }
}
