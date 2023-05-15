using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using CourseWork_With_SQLite.Forms;
using System.Runtime.InteropServices;

namespace CourseWork_With_SQLite
{
    /// <summary>
    ///  Класс для формы Факультета
    /// </summary>
    public partial class FacultyForm : Form
    {
        /// <summary>
        /// Поле для хранения списка Факультетов
        /// </summary>
        private IEnumerable<Faculty> faculties;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public FacultyForm()
        {
            InitializeComponent();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на кнопку ВЫход
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Метод обновления таблицы
        /// </summary>
        private async void updateTable()
        {
            await updateFromDataBase();
            facultyTable.RowCount = 0;
            facultyTable.RowCount = faculties.Count();
            int counter = 0;
            foreach (Faculty faculty in faculties)
            {
                facultyTable.Rows[counter].Cells[0].Value = faculty.Id.ToString();
                facultyTable.Rows[counter].Cells[1].Value = counter + 1;
                facultyTable.Rows[counter].Cells[2].Value = faculty.Name;
                facultyTable.Rows[counter].Cells[3].Value = "⚙";
                facultyTable.Rows[counter].Cells[4].Value = "🗑";
                counter++;
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку Добавить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            string _name = nameInput.Text;
            try
            {
                if (!string.IsNullOrEmpty(_name))
                {
                    if (faculties.FirstOrDefault(e => e.Name == _name) != null)
                    {
                        throw new Exception("Факультет с текущим названием уже существует!");
                    }
                    Faculty temp = new Faculty(_name);
                    temp.AddInDataBase();
                    updateTable();
                    nameInput.Text = "";
                }
                else
                {
                    throw new Exception("Не все опции заполнены!");
                }
            }
            catch (Exception ex) 
            {
                [DllImport("user32.dll", CharSet = CharSet.Unicode)]
                static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
            }
        }

        /// <summary>
        /// Метод обновления информации
        /// </summary>
        /// <returns></returns>
        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            faculties = context.Faculties.AsEnumerable();
        }

        /// <summary>
        /// Метод изменения выделения таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void selectionChanged(object sender, EventArgs e)
        {
            facultyTable.ClearSelection();
        }

        /// <summary>
        /// Метод нажатия на ячейку таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void facultyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                FacultyEditForm facultyEditForm = new FacultyEditForm(facultyTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                facultyEditForm.ShowDialog();
                updateFromDataBase();
                updateTable();
            }
            if (e.ColumnIndex == 4)
            {
                using (CourseWorkContext context = new CourseWorkContext())
                {
                    Faculty faculty = context.Faculties.FirstOrDefault(el =>
                        el.Id.ToString().ToLower() == facultyTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower());
                    if (faculty != null)
                    {
                        string facultyId = faculty.Id.ToString();
                        context.Faculties.Remove(faculty);
                        context.SaveChanges();
                        updateFromDataBase();
                        updateTable();
                        List<String> specialitiesId = new List<String>();
                        List<String> specialitiesCodes = new List<String>();
                        foreach (Speciality speciality in context.Specialities.Where(e => e.FacultyId == facultyId).ToList())
                        {
                            specialitiesId.Add(speciality.Id.ToString());
                            specialitiesCodes.Add(speciality.SpecialityCode);
                            context.Specialities.Remove(speciality);
                            context.SaveChanges();
                        }
                        List<String> studentsId = new List<String>();
                        foreach (string specialityCode in specialitiesCodes)
                        {
                            foreach (Student student in context.Students.Where(e => e.SpecialityCode == specialityCode).ToList())
                            {
                                studentsId.Add(student.Id.ToString());
                                context.Students.Remove(student);
                                context.SaveChanges();
                            }
                        }
                        foreach (string specialityID in specialitiesId)
                        {
                            foreach (Subject subject in context.Subjects.Where(e => e.SpecialityID == specialityID).ToList())
                            {
                                context.Subjects.Remove(subject);
                                context.SaveChanges();
                            }
                        }
                        foreach (string studentId in studentsId)
                        {
                            foreach (Exam exam in context.Exams.Where(e => e.IdStudent == studentId).ToList())
                            {
                                context.Exams.Remove(exam);
                                context.SaveChanges();
                            }
                        }
                    }
                }
            }
        }
    }
}
