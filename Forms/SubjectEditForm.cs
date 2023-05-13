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
    public partial class SubjectEditForm : Form
    {
        private IEnumerable<Subject> subjects;
        private Subject currentSubject;
        public SubjectEditForm(String Id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            subjects = context.Subjects.AsEnumerable();
            currentSubject = subjects.FirstOrDefault(e => e.Id.ToString().ToLower() == Id.ToLower());
            String specialityCode = context.Specialities.First(e => e.Id.ToString().ToLower() == currentSubject.SpecialityID.ToLower()).SpecialityCode;
            specialityInput.Items.Add(specialityCode);
            specialityInput.Text = specialityCode;
            nameInput.Text = currentSubject.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Subject subject = context.Subjects.FirstOrDefault(e => e.Id == currentSubject.Id);
                if (subject != null)
                {
                    subject.Name = nameInput.Text;
                    context.SaveChanges();
                }
            }
        }
    }
}
