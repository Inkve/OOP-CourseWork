using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace CourseWork_With_SQLite.Forms
{
    public partial class SpecialityForm : Form
    {
        private IEnumerable<Faculty> faculties;
        private IEnumerable<Speciality> specialities;
        public SpecialityForm()
        {
            updateFromDataBase();
            InitializeComponent();
            updateTable();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            string _facultyName = facultyInput.Text;
            string _specialityCode = specialityCodeInput.Text;
            string _specialityName = specialityNameInput.Text;
            try
            {
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

        private void selectionChanged(object sender, EventArgs e)
        {
            specialityTable.ClearSelection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
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

        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            faculties = context.Faculties.AsEnumerable();
            specialities = context.Specialities.AsEnumerable();
        }

        private void updateFacultyList(object sender, EventArgs e)
        {
            facultyInput.Items.Clear();
            foreach (Faculty fac in faculties)
            {
                facultyInput.Items.Add(fac.Name);
            }
        }

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
