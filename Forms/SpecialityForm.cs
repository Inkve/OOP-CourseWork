using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

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
            if (!string.IsNullOrEmpty(_facultyName) && !string.IsNullOrEmpty(_specialityCode) && !string.IsNullOrEmpty(_specialityName)) 
            {
                Faculty temp_faculty = (faculties.Where(e => e.Name == _facultyName)).AsEnumerable().First();
                Speciality temp = new Speciality(_specialityCode, _specialityName, temp_faculty.Id.ToString());
                temp.AddInDataBase();
                await updateFromDataBase();
                facultyInput.Text = "";
                specialityCodeInput.Text = "";
                specialityNameInput.Text = "";
            }
            updateTable();
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

        //private void updateFacultyList(object sender, KeyPressEventArgs e)
        //{

        //}
    }
}
