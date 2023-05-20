using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Runtime.InteropServices;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс формы с экзаменом
    /// </summary>
    public partial class ExamenForm : Form
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
        /// Поле для хранения списка дисциплин
        /// </summary>
        private IEnumerable<Subject> subjects;

        /// <summary>
        /// Поле для хранения экзаменов
        /// </summary>
        private IEnumerable<Exam> exams;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ExamenForm()
        {
            updateFromDataBase();
            InitializeComponent();
            updateSemesterOption();
            updateSpecialityOption();
            studentInput.Enabled = false;
            scoreInput.Enabled = false;
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
        /// Метод обновления информации
        /// </summary>
        /// <returns> Task</returns>
        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            students = context.Students.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
            exams = context.Exams.AsEnumerable();
        }

        /// <summary>
        /// Метод обновления опций специальностей
        /// </summary>
        private void updateSpecialityOption()
        {
            string currentDicision = specialityInput.Text;
            specialityInput.Items.Clear();
            foreach (Speciality speciality in specialities)
            {
                specialityInput.Items.Add(speciality.SpecialityCode);
            }
            if (specialities.Count() == 1)
            {
                specialityInput.SelectedIndex = 0;
            }
            if (currentDicision != "")
            {
                specialityInput.Text = currentDicision;
            }
            updateSubjectOption();
        }

        /// <summary>
        /// Метод обновления опций семестров
        /// </summary>
        private void updateSemesterOption()
        {
            string currentDicision = semesterInput.Text;
            semesterInput.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                semesterInput.Items.Add(i.ToString() + " семестр");
            }
            if (currentDicision != "")
            {
                semesterInput.Text = currentDicision;
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку Применить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void specialityInput_Enter(object sender, EventArgs e)
        {
            updateSpecialityOption();
            updateStudentOption();
        }

        /// <summary>
        /// Метод обновления опций Дисциплины
        /// </summary>
        private void updateSubjectOption()
        {   
            string currentDecision = subjectInput.Text;
            string currentSpecialityDicision = specialityInput.Text;
            if (currentSpecialityDicision != "")
            {
                string currentSpecialityId = specialities.Where(c => c.SpecialityCode == currentSpecialityDicision).First().Id.ToString();
                List<Subject> tempSubject = new List<Subject>();
                tempSubject = subjects.Where(e => e.SpecialityID.ToLower() == currentSpecialityId.ToLower()).ToList();
                subjectInput.Items.Clear();
                foreach (Subject subject in tempSubject)
                {
                    subjectInput.Items.Add(subject.Name);
                }
                if (tempSubject.Count() == 1)
                {
                    subjectInput.SelectedIndex = 0;
                }

                if (currentDecision != "")
                {
                    subjectInput.Text = currentDecision;
                }

                if (!string.IsNullOrEmpty(currentDecision))
                {
                    updateSemesterOption();
                    updateStudentOption();
                }
            }
        }

        /// <summary>
        /// Метод обновления опций Студенты
        /// </summary>
        private void updateStudentOption()
        {
            string specialityDecision = specialityInput.Text;
            string subjectDecision = subjectInput.Text;
            int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
            if (!string.IsNullOrEmpty(specialityDecision) && !string.IsNullOrEmpty(subjectDecision) && !(semesterDecision == 0))
            {
                studentInput.Enabled = true;
                scoreInput.Enabled = true;
                string specialityCode = specialities.Where(c => c.SpecialityCode == specialityDecision).First().SpecialityCode.ToString();
                List<Student> studentsForOption = new List<Student>();
                studentsForOption = students.Where(e => e.SpecialityCode == specialityCode).ToList();
                studentInput.Items.Clear();
                foreach (Student student in studentsForOption)
                {
                    studentInput.Items.Add(student.ToString());
                }
                if (studentsForOption.Count() == 1)
                {
                    studentInput.SelectedIndex = 0;
                }
            }
            else
            {
                studentInput.Enabled = false;
                scoreInput.Enabled = false;
            }
        }

        /// <summary>
        /// Метод нажатия кнопки Добавить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void showButton_Click(object sender, EventArgs e)
        {
            showTable();
        }

        /// <summary>
        /// Метод обновления таблицы
        /// </summary>
        private void showTable()
        {
            updateStudentOption();
            string specialityDecision = specialityInput.Text;
            string subjectDecision = subjectInput.Text;
            int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
            try
            {
                if (!string.IsNullOrEmpty(specialityDecision) && !string.IsNullOrEmpty(subjectDecision) && !(semesterDecision == 0))
                {
                    try
                    {
                        string specialityId = specialities.Where(c => c.SpecialityCode == specialityDecision).First().Id.ToString();
                        string subjectId = subjects.Where(e => e.SpecialityID.ToLower() == specialityId.ToLower() && e.Name == subjectDecision).First().Id.ToString();
                        List<Exam> sutableExams = new List<Exam>();
                        sutableExams = exams.Where(e => e.IdSubject.ToLower() == subjectId && e.Semester == semesterDecision).ToList();
                        int counter = 0;
                        examTable.Rows.Clear();
                        foreach (Exam exam in sutableExams)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            examTable.Rows.Add(row);
                            examTable.Rows[counter].Cells[0].Value = exam.Id.ToString();
                            examTable.Rows[counter].Cells[1].Value = students.Where(e => e.Id.ToString() == exam.IdStudent).First().ToString();
                            examTable.Rows[counter].Cells[2].Value = subjects.Where(e => e.Id.ToString() == exam.IdSubject).First().ToString();
                            examTable.Rows[counter].Cells[3].Value = exam.Semester;
                            examTable.Rows[counter].Cells[4].Value = exam.Score;
                            examTable.Rows[counter].Cells[5].Value = "⚙";
                            examTable.Rows[counter].Cells[6].Value = "🗑";
                            counter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
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
        /// Метод нажатия кнопки Добавить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private async void addButton_Click(object sender, EventArgs e)
        {
            string specialityDecision = specialityInput.Text;
            string subjectDecision = subjectInput.Text;
            int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
            try
            {
                if (!string.IsNullOrEmpty(specialityDecision) && !string.IsNullOrEmpty(subjectDecision) && !(semesterDecision == 0) && !string.IsNullOrEmpty(studentInput.Text))
                {
                    try
                    {
                        string specialityId = specialities.Where(c => c.SpecialityCode == specialityDecision).First().Id.ToString();
                        string subjectId = subjects.Where(e => e.SpecialityID.ToLower() == specialityId.ToLower() && e.Name == subjectDecision).First().Id.ToString();
                        int.TryParse(scoreInput.Text.Split()[0], out int scoreDecision);
                        string specialityCode = specialities.Where(c => c.SpecialityCode == specialityDecision).First().SpecialityCode.ToString();
                        string studentId = students.Where(e => e.SpecialityCode == specialityCode && e.ToString() == studentInput.Text).First().Id.ToString();
                        if (exams.FirstOrDefault(e => 
                            e.IdStudent == studentId && e.IdSubject == subjectId && e.Semester == semesterDecision) != null)
                        {
                            throw new Exception("Результаты этого студента были добавлены раннее!");
                        }
                        if (students.Where(e => e.SpecialityCode == specialityCode && e.ToString() == studentInput.Text).First().SemesterOfStudy <  semesterDecision)
                        {
                            throw new Exception("Текущему студенту нельзя поставить оценку за этот предмет! (Семестр обучения студента меньше семестра проведения экзамена)");
                        }
                        Exam temp = new Exam(studentId, subjectId, semesterDecision, scoreDecision);
                        temp.AddInDataBase();
                        await updateFromDataBase();
                        showTable();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
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
        /// Метод изменения выделения
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void selectionChanged(object sender, EventArgs e)
        {
            examTable.ClearSelection();
        }

        /// <summary>
        /// Метод нажатия на ячейки таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void examTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) 
            {
                ExamenEditForm examenEditForm = new ExamenEditForm(examTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                examenEditForm.ShowDialog();
                updateFromDataBase();
                showTable();
            }
            if (e.ColumnIndex == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить выбранную запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (CourseWorkContext context = new CourseWorkContext())
                    {
                        Exam exam = context.Exams.FirstOrDefault(el =>
                            el.Id.ToString().ToLower() == examTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower());
                        if (exam != null)
                        {
                            context.Exams.Remove(exam);
                            context.SaveChanges();
                            updateFromDataBase();
                            showTable();
                        }
                    }
                }
            }
        }

        private void specialityInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectInput.Items.Clear();
            updateSubjectOption();
            studentInput.Enabled = false;
            scoreInput.Enabled = false;
        }
    }
}
