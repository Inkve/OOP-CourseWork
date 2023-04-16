namespace CourseWork_With_SQLite.Classes
{
    public class Student
    {
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
        /// Индивидуального номера
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Фамилия
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
        /// Зачетная книжка
        /// </summary>
        /// 

        public override string ToString()
        {
            return Surname + " " + Name + " " + Patronymic;
        }
        internal void AddInDataBase()
        {
            using (var db = new Context.CourseWorkContext())
            {
                db.Students.Add(this);
                db.SaveChanges();
            }
        }
    }
}
