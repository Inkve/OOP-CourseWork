using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;
using System.Runtime.InteropServices;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для реализации формы Студенты
    /// </summary>
    public partial class StudentForm : Form
    {
        /// <summary>
        /// Поле для хранения списка студентов
        /// </summary>
        private IEnumerable<Student> students;

        /// <summary>
        /// Поле для хранения списка специальностей
        /// </summary>
        private IEnumerable<Speciality> specialities;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public StudentForm()
        {
            InitializeComponent();
            updateTable();
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
        /// Метод нажатия на кнопку Добавить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            string _surname = surnameInput.Text;
            string _name = nameInput.Text;
            string _patronymic = patronymicInput.Text;
            DateTime _birhday = DateTime.Parse(birthdayInput.Text);
            bool _budget = budgetInput.Checked;
            int _semester = int.Parse(semesterInput.Text);
            string _speciality = specialityInput.Text;
            string _group = groupInput.Text;

            try
            {
                if (!string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_patronymic)
                && !string.IsNullOrEmpty(_speciality) && !string.IsNullOrEmpty(_group))
                {
                    CourseWorkContext context = new CourseWorkContext();
                    students = context.Students.AsEnumerable();
                    if (students.Where(e => e.Surname == _surname && e.Name == _name && e.Patronymic == _patronymic
                          && e.SpecialityCode == _speciality && e.BirthdayDate.Year == _birhday.Year &&
                            e.BirthdayDate.Month == _birhday.Month && e.BirthdayDate.Day == _birhday.Day).FirstOrDefault() != null)
                    {
                        throw new Exception("Такой студент уже существует!");
                    }
                    if (DateTime.Now.Year - _birhday.Year < 16)
                    {
                        throw new Exception("Студенту должно быть как минимум 16 лет!");
                    }
                    Classes.Student temp = new Classes.Student(_surname, _name, _patronymic, _birhday, _budget, _semester, _speciality, _group);
                    temp.AddInDataBase();
                    updateTable();

                    surnameInput.Text = "";
                    nameInput.Text = "";
                    patronymicInput.Text = "";
                    birthdayInput.Text = DateTime.Now.ToString();
                    budgetInput.Checked = false;
                    semesterInput.Value = 1;
                    specialityInput.Text = "";
                    groupInput.Text = "";
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
        /// Метод обновления таблицы
        /// </summary>
        private void updateTable()
        {
            studentTable.RowCount = 0;
            CourseWorkContext context = new CourseWorkContext();
            students = context.Students.AsEnumerable();
            if (students.Count() > 0)
            {

                studentTable.RowCount = students.Count();
                int counter = 0;
                foreach (Student student in students)
                {
                    studentTable.Rows[counter].Cells[0].Value = student.Id.ToString();
                    studentTable.Rows[counter].Cells[1].Value = counter + 1;
                    studentTable.Rows[counter].Cells[2].Value = student.ToString();
                    studentTable.Rows[counter].Cells[3].Value = student.SpecialityCode;
                    studentTable.Rows[counter].Cells[4].Value = student.Group;
                    studentTable.Rows[counter].Cells[5].Value = "⚙";
                    studentTable.Rows[counter].Cells[6].Value = "🗑";
                    counter++;
                }
            }
        }

        /// <summary>
        /// Метод обновления вариантов
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void updateVariants(object sender, EventArgs e)
        {
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            specialityInput.Items.Clear();
            foreach (Speciality speciality in specialities)
            {
                specialityInput.Items.Add(speciality.SpecialityCode);
            }
        }

        /// <summary>
        /// Метод изменения выделения таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void selectionChanged(object sender, EventArgs e)
        {
            studentTable.ClearSelection();
        }

        /// <summary>
        /// Метод нажатия на ячейку таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void studentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                StudentEditForm studentEditForm = new StudentEditForm(studentTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                studentEditForm.ShowDialog();
                updateTable();
            }
            if (e.ColumnIndex == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить выбранную запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (CourseWorkContext context = new CourseWorkContext())
                    {
                        Student student = context.Students.FirstOrDefault(el => el.Id.ToString().ToLower() == studentTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower());
                        if (student != null)
                        {
                            String studentId = student.Id.ToString();
                            context.Students.Remove(student);
                            context.SaveChanges();
                            foreach (Exam exam in context.Exams.Where(e => e.IdStudent == studentId).ToList())
                            {
                                context.Exams.Remove(exam);
                                context.SaveChanges();
                            }
                        }
                        updateTable();
                    }
                }
            }
        }
    }
}
