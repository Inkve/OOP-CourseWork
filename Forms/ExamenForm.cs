﻿using CourseWork_With_SQLite.Classes;
using CourseWork_With_SQLite.Context;
using System.Runtime.InteropServices;

namespace CourseWork_With_SQLite.Forms
{
    public partial class ExamenForm : Form
    {
        private IEnumerable<Student> students;
        private IEnumerable<Speciality> specialities;
        private IEnumerable<Subject> subjects;
        private IEnumerable<Exam> exams;
        public ExamenForm()
        {
            updateFromBataBase();
            InitializeComponent();
            updateSemesterOption();
            updateSpecialityOption();
            studentInput.Enabled = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task updateFromBataBase()
        {
            CourseWorkContext context = new CourseWorkContext();
            specialities = context.Specialities.AsEnumerable();
            students = context.Students.AsEnumerable();
            subjects = context.Subjects.AsEnumerable();
            exams = context.Exams.AsEnumerable();
        }

        private void updateSpecialityOption()
        {
            string currentDicision = specialityInput.Text;
            specialityInput.Items.Clear();
            foreach (Speciality speciality in specialities)
            {
                specialityInput.Items.Add(speciality.SpecialityCode);
            }
            specialityInput.Text = currentDicision;
            if (!string.IsNullOrEmpty(currentDicision))
            {
                subjectInput.Text = "";
                updateSubjectOption();
            }
        }

        private void updateSemesterOption()
        {
            string currentDicision = semesterInput.Text;
            semesterInput.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                semesterInput.Items.Add(i.ToString() + " семестр");
            }
            semesterInput.Text = currentDicision;
        }

        private void specialityInput_Enter(object sender, EventArgs e)
        {
            updateSpecialityOption();
            updateStudentOption();
        }

        private void updateSubjectOption()
        {   
            string currentDecision = subjectInput.Text;
            string currentSpecialityDicision = specialityInput.Text;
            string currentSpecialityId = specialities.Where(c => c.SpecialityCode == currentSpecialityDicision).First().Id.ToString();
            List<Subject> tempSubject = new List<Subject>();
            tempSubject = subjects.Where(e => e.SpecialityID.ToLower() == currentSpecialityId.ToLower()).ToList();
            subjectInput.Items.Clear();
            foreach (Subject subject in tempSubject)
            {
                subjectInput.Items.Add(subject.Name);
            }
            subjectInput.Text = currentDecision;
            if (!string.IsNullOrEmpty(currentDecision))
            {
                updateSemesterOption();
                updateStudentOption();
            }
        }

        private void updateStudentOption()
        {
            string specialityDecision = specialityInput.Text;
            string subjectDecision = subjectInput.Text;
            int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
            if (!string.IsNullOrEmpty(specialityDecision) && !string.IsNullOrEmpty(subjectDecision) && !(semesterDecision == 0))
            {
                studentInput.Enabled = true;
                string specialityCode = specialities.Where(c => c.SpecialityCode == specialityDecision).First().SpecialityCode.ToString();
                List<Student> studentsForOption = new List<Student>();
                studentsForOption = students.Where(e => e.SpecialityCode == specialityCode).ToList();
                studentInput.Items.Clear();
                foreach (Student student in studentsForOption)
                {
                    studentInput.Items.Add(student.ToString());
                }
            }
            else
            {
                studentInput.Enabled = false;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showTable();
        }

        private void showTable()
        {
            updateStudentOption();
            string specialityDecision = specialityInput.Text;
            string subjectDecision = subjectInput.Text;
            int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
            try
            {
                if (!string.IsNullOrEmpty(specialityDecision) && !string.IsNullOrEmpty(subjectDecision) && !(semesterDecision == 0))
                {
                    try
                    {
                        string specialityId = specialities.Where(c => c.SpecialityCode == specialityDecision).First().Id.ToString();
                        string subjectId = subjects.Where(e => e.SpecialityID.ToLower() == specialityId.ToLower() && e.Name == subjectDecision).First().Id.ToString();
                        List<Exam> sutableExams = new List<Exam>();
                        sutableExams = exams.Where(e => e.IdSubject.ToLower() == subjectId && e.Semester == semesterDecision).ToList();
                        int counter = 0;
                        examTable.Rows.Clear();
                        foreach (Exam exam in sutableExams)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            examTable.Rows.Add(row);
                            examTable.Rows[counter].Cells[0].Value = exam.Id.ToString();
                            examTable.Rows[counter].Cells[1].Value = students.Where(e => e.Id.ToString() == exam.IdStudent).First().ToString();
                            examTable.Rows[counter].Cells[2].Value = subjects.Where(e => e.Id.ToString() == exam.IdSubject).First().ToString();
                            examTable.Rows[counter].Cells[3].Value = exam.Semester;
                            examTable.Rows[counter].Cells[4].Value = exam.Score;
                            examTable.Rows[counter].Cells[5].Value = "⚙";
                            examTable.Rows[counter].Cells[6].Value = "🗑";
                            counter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Не все опции заполнены!");
                }
            }
            catch (Exception ex)
            {
                [DllImport("user32.dll", CharSet = CharSet.Unicode)]
                static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            string specialityDecision = specialityInput.Text;
            string subjectDecision = subjectInput.Text;
            int.TryParse(semesterInput.Text.Split()[0], out int semesterDecision);
            try
            {
                if (!string.IsNullOrEmpty(specialityDecision) && !string.IsNullOrEmpty(subjectDecision) && !(semesterDecision == 0) && !string.IsNullOrEmpty(studentInput.Text))
                {
                    try
                    {
                        string specialityId = specialities.Where(c => c.SpecialityCode == specialityDecision).First().Id.ToString();
                        string subjectId = subjects.Where(e => e.SpecialityID.ToLower() == specialityId.ToLower() && e.Name == subjectDecision).First().Id.ToString();
                        int.TryParse(scoreInput.Text.Split()[0], out int scoreDecision);
                        string specialityCode = specialities.Where(c => c.SpecialityCode == specialityDecision).First().SpecialityCode.ToString();
                        string studentId = students.Where(e => e.SpecialityCode == specialityCode && e.ToString() == studentInput.Text).First().Id.ToString();
                        Exam temp = new Exam(studentId, subjectId, semesterDecision, scoreDecision);
                        temp.AddInDataBase();
                        await updateFromBataBase();
                        showTable();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Не все опции заполнены!");
                }
            }
            catch (Exception ex)
            {
                [DllImport("user32.dll", CharSet = CharSet.Unicode)]
                static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
            }
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            examTable.ClearSelection();
        }
    }

}