using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для реализации формы Редактирование данных студента
    /// </summary>
    public partial class StudentEditForm : Form
    {
        /// <summary>
        /// Поле для хранения списка студентов
        /// </summary>
        private IEnumerable<Student> students;

        /// <summary>
        /// Поле для хранения текущего студента
        /// </summary>
        private Student currentStudent;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="Id">Id студента</param>
        public StudentEditForm(String Id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            students = context.Students.AsEnumerable();
            currentStudent = students.FirstOrDefault(e => e.Id.ToString().ToLower() == Id.ToLower());
            surnameInput.Text = currentStudent.Surname;
            nameInput.Text = currentStudent.Name;
            patronymicInput.Text = currentStudent.Patronymic;
            budgetInput.Checked = currentStudent.Budget;
            semesterInput.Value = currentStudent.SemesterOfStudy;
            groupInput.Text = currentStudent.Group;
            specialityInput.Items.Add(currentStudent.SpecialityCode);
            specialityInput.Text = currentStudent.SpecialityCode;
            birthdayInput.Text = currentStudent.BirthdayDate.ToString(); 
        }

        /// <summary>
        /// Метод нажатия на кнопку Выход
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Метод нажатия на кнопку Сохранить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Student student = context.Students.FirstOrDefault(e => e.Id == currentStudent.Id);
                if (student != null)
                {
                    student.Surname = surnameInput.Text;
                    student.Name = nameInput.Text;
                    student.Patronymic = patronymicInput.Text;
                    student.Budget = budgetInput.Checked;
                    student.SemesterOfStudy = (int) semesterInput.Value;
                    context.SaveChanges();
                }
            }
        }
    }
}
