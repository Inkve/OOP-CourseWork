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
    public partial class SpecialityFormEdit : Form
    {
        private IEnumerable<Speciality> specialities;
        private Speciality currentSpeciality;

        public SpecialityFormEdit(string Id)
        {
            InitializeComponent();
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            currentSpeciality = specialities.FirstOrDefault(e => e.Id.ToString().ToLower() == Id.ToLower());
            String facultyName = context.Faculties.First(e => e.Id.ToString().ToLower() == currentSpeciality.FacultyId.ToLower()).Name;
            facultyInput.Items.Add(facultyName);
            facultyInput.Text = facultyName;
            specialityCodeInput.Text = currentSpeciality.SpecialityCode;
            specialityNameInput.Text = currentSpeciality.Name.ToString(); 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (CourseWorkContext context = new CourseWorkContext())
            {
                Speciality speciality = context.Specialities.FirstOrDefault(e => e.Id == currentSpeciality.Id);
                if (speciality != null)
                {
                    speciality.Name = specialityNameInput.Text;
                    context.SaveChanges();
                }
            }
        }
    }
}
