using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для формы Редактирование данных специальностей
    /// </summary>
    public partial class SpecialityFormEdit : Form
    {
        /// <summary>
        /// Поле для хранения списка специальностей
        /// </summary>
        private IEnumerable<Speciality> specialities;

        /// <summary>
        /// Поле для хранения текущей специальности
        /// </summary>
        private Speciality currentSpeciality;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="Id">Id специальности</param>
        public SpecialityFormEdit(string Id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            currentSpeciality = specialities.FirstOrDefault(e => e.Id.ToString().ToLower() == Id.ToLower());
            String facultyName = context.Faculties.First(e => e.Id.ToString().ToLower() == currentSpeciality.FacultyId.ToLower()).Name;
            facultyInput.Items.Add(facultyName);
            facultyInput.Text = facultyName;
            specialityCodeInput.Text = currentSpeciality.SpecialityCode;
            specialityNameInput.Text = currentSpeciality.Name.ToString(); 
        }

        /// <summary>
        /// Метод нажатия на кнопку Сохранить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void closeButton_Click(object sender, EventArgs e)
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
                Speciality speciality = context.Specialities.FirstOrDefault(e => e.Id == currentSpeciality.Id);
                if (speciality != null)
                {
                    speciality.Name = specialityNameInput.Text;
                    context.SaveChanges();
                }
            }
        }
    }
}
