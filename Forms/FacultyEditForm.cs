using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Форма редактирования данных факультетов
    /// </summary>
    public partial class FacultyEditForm : Form
    {
        /// <summary>
        /// Поле для хранения списка факультетов
        /// </summary>
        private IEnumerable<Faculty> faculties;

        /// <summary>
        /// Поле для хранения текущего факультета
        /// </summary>
        private Faculty currentFaculty;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">Id факультета</param>
        public FacultyEditForm(string id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            faculties = context.Faculties.AsEnumerable();
            currentFaculty = faculties.FirstOrDefault(e => e.Id.ToString() == id);
            nameInput.Text = currentFaculty.ToString();
        }

        /// <summary>
        /// Метод нажатия на кнопку Выхода
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Метод нажатия на кнопку сохранить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Faculty faculty = context.Faculties.FirstOrDefault(e => e.Id == currentFaculty.Id);
                if (faculty != null)
                {
                    faculty.Name = nameInput.Text;
                    context.SaveChanges();
                }
            }
        }
    }
}
