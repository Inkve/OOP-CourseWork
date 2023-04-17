using CourseWork_With_SQLite.Context;

namespace CourseWork_With_SQLite.Classes
{
    /// <summary>
    /// Класс реализации студента
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="surname">Фамилим</param>
        /// <param name="name">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="birthdayDate">Дата рождения</param>
        /// <param name="budget">Обучение на бюджете</param>
        /// <param name="semesterOfStudy">Семестр обучения</param>
        /// <param name="specialityCode">Код специальности</param>
        /// <param name="group">Группа</param>
        public Student(string surname, string name, string patronymic, DateTime birthdayDate, bool budget,
            int semesterOfStudy, string specialityCode, string group)
        {
            Id = Guid.NewGuid();
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthdayDate = birthdayDate;
            Budget = budget;
            SemesterOfStudy = semesterOfStudy;
            SpecialityCode = specialityCode;
            Group = group;
        }

        /// <summary>
        /// ID студента
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthdayDate { get; set; }
        /// <summary>
        /// Обучение на бюджете
        /// </summary>
        public bool Budget { set; get; }
        /// <summary>
        /// Семестр обучения
        /// </summary>
        public int SemesterOfStudy { set; get; }
        /// <summary>
        /// Код специальности
        /// </summary>
        public string SpecialityCode { set; get; }
        /// <summary>
        /// Учебная группа
        /// </summary>
        public string Group { set; get; }
        /// <summary>
        /// Приведение объекта к строке
        /// </summary>
        /// <returns>Фамилия Имя Отчество</returns>
        public override string ToString()
        {
            return Surname + " " + Name + " " + Patronymic;
        }
        /// <summary>
        /// Добавление объекта в базу данных
        /// </summary>
        internal void AddInDataBase()
        {
            using (CourseWorkContext db = new Context.CourseWorkContext())
            {
                db.Students.Add(this);
                db.SaveChanges();
            }
        }
    }
}
