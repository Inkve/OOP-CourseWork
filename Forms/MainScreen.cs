using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;
using System.Runtime.InteropServices;

namespace CourseWork_With_SQLite.Forms
{
    public partial class MainScreen : Form
    {
        private IEnumerable<Student> students;
        private IEnumerable<Speciality> specialities;
        private IEnumerable<Faculty> faculties;
        private IEnumerable<Exam> exams;
        private IEnumerable<Subject> subjects;

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

        private void facultiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.ShowDialog();
        }

        private void specialitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialityForm specialityForm = new SpecialityForm();
            specialityForm.ShowDialog();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectForm = new SubjectsForm();
            subjectForm.ShowDialog();
        }

        private void examensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamenForm examenForm = new ExamenForm();
            examenForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            faculties = context.Faculties.AsEnumerable();
            students= context.Students.AsEnumerable();
            exams = context.Exams.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
        }

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

        private void updateTable()
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
                facultiesIdForTable.Add(faculties.Where(e => e.Name == FacultyDecesion).First().Id.ToString());
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
                specialitiesIdForTable.Add(tempSpecialities.Where(e => e.SpecialityCode == SpecialityDecesion).First().SpecialityCode.ToString());
                if (specialitiesIdForTable.Count == 0)
                {
                    throw new Exception("Выбор текущего факультета и специальности недопустим!");
                }
            }

            List<Student> tempStudents = new List<Student>();
            foreach (string specialityCode in specialitiesIdForTable) 
            {
                tempStudents.AddRange(students.Where(e => e.SpecialityCode == specialityCode).ToList());
                specialityCodeToFacultyName.Add(specialityCode, faculties.Where(c => c.Id.ToString() == specialities.Where(e => e.SpecialityCode == specialityCode).First().FacultyId).First().Name);
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
                examTable.Rows[counter].Cells[5].Value = subjects.Where(e => e.Id.ToString() == exam.IdSubject).First().ToString();
                examTable.Rows[counter].Cells[6].Value = exam.Score;
                counter++;
            }
        }

        private void updateVariants(object sender, EventArgs e)
        {
            updateSemesterVariants();
            updateFacultyVariants();
            updateSpecialityVariants();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateSemesterInputAfterFacultiesInput(object sender, EventArgs e)
        {
            updateSpecialityVariants();
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            specialityInput.Text = "Все";
            semesterInput.Text = "Все";
            facultyInput.Text = "Все";
            updateTable();
        }


    }
}
