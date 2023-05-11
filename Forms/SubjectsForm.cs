using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    public partial class SubjectsForm : Form
    {
        private IEnumerable<Subject> subjects;
        private IEnumerable<Speciality> specialities;
        public SubjectsForm()
        {
            InitializeComponent();
            updateTable();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string _speciality = specialityInput.Text;
            string _name = nameInput.Text;
            if (!string.IsNullOrEmpty(_speciality) && !string.IsNullOrEmpty(_name)) 
            {
                Speciality temp_speciality = (specialities.Where(e => e.SpecialityCode == _speciality)).AsEnumerable().First();
                Subject temp = new Subject(temp_speciality.Id.ToString(), _name);
                temp.AddInDataBase();

                specialityInput.Text = "";
                nameInput.Text = "";
                updateTable();
            }
        }

        private async void updateTable()
        {
            await updateFromDataBase();
            subjectTable.RowCount = 0;
            if (subjects.Count() > 0)
            {
                subjectTable.RowCount = subjects.Count();
                int counter = 0;
                foreach (Subject subject in subjects)
                {
                    Speciality temp_speciality = (specialities.Where(e => e.Id.ToString().ToLower() == subject.SpecialityID.ToLower())).AsEnumerable().First();
                    subjectTable.Rows[counter].Cells[0].Value = subject.Id.ToString();
                    subjectTable.Rows[counter].Cells[1].Value = counter + 1;
                    subjectTable.Rows[counter].Cells[2].Value = temp_speciality.SpecialityCode;
                    subjectTable.Rows[counter].Cells[3].Value = subject.ToString();
                    subjectTable.Rows[counter].Cells[4].Value = "⚙";
                    subjectTable.Rows[counter].Cells[5].Value = "🗑";
                    counter++;
                }
            }
        }

        private async void updateVariants(object sender, EventArgs e)
        {
            // await updateFromDataBase();
            specialityInput.Items.Clear();
            foreach (Speciality speciality in specialities)
            {
                specialityInput.Items.Add(speciality.SpecialityCode);
            }
        }

        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            subjectTable.ClearSelection();
        }
    }
}
