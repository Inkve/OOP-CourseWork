﻿using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Data;
using System.Runtime.InteropServices;

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
            try
            {
                if (!string.IsNullOrEmpty(_speciality) && !string.IsNullOrEmpty(_name))
                {
                    Speciality temp_speciality = (specialities.Where(e => e.SpecialityCode == _speciality)).AsEnumerable().First();
                    if (subjects.FirstOrDefault(e => e.SpecialityID.ToString().ToLower() == temp_speciality.Id.ToString().ToLower() && e.Name == _name) != null)
                    {
                        throw new Exception("Такая дисциплина уже существует!");
                    }
                    Subject temp = new Subject(temp_speciality.Id.ToString(), _name);
                    temp.AddInDataBase();
                    specialityInput.Text = "";
                    nameInput.Text = "";
                    updateTable();
                }
                else
                {
                    throw new Exception("Не все опции заполнены!");
                }
            }
            catch(Exception ex)
            {
                [DllImport("user32.dll", CharSet = CharSet.Unicode)]
                static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
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

        private void subjectTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                SubjectEditForm subjectEditForm = new SubjectEditForm(subjectTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                subjectEditForm.ShowDialog();
                updateFromDataBase();
                updateTable();
            }
            if (e.ColumnIndex == 5)
            {
                using (CourseWorkContext context = new CourseWorkContext())
                {
                    Subject subject = context.Subjects.FirstOrDefault(el => el.Id.ToString().ToLower() == subjectTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower());
                    if (subject != null)
                    {
                        String subjectId = subjectTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                        context.Subjects.Remove(subject);
                        context.SaveChanges();
                        foreach (Exam exam in context.Exams.Where(e => e.IdSubject == subjectId).ToList())
                        {
                            context.Exams.Remove(exam);
                            context.SaveChanges();
                        }
                    }
                    updateFromDataBase();
                    updateTable();
                }
            }
        }
    }
}