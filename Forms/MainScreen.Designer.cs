namespace CourseWork_With_SQLite.Forms
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.specialityInput = new System.Windows.Forms.ComboBox();
            this.facultyInput = new System.Windows.Forms.ComboBox();
            this.semesterInput = new System.Windows.Forms.ComboBox();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.examTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            this.showGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.добавлениеToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1270, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.generateToolStripMenuItem.Text = "Генерация отчета с текущими параметрами";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // добавлениеToolStripMenuItem
            // 
            this.добавлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultiesToolStripMenuItem,
            this.specialitiesToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.examensToolStripMenuItem});
            this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
            this.добавлениеToolStripMenuItem.Text = "Добавление";
            // 
            // facultiesToolStripMenuItem
            // 
            this.facultiesToolStripMenuItem.Name = "facultiesToolStripMenuItem";
            this.facultiesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.facultiesToolStripMenuItem.Text = "Факультеты";
            this.facultiesToolStripMenuItem.Click += new System.EventHandler(this.facultiesToolStripMenuItem_Click);
            // 
            // specialitiesToolStripMenuItem
            // 
            this.specialitiesToolStripMenuItem.Name = "specialitiesToolStripMenuItem";
            this.specialitiesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.specialitiesToolStripMenuItem.Text = "Специальности";
            this.specialitiesToolStripMenuItem.Click += new System.EventHandler(this.specialitiesToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.studentsToolStripMenuItem.Text = "Студенты";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.subjectsToolStripMenuItem.Text = "Предметы";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // examensToolStripMenuItem
            // 
            this.examensToolStripMenuItem.Name = "examensToolStripMenuItem";
            this.examensToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.examensToolStripMenuItem.Text = "Экзамены";
            this.examensToolStripMenuItem.Click += new System.EventHandler(this.examensToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.AboutToolStripMenuItem.Text = "Справка";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersGroupBox.Controls.Add(this.applyButton);
            this.filtersGroupBox.Controls.Add(this.clearFilterButton);
            this.filtersGroupBox.Controls.Add(this.specialityLabel);
            this.filtersGroupBox.Controls.Add(this.facultyLabel);
            this.filtersGroupBox.Controls.Add(this.semesterLabel);
            this.filtersGroupBox.Controls.Add(this.specialityInput);
            this.filtersGroupBox.Controls.Add(this.facultyInput);
            this.filtersGroupBox.Controls.Add(this.semesterInput);
            this.filtersGroupBox.Location = new System.Drawing.Point(1002, 28);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(268, 258);
            this.filtersGroupBox.TabIndex = 1;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Фильтры";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Beige;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(142, 213);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(120, 32);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.BackColor = System.Drawing.Color.Beige;
            this.clearFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearFilterButton.Location = new System.Drawing.Point(9, 213);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(120, 32);
            this.clearFilterButton.TabIndex = 3;
            this.clearFilterButton.Text = "Очистить";
            this.clearFilterButton.UseVisualStyleBackColor = false;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(24, 141);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(140, 22);
            this.specialityLabel.TabIndex = 5;
            this.specialityLabel.Text = "Специальность";
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facultyLabel.Location = new System.Drawing.Point(24, 83);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(100, 22);
            this.facultyLabel.TabIndex = 4;
            this.facultyLabel.Text = "Факультет";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(24, 25);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(79, 22);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Семестр";
            // 
            // specialityInput
            // 
            this.specialityInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialityInput.FormattingEnabled = true;
            this.specialityInput.Location = new System.Drawing.Point(9, 166);
            this.specialityInput.Name = "specialityInput";
            this.specialityInput.Size = new System.Drawing.Size(253, 30);
            this.specialityInput.TabIndex = 2;
            // 
            // facultyInput
            // 
            this.facultyInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.facultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultyInput.FormattingEnabled = true;
            this.facultyInput.Location = new System.Drawing.Point(9, 108);
            this.facultyInput.Name = "facultyInput";
            this.facultyInput.Size = new System.Drawing.Size(253, 30);
            this.facultyInput.TabIndex = 1;
            this.facultyInput.Leave += new System.EventHandler(this.updateSemesterInputAfterFacultiesInput);
            // 
            // semesterInput
            // 
            this.semesterInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.semesterInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.semesterInput.FormattingEnabled = true;
            this.semesterInput.Location = new System.Drawing.Point(9, 50);
            this.semesterInput.Name = "semesterInput";
            this.semesterInput.Size = new System.Drawing.Size(253, 30);
            this.semesterInput.TabIndex = 0;
            // 
            // showGroupBox
            // 
            this.showGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showGroupBox.Controls.Add(this.examTable);
            this.showGroupBox.Location = new System.Drawing.Point(12, 28);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Size = new System.Drawing.Size(984, 305);
            this.showGroupBox.TabIndex = 2;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Просмотр успеваемости";
            // 
            // examTable
            // 
            this.examTable.AllowUserToAddRows = false;
            this.examTable.AllowUserToDeleteRows = false;
            this.examTable.AllowUserToResizeColumns = false;
            this.examTable.AllowUserToResizeRows = false;
            this.examTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.examTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.examTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.examTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Faculty,
            this.Speciality,
            this.StudentName,
            this.Semester,
            this.Subject,
            this.Score});
            this.examTable.GridColor = System.Drawing.Color.Yellow;
            this.examTable.Location = new System.Drawing.Point(6, 25);
            this.examTable.MultiSelect = false;
            this.examTable.Name = "examTable";
            this.examTable.RowHeadersVisible = false;
            this.examTable.RowTemplate.Height = 25;
            this.examTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.examTable.ShowCellErrors = false;
            this.examTable.ShowCellToolTips = false;
            this.examTable.ShowEditingIcon = false;
            this.examTable.ShowRowErrors = false;
            this.examTable.Size = new System.Drawing.Size(972, 274);
            this.examTable.TabIndex = 50;
            this.examTable.TabStop = false;
            this.examTable.SelectionChanged += new System.EventHandler(this.selectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Faculty
            // 
            this.Faculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Faculty.HeaderText = "Факультет";
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // Speciality
            // 
            this.Speciality.HeaderText = "Специальность";
            this.Speciality.Name = "Speciality";
            this.Speciality.ReadOnly = true;
            this.Speciality.Width = 130;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.FillWeight = 200F;
            this.StudentName.HeaderText = "ФИО";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.FillWeight = 50F;
            this.Semester.HeaderText = "Семестр";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.Width = 80;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Дисциплина";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.FillWeight = 45F;
            this.Score.HeaderText = "Оценка";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 70;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1138, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 32);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1270, 340);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1090, 379);
            this.Name = "MainScreen";
            this.Text = "Успеваемость студентов -  КП 21ВП2 Левин А. А.";
            this.Enter += new System.EventHandler(this.updateVariants);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            this.showGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem facultiesToolStripMenuItem;
        private ToolStripMenuItem specialitiesToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem subjectsToolStripMenuItem;
        private GroupBox filtersGroupBox;
        private Button applyButton;
        private Button clearFilterButton;
        private Label specialityLabel;
        private Label facultyLabel;
        private Label semesterLabel;
        private ComboBox specialityInput;
        private ComboBox facultyInput;
        private ComboBox semesterInput;
        private GroupBox showGroupBox;
        private Button exitButton;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private DataGridView examTable;
        private ToolStripMenuItem examensToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Faculty;
        private DataGridViewTextBoxColumn Speciality;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Score;
        private ToolStripMenuItem generateToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
    }
}