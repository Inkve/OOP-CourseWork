using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для реализации формы для редактирования данных экзамена
    /// </summary>
    public partial class ExamenEditForm : Form
    {
        /// <summary>
        /// Поле для хранения списков студентов
        /// </summary>
        private IEnumerable<Student> students;
        /// <summary>
        /// Поле для хранения списков дисциплин
        /// </summary>
        private IEnumerable<Subject> subjects;
        /// <summary>
        /// Поле для хранения списков экзаменов
        /// </summary>
        private IEnumerable<Exam> exams;
        /// <summary>
        /// Поле для хранения объекта текущего объекта
        /// </summary>
        private Exam currentExam;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">Id экзамена </param>
        public ExamenEditForm(string id)
        {
            CourseWorkContext context = new CourseWorkContext();
            students = context.Students.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
            exams = context.Exams.AsEnumerable();
            currentExam = exams.FirstOrDefault(e => e.Id.ToString() == id);
            InitializeComponent();
            updateInformation();
        }

        /// <summary>
        /// Метод обновления информации
        /// </summary>
        private void updateInformation()
        { 
            subjectInput.Items.Add(subjects.FirstOrDefault(e => e.Id.ToString() == currentExam.IdSubject).ToString());
            subjectInput.Text = subjectInput.Items[0].ToString();
            semesterInput.Items.Add(currentExam.Semester.ToString());
            semesterInput.Text = semesterInput.Items[0].ToString();
            studentInput.Items.Add(students.FirstOrDefault(e => e.Id.ToString() == currentExam.IdStudent).ToString()); 
            studentInput.Text = studentInput.Items[0].ToString();
        }

        /// <summary>
        /// Метод нажатия на кнопку выхода
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void exitButton_Click(object sender, EventArgs e)
        { 
            Close();
        }

        /// <summary>
        /// Метод нажатия на кнопку сохранения 
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Exam exam = context.Exams.FirstOrDefault(e => e.Id == currentExam.Id);
                if (exam != null)
                {
                    exam.Score = (int)scoreInput.Value;
                    context.SaveChanges();
                }
            }
        }
    }
}
