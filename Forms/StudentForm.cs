using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    public partial class StudentForm : Form
    {
        private IEnumerable<Student> students;
        private IEnumerable<Speciality> specialities;

        public StudentForm()
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
            string _surname = surnameInput.Text;
            string _name = nameInput.Text;
            string _patronymic = patronymicInput.Text;
            DateTime _birhday = DateTime.Parse(birthdayInput.Text);
            bool _budget = budgetInput.Checked;
            int _semester = int.Parse(semesterInput.Text);
            string _speciality = specialityInput.Text;
            string _group = groupInput.Text;

            if (!string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_patronymic)
                && !string.IsNullOrEmpty(_speciality) && !string.IsNullOrEmpty(_group))
            {
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
        }

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

        private void selectionChanged(object sender, EventArgs e)
        {
            studentTable.ClearSelection();
        }

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
                //using (CourseWorkContext context = new CourseWorkContext())
                //{
                //    Speciality speciality = context.Specialities.FirstOrDefault(el => el.Id.ToString().ToLower() == specialityTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower());
                //    if (speciality != null)
                //    {
                //        String specialityId = speciality.Id.ToString();
                //        String specialityCode = speciality.SpecialityCode;
                //        context.Specialities.Remove(speciality);
                //        context.SaveChanges();
                //        List<String> studentsId = new List<String>();
                //        foreach (Student student in context.Students.Where(e => e.SpecialityCode == specialityCode).ToList())
                //        {
                //            studentsId.Add(student.Id.ToString());
                //            context.Students.Remove(student);
                //            context.SaveChanges();
                //        }
                //        foreach (Subject subject in context.Subjects.Where(e => e.SpecialityID == specialityId).ToList())
                //        {
                //            context.Subjects.Remove(subject);
                //            context.SaveChanges();
                //        }
                //        foreach (string studentId in studentsId)
                //        {
                //            foreach (Exam exam in context.Exams.Where(e => e.IdStudent == studentId).ToList())
                //            {
                //                context.Exams.Remove(exam);
                //                context.SaveChanges();
                //            }
                //        }
                //    }
                updateTable();
            }
        }
    }
}
