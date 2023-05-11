using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;

namespace CourseWork_With_SQLite.Forms
{
    public partial class ExamenEditForm : Form
    {
        private IEnumerable<Student> students;
        private IEnumerable<Subject> subjects;
        private IEnumerable<Exam> exams;
        private Exam currentExam;

        public ExamenEditForm(string id)
        {
            CourseWorkContext context = new CourseWorkContext();
            students = context.Students.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
            exams = context.Exams.AsEnumerable();
            currentExam = exams.FirstOrDefault(e => e.Id.ToString() == id);
            InitializeComponent();
            updateInformation();
        }

        private void updateInformation()
        { 
            subjectInput.Items.Add(subjects.FirstOrDefault(e => e.Id.ToString() == currentExam.IdSubject).ToString());
            subjectInput.Text = subjectInput.Items[0].ToString();
            semesterInput.Items.Add(currentExam.Semester.ToString());
            semesterInput.Text = semesterInput.Items[0].ToString();
            studentInput.Items.Add(students.FirstOrDefault(e => e.Id.ToString() == currentExam.IdStudent).ToString()); 
            studentInput.Text = studentInput.Items[0].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Exam exam = context.Exams.FirstOrDefault(e => e.Id == currentExam.Id);
                if (exam != null)
                {
                    exam.Score = (int)scoreInput.Value;
                    context.SaveChanges();
                }
            }
        }
    }
}
