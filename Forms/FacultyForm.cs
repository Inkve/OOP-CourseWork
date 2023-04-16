using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;

namespace CourseWork_With_SQLite
{
    public partial class FacultyForm : Form
    {
        private IEnumerable<Faculty> faculties;
        public FacultyForm()
        {
            InitializeComponent();
            updateTable();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void updateTable()
        {
            await updateFromDataBase();
            facultyDataGridView.RowCount = 0;
            facultyDataGridView.RowCount = faculties.Count();
            int counter = 0;
            foreach (Faculty faculty in faculties)
            {
                facultyDataGridView.Rows[counter].Cells[0].Value = faculty.Id.ToString();
                facultyDataGridView.Rows[counter].Cells[1].Value = counter + 1;
                facultyDataGridView.Rows[counter].Cells[2].Value = faculty.Name;
                facultyDataGridView.Rows[counter].Cells[3].Value = "⚙";
                facultyDataGridView.Rows[counter].Cells[4].Value = "🗑";
                counter++;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string _name = nameInput.Text;
            if (!string.IsNullOrEmpty(_name))
            {
                Faculty temp = new Faculty(_name);
                temp.AddInDataBase();
                updateTable();
                nameInput.Text = "";
            }
        }

        private async Task updateFromDataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            faculties = context.Faculties.AsEnumerable();
        }

        private void facultyDataGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //throw new Exception(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());
        }
    }
}
