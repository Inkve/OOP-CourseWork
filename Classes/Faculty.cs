using CourseWork_With_SQLite.Context;

namespace CourseWork_With_SQLite.Classes
{
    /// <summary>
    /// Класс для реализации факультета
    /// </summary>
    public class Faculty
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Название факульета</param>
        public Faculty(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        /// <summary>
        /// ID факультета
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название факультета
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Приведене объекта к строке
        /// </summary>  
        /// <returns>Название факультета</returns>
        public override string ToString()
        {
            return Name;
        }
        /// <summary>
        /// Добавление объекта в базу данных    
        /// </summary>
        public void AddInDataBase()
        {
            using (CourseWorkContext db = new Context.CourseWorkContext())
            {
                db.Faculties.Add(this);
                db.SaveChanges();
            }
        }
    }
}
