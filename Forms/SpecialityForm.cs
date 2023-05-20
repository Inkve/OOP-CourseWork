using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для реализации формы Специальностей
    /// </summary>
    public partial class SpecialityForm : Form
    {
        /// <summary>
        /// Поле для хранения списка факультетов
        /// </summary>
        private IEnumerable<Faculty> faculties;

        /// <summary>
        /// Поле для хранения списка специальностей
        /// </summary>
        private IEnumerable<Speciality> specialities;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SpecialityForm()
        {
            updateFromDataBase();
            InitializeComponent();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на кнопку Добавить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>

        private async void addButton_Click(object sender, EventArgs e)
        {
            string _facultyName = facultyInput.Text;
            string _specialityCode = specialityCodeInput.Text;
            string _specialityName = specialityNameInput.Text;
            try
            {
                Regex regex = new Regex(@"\d{2}.\d{2}.\d{2}");
                if (regex.Matches(_specialityCode).Count == 0) 
                {
                    throw new Exception("Введите специальность в формате 'XX.XX.XX' !");
                }
                if (!string.IsNullOrEmpty(_facultyName) && !string.IsNullOrEmpty(_specialityCode) && !string.IsNullOrEmpty(_specialityName))
                {
                    if (specialities.FirstOrDefault(e => e.SpecialityCode == _specialityCode) != null)
                    {
                        throw new Exception("Специальность с текущим кодом уже существует!");
                    }
                    Faculty temp_faculty = (faculties.Where(e => e.Name == _facultyName)).AsEnumerable().First();
                    Speciality temp = new Speciality(_specialityCode, _specialityName, temp_faculty.Id.ToString());
                    temp.AddInDataBase();
                    await updateFromDataBase();
                    facultyInput.Text = "";
                    specialityCodeInput.Text = "";
                    specialityNameInput.Text = "";
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
            updateTable();
        }

        /// <summary>
        /// Метод выделения ячейки таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void selectionChanged(object sender, EventArgs e)
        {
            specialityTable.ClearSelection();
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
        /// Метод обновления таблицы
        /// </summary>
        private void updateTable()
        {
            specialityTable.RowCount = 0;
            if (specialities.Count() > 0)
            {

                specialityTable.RowCount = specialities.Count();
                int counter = 0;
                foreach (Speciality speciality in specialities)
                {
                    specialityTable.Rows[counter].Cells[0].Value = speciality.Id.ToString();
                    specialityTable.Rows[counter].Cells[1].Value = counter + 1;
                    Faculty temp_faculty = (faculties.Where(e => e.Id.ToString() == speciality.FacultyId)).AsEnumerable().First();
                    specialityTable.Rows[counter].Cells[2].Value = temp_faculty.Name;
                    specialityTable.Rows[counter].Cells[3].Value = speciality.SpecialityCode;
                    specialityTable.Rows[counter].Cells[4].Value = speciality.Name;
                    specialityTable.Rows[counter].Cells[5].Value = "⚙";
                    specialityTable.Rows[counter].Cells[6].Value = "🗑";
                    counter++;
                }
            }
        }


        /// <summary>
        /// Метод обновления информации с базы данных
        /// </summary>
        /// <returns>Task</returns>
        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            faculties = context.Faculties.AsEnumerable();
            specialities = context.Specialities.AsEnumerable();
        }

        /// <summary>
        /// Метод обновления вариантов Факультет
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void updateFacultyList(object sender, EventArgs e)
        {
            facultyInput.Items.Clear();
            foreach (Faculty fac in faculties)
            {
                facultyInput.Items.Add(fac.Name);
            }
        }

        /// <summary>
        /// Метод нажатия на ячейки таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void specialityTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                SpecialityFormEdit specialityFormEdit = new SpecialityFormEdit(specialityTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                specialityFormEdit.ShowDialog();
                updateFromDataBase();
                updateTable();
            }
            if (e.ColumnIndex == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить выбранную запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (CourseWorkContext context = new CourseWorkContext())
                    {
                        Speciality speciality = context.Specialities.FirstOrDefault(el => el.Id.ToString().ToLower() == specialityTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower());
                        if (speciality != null)
                        {
                            String specialityId = speciality.Id.ToString();
                            String specialityCode = speciality.SpecialityCode;
                            context.Specialities.Remove(speciality);
                            context.SaveChanges();
                            List<String> studentsId = new List<String>();
                            foreach (Student student in context.Students.Where(e => e.SpecialityCode == specialityCode).ToList())
                            {
                                studentsId.Add(student.Id.ToString());
                                context.Students.Remove(student);
                                context.SaveChanges();
                            }
                            foreach (Subject subject in context.Subjects.Where(e => e.SpecialityID == specialityId).ToList())
                            {
                                context.Subjects.Remove(subject);
                                context.SaveChanges();
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
                        updateFromDataBase();
                        updateTable();
                    }
                }
            }
        }
    }
}
