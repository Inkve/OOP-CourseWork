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
    public partial class FacultyEditForm : Form
    {
        private IEnumerable<Faculty> faculties;
        private Faculty currentFaculty;
        public FacultyEditForm(string id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            faculties = context.Faculties.AsEnumerable();
            currentFaculty = faculties.FirstOrDefault(e => e.Id.ToString() == id);
            nameInput.Text = currentFaculty.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Faculty faculty = context.Faculties.FirstOrDefault(e => e.Id == currentFaculty.Id);
                if (faculty != null)
                {
                    faculty.Name = nameInput.Text;
                    context.SaveChanges();
                }
            }
        }
    }
}
