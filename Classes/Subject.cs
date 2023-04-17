using CourseWork_With_SQLite.Context;

namespace CourseWork_With_SQLite.Classes
{
    /// <summary>
    /// Класс реализации дисциплины
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="specialityID"ID специальности></param>
        /// <param name="name">Название</param>
        public Subject(string specialityID, string name)
        {
            Id = Guid.NewGuid();
            SpecialityID = specialityID;
            Name = name;
        }
        /// <summary>
        /// ID дисциплины
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Код специальности
        /// </summary>
        public string SpecialityID { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Приведение объекта к строке
        /// </summary>
        /// <returns>Название дисциплины</returns>
        public override string ToString()
        {
            return Name;
        }
        /// <summary>
        /// Добавление лбъекта в базу данных
        /// </summary>
        public void AddInDataBase()
        {
            using (CourseWorkContext db = new Context.CourseWorkContext())
            {
                db.Subjects.Add(this);
                db.SaveChanges();
            }
        }
    }
}
