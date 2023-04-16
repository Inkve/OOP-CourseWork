using CourseWork_With_SQLite.Context;

namespace CourseWork_With_SQLite.Classes
{
    /// <summary>
    /// Класс, для реализации экзамена
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="idStudent">ID студента</param>
        /// <param name="idSubject">ID дисциплины</param>
        /// <param name="semester">Семестр</param>
        /// <param name="score">Оценка</param>
        public Exam(string idStudent, string idSubject, int semester, int score)
        {
            Id = Guid.NewGuid();
            IdStudent = idStudent;
            IdSubject = idSubject;
            Semester = semester;
            Score = score;
        }
        /// <summary>
        /// ID экзамена
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// ID студента 
        /// </summary>
        public string IdStudent { get; set; }
        /// <summary>
        /// ID дисциплины
        /// </summary>
        public string IdSubject { get; set; }
        /// <summary>
        /// Семестр
        /// </summary>
        public int Semester { get; set; }
        /// <summary>
        /// Оценка
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Приведение объекта к строке
        /// </summary>
        /// <returns>Оценка за данный экзамен</returns>
        public override string ToString()
        {
            return Score.ToString();
        }
        /// <summary>
        /// Добавление объекта в базу данных
        /// </summary>
        public void AddInDataBase()
        {
            using (CourseWorkContext db = new Context.CourseWorkContext())
            {
                db.Exams.Add(this);
                db.SaveChanges();
            }
        }
    }
}
