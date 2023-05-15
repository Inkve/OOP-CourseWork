using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;
using System.Runtime.InteropServices;
using IronXL;

namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс для реализации формы главного окна
    /// </summary>
    public partial class MainScreen : Form
    {
        /// <summary>
        /// Поле для хранения списка студентов
        /// </summary>
        private IEnumerable<Student> students;

        /// <summary>
        /// Поле для хранения спика специальностей
        /// </summary>
        private IEnumerable<Speciality> specialities;

        /// <summary>
        /// Поле для хранения списка факультетов
        /// </summary>
        private IEnumerable<Faculty> faculties;

        /// <summary>
        /// Поле для хранения экзаменов
        /// </summary>
        private IEnumerable<Exam> exams;

        /// <summary>
        /// Поле для хранения списка дисциплин
        /// </summary>
        private IEnumerable<Subject> subjects;

        /// <summary>
        /// Поле для хранения пути сохранения
        /// </summary>
        private String? PATH;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainScreen()
        {
            updateFromDataBase();
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            InitializeComponent();
            updateSemesterVariants();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на меню Факультеты
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void facultiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.ShowDialog();
            updateFromDataBase();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на меню Специальности
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void specialitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialityForm specialityForm = new SpecialityForm();
            specialityForm.ShowDialog();
            updateFromDataBase();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на меню Студенты
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            updateFromDataBase();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на меню Дисциплины
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectForm = new SubjectsForm();
            subjectForm.ShowDialog();
            updateFromDataBase();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на меню Экзамены
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void examensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamenForm examenForm = new ExamenForm();
            examenForm.ShowDialog();
            updateFromDataBase();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод нажатия на меню О программе
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            updateFromDataBase();
            updateFacultyVariants();
            updateSpecialityVariants();
            updateTable();
        }

        /// <summary>
        /// Метод обновления информации
        /// </summary>
        /// <returns> Task </returns>
        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            faculties = context.Faculties.AsEnumerable();
            students= context.Students.AsEnumerable();
            exams = context.Exams.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
        }

        /// <summary>
        /// Метод обновления вариантов Семестр
        /// </summary>
        private void updateSemesterVariants()
        {
            string currentDicision = string.IsNullOrEmpty(semesterInput.Text) ? "Все" : semesterInput.Text;
            semesterInput.Items.Clear();
            semesterInput.Items.Add("Все");
            for (int i = 1; i <= 12; i++) 
            {
                semesterInput.Items.Add(i.ToString() + " семестр");
            }
            semesterInput.Text = currentDicision;
        }

        /// <summary>
        /// Метод обновления вариантов Факультет
        /// </summary>
        private void updateFacultyVariants()
        {
            string currentDicision = string.IsNullOrEmpty(facultyInput.Text) ?  "Все" : facultyInput.Text;
            facultyInput.Items.Clear();
            facultyInput.Items.Add("Все");
            foreach (Faculty faculty in faculties)
            {
                facultyInput.Items.Add(faculty.Name);
            }
            facultyInput.Text = currentDicision;
        }

        /// <summary>
        /// Метод обновления вариантов Специальность
        /// </summary>
        private void updateSpecialityVariants()
        {
            string currentFacultyDicision = facultyInput.Text;
            if (currentFacultyDicision == "Все")
            {
                string currentDicision = string.IsNullOrEmpty(specialityInput.Text) ? "Все" : specialityInput.Text;
                specialityInput.Items.Clear();
                specialityInput.Items.Add("Все");
                foreach (Speciality speciality in specialities)
                {
                    specialityInput.Items.Add(speciality.SpecialityCode);
                }
                specialityInput.Text = currentDicision;
            }
            else
            {
                IEnumerable<Speciality> tempSpecialities = specialities.Where(e => e.FacultyId == faculties.Where(e => e.Name == currentFacultyDicision).First().Id.ToString()).ToList();
                string currentDicision = string.IsNullOrEmpty(specialityInput.Text) ? "Все" : specialityInput.Text;
                specialityInput.Items.Clear();
                specialityInput.Items.Add("Все");
                foreach (Speciality speciality in tempSpecialities)
                {
                    specialityInput.Items.Add(speciality.SpecialityCode);
                }
                specialityInput.Text = "Все";
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку применить
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateTable();
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
            try
            {
                string SemesterDecesion = semesterInput.Text;
                string FacultyDecesion = facultyInput.Text;
                string SpecialityDecesion = specialityInput.Text;
                Dictionary<string, string> specialityCodeToFacultyName = new Dictionary<string, string>();

                List<Speciality> tempSpecialities = new List<Speciality>(); ;
                List<string> facultiesIdForTable = new List<string>();
                if (FacultyDecesion == "Все")
                {
                    foreach (Faculty faculty in faculties)
                    {
                        facultiesIdForTable.Add(faculty.Id.ToString());
                        tempSpecialities = specialities.ToList();
                    }
                }
                else
                {
                    facultiesIdForTable.Add(faculties.FirstOrDefault(e => e.Name == FacultyDecesion).Id.ToString());
                    try
                    {
                        tempSpecialities = specialities.Where(e => e.FacultyId == facultiesIdForTable[0]).ToList();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Выбор текущего факультета и специальности недопустим!");
                    }
                }

                List<string> specialitiesIdForTable = new List<string>();
                if (SpecialityDecesion == "Все")
                {

                    foreach (Speciality speciality in tempSpecialities)
                    {
                        specialitiesIdForTable.Add(speciality.SpecialityCode);
                    }
                }
                else
                {
                    specialitiesIdForTable.Add(tempSpecialities.FirstOrDefault(e => e.SpecialityCode == SpecialityDecesion).SpecialityCode.ToString());
                    if (specialitiesIdForTable.Count == 0)
                    {
                        throw new Exception("Выбор текущего факультета и специальности недопустим!");
                    }
                }

                List<Student> tempStudents = new List<Student>();
                foreach (string specialityCode in specialitiesIdForTable)
                {
                    tempStudents.AddRange(students.Where(e => e.SpecialityCode == specialityCode).ToList());
                    var facultyName = faculties.FirstOrDefault(c =>
                        c.Id.ToString() == specialities.FirstOrDefault(e
                            => e.SpecialityCode == specialityCode).FacultyId).Name;
                    if (facultyName != null)
                        specialityCodeToFacultyName.Add(specialityCode, facultyName);
                }

                List<Exam> tempExams = new List<Exam>();
                if (semesterInput.Text == "Все")
                {
                    for (int semesterDecision = 1; semesterDecision <= 12; semesterDecision++)
                    {
                        foreach (Student student in tempStudents)
                        {
                            try
                            {
                                tempExams.AddRange(exams.Where(e => e.Semester == semesterDecision && e.IdStudent == student.Id.ToString()));
                            }
                            catch (Exception e)
                            {
                                // Так делать нельзя, НО
                            }
                        }
                    }
                }
                else
                {
                    int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
                    foreach (Student student in tempStudents)
                    {
                        try
                        {
                            tempExams.AddRange(exams.Where(e => e.Semester == semesterDecision && e.IdStudent == student.Id.ToString()));
                        }
                        catch (Exception e)
                        {
                            // Так делать нельзя, НО
                        }
                    }
                }

                examTable.RowCount = 0;
                int counter = 0;
                foreach (Exam exam in tempExams)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    examTable.Rows.Add(row);
                    Student student = students.Where(e => e.Id.ToString() == exam.IdStudent).First();
                    examTable.Rows[counter].Cells[0].Value = exam.Id.ToString();
                    examTable.Rows[counter].Cells[1].Value = specialityCodeToFacultyName[student.SpecialityCode];
                    examTable.Rows[counter].Cells[2].Value = student.SpecialityCode;
                    examTable.Rows[counter].Cells[3].Value = student.ToString();
                    examTable.Rows[counter].Cells[4].Value = exam.Semester;
                    examTable.Rows[counter].Cells[5].Value = subjects.FirstOrDefault(e => e.Id.ToString() == exam.IdSubject).ToString();
                    examTable.Rows[counter].Cells[6].Value = exam.Score;
                    counter++;
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
        /// Метод обновления вариантов опций
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void updateVariants(object sender, EventArgs e)
        {
            updateSemesterVariants();
            updateFacultyVariants();
            updateSpecialityVariants();
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
        /// Метод при выделении ячеек таблицы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void selectionChanged(object sender, EventArgs e)
        {
            examTable.ClearSelection();
        }

        /// <summary>
        /// Метод обновления вариантов Специальность
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void updateSemesterInputAfterFacultiesInput(object sender, EventArgs e)
        {
            updateSpecialityVariants();
        }

        /// <summary>
        /// Метод очистки фильтров
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            specialityInput.Text = "Все";
            semesterInput.Text = "Все";
            facultyInput.Text = "Все";
            updateTable();
        }

        /// <summary>
        /// Метод создания отчетов
        /// </summary>
        /// <param name="SemesterDecesion">Выбор семестра</param>
        /// <param name="FacultyDecesion">Выбор факультета</param>
        /// <param name="SpecialityDecesion">Выбор специальности</param>
        /// <returns>Task</returns>
        private async Task generateExcel(String SemesterDecesion, String FacultyDecesion, String SpecialityDecesion)
        {
            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
            try
            {
                WorkBook workBook = WorkBook.Create(ExcelFileFormat.XLSX);
                var workSheet = workBook.CreateWorkSheet("Отчет");
                workSheet["A1"].Value = "Отчет по успеваемости студентов";
                workSheet["A2"].Value = "Параметры отчета:";
                workSheet["A3"].Value = "Семестр:";
                workSheet["B3"].Value = SemesterDecesion;
                workSheet["A4"].Value = "Факультет:";
                workSheet["B4"].Value = FacultyDecesion;
                workSheet["A5"].Value = "Специальность:";
                workSheet["B5"].Value = SpecialityDecesion;
                workSheet["A6"].Value = "Дата генерации:";
                workSheet["B6"].Value = DateTime.Now;
                workSheet["A1:B6"].Style.Font.Bold = true;

                workSheet["A8"].Value = "Факультет";
                workSheet["B8"].Value = "Специальность";
                workSheet["C8"].Value = "ФИО";
                workSheet["D8"].Value = "Семестр";
                workSheet["E8"].Value = "Дисциплина";
                workSheet["F8"].Value = "Оценка";
                workSheet["A8:F8"].Style.Font.Bold = true;

                Dictionary<string, string> specialityCodeToFacultyName = new Dictionary<string, string>();

                List<Speciality> tempSpecialities = new List<Speciality>(); ;
                List<string> facultiesIdForTable = new List<string>();
                if (FacultyDecesion == "Все")
                {
                    foreach (Faculty faculty in faculties)
                    {
                        facultiesIdForTable.Add(faculty.Id.ToString());
                        tempSpecialities = specialities.ToList();
                    }
                }
                else
                {
                    facultiesIdForTable.Add(faculties.FirstOrDefault(e => e.Name == FacultyDecesion).Id.ToString());
                    try
                    {
                        tempSpecialities = specialities.Where(e => e.FacultyId == facultiesIdForTable[0]).ToList();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Выбор текущего факультета и специальности недопустим!");
                    }
                }

                List<string> specialitiesIdForTable = new List<string>();
                if (SpecialityDecesion == "Все")
                {

                    foreach (Speciality speciality in tempSpecialities)
                    {
                        specialitiesIdForTable.Add(speciality.SpecialityCode);
                    }
                }
                else
                {
                    specialitiesIdForTable.Add(tempSpecialities.FirstOrDefault(e => e.SpecialityCode == SpecialityDecesion).SpecialityCode.ToString());
                    if (specialitiesIdForTable.Count == 0)
                    {
                        throw new Exception("Выбор текущего факультета и специальности недопустим!");
                    }
                }

                List<Student> tempStudents = new List<Student>();
                foreach (string specialityCode in specialitiesIdForTable)
                {
                    tempStudents.AddRange(students.Where(e => e.SpecialityCode == specialityCode).ToList());
                    var facultyName = faculties.FirstOrDefault(c =>
                        c.Id.ToString() == specialities.FirstOrDefault(e
                            => e.SpecialityCode == specialityCode).FacultyId).Name;
                    if (facultyName != null)
                        specialityCodeToFacultyName.Add(specialityCode, facultyName);
                }

                List<Exam> tempExams = new List<Exam>();
                if (SemesterDecesion == "Все")
                {
                    for (int semesterDecision = 1; semesterDecision <= 12; semesterDecision++)
                    {
                        foreach (Student student in tempStudents)
                        {
                            try
                            {
                                tempExams.AddRange(exams.Where(e => e.Semester == semesterDecision && e.IdStudent == student.Id.ToString()));
                            }
                            catch (Exception e)
                            {
                                // Так делать нельзя, НО
                            }
                        }
                    }
                }
                else
                {
                    int.TryParse(SemesterDecesion.Split()[0], out int semesterDecision);
                    foreach (Student student in tempStudents)
                    {
                        try
                        {
                            tempExams.AddRange(exams.Where(e => e.Semester == semesterDecision && e.IdStudent == student.Id.ToString()));
                        }
                        catch (Exception e)
                        {
                            // Так делать нельзя, НО
                        }
                    }
                }

                int counter = 0;
                foreach (Exam exam in tempExams)
                {
                    Student student = students.Where(e => e.Id.ToString() == exam.IdStudent).First();
                    workSheet["A" + (counter + 9).ToString()].Value = specialityCodeToFacultyName[student.SpecialityCode];
                    String specialityName = student.SpecialityCode + " - " + specialities.First(e => e.SpecialityCode == student.SpecialityCode).Name;
                    workSheet["B" + (counter + 9).ToString()].Value = specialityName;
                    workSheet["C" + (counter + 9).ToString()].Value = student.ToString();
                    workSheet["D" + (counter + 9).ToString()].Value = exam.Semester;
                    workSheet["E" + (counter + 9).ToString()].Value = subjects.FirstOrDefault(e => e.Id.ToString() == exam.IdSubject).ToString();
                    workSheet["F" + (counter + 9).ToString()].Value = exam.Score;
                    counter++;
                }

                if (PATH != null)
                {
                    workBook.SaveAs(PATH.ToString());
                    MessageBox(IntPtr.Zero, "Отчет успешно сохранен в выбранное раннее место!", "Сообщение", 0);
                    PATH = null;
                }
                else
                {
                    workBook.SaveAs("report_" + DateTime.Now.ToString().Split()[0] + "_" + DateTime.Now.Hour.ToString()
                        + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".xlsx");
                    MessageBox(IntPtr.Zero, "Отчет успешно сохранен в папку с приложением!", "Сообщение", 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
            }
        }

        /// <summary>
        /// Метод нажатия на меню Создать отчет
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private async void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SemesterDecesion = semesterInput.Text;
            string FacultyDecesion = facultyInput.Text;
            string SpecialityDecesion = specialityInput.Text;
            await Task.Run(() => generateExcel(SemesterDecesion, FacultyDecesion, SpecialityDecesion));
        }

        /// <summary>
        /// Метод нажатия на меню выбрать путь сохранения
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Лист Microsoft Excel|*.xlsx";
            saveFileDialog1.Title = "Сохраните Excel файл";
            saveFileDialog1.ShowDialog();
            PATH = @saveFileDialog1.FileName;
        }
    }
}
