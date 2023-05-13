using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_With_SQLite.Forms
{
    public partial class StudentEditForm : Form
    {
        private IEnumerable<Student> students;
        private Student currentStudent;
        public StudentEditForm(String Id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            students = context.Students.AsEnumerable();
            currentStudent = students.FirstOrDefault(e => e.Id.ToString().ToLower() == Id.ToLower());
            surnameInput.Text = currentStudent.Surname;
            nameInput.Text = currentStudent.Name;
            patronymicInput.Text = currentStudent.Patronymic;
            budgetInput.Checked = currentStudent.Budget;
            semesterInput.Value = currentStudent.SemesterOfStudy;
            groupInput.Text = currentStudent.Group;
            specialityInput.Items.Add(currentStudent.SpecialityCode);
            specialityInput.Text = currentStudent.SpecialityCode;
            birthdayInput.Text = currentStudent.BirthdayDate.ToString(); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Student student = context.Students.FirstOrDefault(e => e.Id == currentStudent.Id);
                if (student != null)
                {
                    student.Surname = surnameInput.Text;
                    student.Name = nameInput.Text;
                    student.Patronymic = patronymicInput.Text;
                    student.Budget = budgetInput.Checked;
                    student.SemesterOfStudy = (int) semesterInput.Value;
                    context.SaveChanges();
                }
            }
        }
    }
}
