using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для реализации формы Редактирование данных дисциплины
    /// </summary>
    public partial class SubjectEditForm : Form
    {
        /// <summary>
        /// Поле для хранения дисциплин
        /// </summary>
        private IEnumerable<Subject> subjects;

        /// <summary>
        /// Поле для хранения тукещей дисциплины
        /// </summary>
        private Subject currentSubject;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="Id">Id дисциплины</param>
        public SubjectEditForm(String Id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            subjects = context.Subjects.AsEnumerable();
            currentSubject = subjects.FirstOrDefault(e => e.Id.ToString().ToLower() == Id.ToLower());
            String specialityCode = context.Specialities.First(e => e.Id.ToString().ToLower() == currentSubject.SpecialityID.ToLower()).SpecialityCode;
            specialityInput.Items.Add(specialityCode);
            specialityInput.Text = specialityCode;
            nameInput.Text = currentSubject.ToString();
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
                Subject subject = context.Subjects.FirstOrDefault(e => e.Id == currentSubject.Id);
                if (subject != null)
                {
                    subject.Name = nameInput.Text;
                    context.SaveChanges();
                }
            }
        }
    }
}
