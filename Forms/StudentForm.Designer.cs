namespace CourseWork_With_SQLite.Forms
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.showStudentsGroupBox = new System.Windows.Forms.GroupBox();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStudentsGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.groupInput = new System.Windows.Forms.TextBox();
            this.birthdayInput = new System.Windows.Forms.DateTimePicker();
            this.semesterInput = new System.Windows.Forms.NumericUpDown();
            this.budgetInput = new System.Windows.Forms.CheckBox();
            this.patronymicInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.specialityInput = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.showStudentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.addStudentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // showStudentsGroupBox
            // 
            this.showStudentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showStudentsGroupBox.Controls.Add(this.studentTable);
            this.showStudentsGroupBox.Location = new System.Drawing.Point(15, 18);
            this.showStudentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.showStudentsGroupBox.Name = "showStudentsGroupBox";
            this.showStudentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.showStudentsGroupBox.Size = new System.Drawing.Size(884, 572);
            this.showStudentsGroupBox.TabIndex = 0;
            this.showStudentsGroupBox.TabStop = false;
            this.showStudentsGroupBox.Text = "Просмотр студентов";
            // 
            // studentTable
            // 
            this.studentTable.AllowUserToAddRows = false;
            this.studentTable.AllowUserToDeleteRows = false;
            this.studentTable.AllowUserToResizeColumns = false;
            this.studentTable.AllowUserToResizeRows = false;
            this.studentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.studentName,
            this.specialityName,
            this.Group,
            this.Edit,
            this.Delete});
            this.studentTable.Location = new System.Drawing.Point(7, 29);
            this.studentTable.MultiSelect = false;
            this.studentTable.Name = "studentTable";
            this.studentTable.ReadOnly = true;
            this.studentTable.RowHeadersVisible = false;
            this.studentTable.RowTemplate.Height = 25;
            this.studentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentTable.ShowCellToolTips = false;
            this.studentTable.Size = new System.Drawing.Size(870, 537);
            this.studentTable.TabIndex = 50;
            this.studentTable.TabStop = false;
            this.studentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellContentClick);
            this.studentTable.SelectionChanged += new System.EventHandler(this.selectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.FillWeight = 50F;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentName.FillWeight = 200F;
            this.studentName.HeaderText = "ФИО";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // specialityName
            // 
            this.specialityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialityName.HeaderText = "Специальность";
            this.specialityName.Name = "specialityName";
            this.specialityName.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Group.FillWeight = 50F;
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = " ";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 33;
            // 
            // Delete
            // 
            this.Delete.HeaderText = " ";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 33;
            // 
            // addStudentsGroupBox
            // 
            this.addStudentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudentsGroupBox.Controls.Add(this.addButton);
            this.addStudentsGroupBox.Controls.Add(this.groupInput);
            this.addStudentsGroupBox.Controls.Add(this.birthdayInput);
            this.addStudentsGroupBox.Controls.Add(this.semesterInput);
            this.addStudentsGroupBox.Controls.Add(this.budgetInput);
            this.addStudentsGroupBox.Controls.Add(this.patronymicInput);
            this.addStudentsGroupBox.Controls.Add(this.nameInput);
            this.addStudentsGroupBox.Controls.Add(this.surnameInput);
            this.addStudentsGroupBox.Controls.Add(this.specialityInput);
            this.addStudentsGroupBox.Controls.Add(this.groupLabel);
            this.addStudentsGroupBox.Controls.Add(this.specialityLabel);
            this.addStudentsGroupBox.Controls.Add(this.semesterLabel);
            this.addStudentsGroupBox.Controls.Add(this.budgetLabel);
            this.addStudentsGroupBox.Controls.Add(this.birthdayLabel);
            this.addStudentsGroupBox.Controls.Add(this.patronymicLabel);
            this.addStudentsGroupBox.Controls.Add(this.nameLabel);
            this.addStudentsGroupBox.Controls.Add(this.surnameLabel);
            this.addStudentsGroupBox.Location = new System.Drawing.Point(907, 18);
            this.addStudentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.addStudentsGroupBox.Name = "addStudentsGroupBox";
            this.addStudentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.addStudentsGroupBox.Size = new System.Drawing.Size(241, 517);
            this.addStudentsGroupBox.TabIndex = 1;
            this.addStudentsGroupBox.TabStop = false;
            this.addStudentsGroupBox.Text = "Добавление студента";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Beige;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(66, 471);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 35);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupInput
            // 
            this.groupInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupInput.Location = new System.Drawing.Point(7, 429);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(227, 29);
            this.groupInput.TabIndex = 8;
            // 
            // birthdayInput
            // 
            this.birthdayInput.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.birthdayInput.Location = new System.Drawing.Point(7, 222);
            this.birthdayInput.Name = "birthdayInput";
            this.birthdayInput.Size = new System.Drawing.Size(227, 29);
            this.birthdayInput.TabIndex = 4;
            // 
            // semesterInput
            // 
            this.semesterInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.semesterInput.Location = new System.Drawing.Point(8, 314);
            this.semesterInput.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.semesterInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.semesterInput.Name = "semesterInput";
            this.semesterInput.Size = new System.Drawing.Size(226, 29);
            this.semesterInput.TabIndex = 6;
            this.semesterInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // budgetInput
            // 
            this.budgetInput.AutoSize = true;
            this.budgetInput.Location = new System.Drawing.Point(125, 258);
            this.budgetInput.Name = "budgetInput";
            this.budgetInput.Size = new System.Drawing.Size(49, 26);
            this.budgetInput.TabIndex = 5;
            this.budgetInput.Text = "Да";
            this.budgetInput.UseVisualStyleBackColor = true;
            // 
            // patronymicInput
            // 
            this.patronymicInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.patronymicInput.Location = new System.Drawing.Point(7, 165);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(227, 29);
            this.patronymicInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameInput.Location = new System.Drawing.Point(7, 108);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(227, 29);
            this.nameInput.TabIndex = 2;
            // 
            // surnameInput
            // 
            this.surnameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.surnameInput.Location = new System.Drawing.Point(7, 51);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(227, 29);
            this.surnameInput.TabIndex = 1;
            // 
            // specialityInput
            // 
            this.specialityInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialityInput.FormattingEnabled = true;
            this.specialityInput.Location = new System.Drawing.Point(8, 371);
            this.specialityInput.Name = "specialityInput";
            this.specialityInput.Size = new System.Drawing.Size(226, 30);
            this.specialityInput.TabIndex = 7;
            this.specialityInput.Click += new System.EventHandler(this.updateVariants);
            this.specialityInput.Enter += new System.EventHandler(this.updateVariants);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupLabel.Location = new System.Drawing.Point(28, 404);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(68, 22);
            this.groupLabel.TabIndex = 7;
            this.groupLabel.Text = "Группа";
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(28, 346);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(176, 22);
            this.specialityLabel.TabIndex = 6;
            this.specialityLabel.Text = "Код специальности";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(28, 289);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(163, 22);
            this.semesterLabel.TabIndex = 5;
            this.semesterLabel.Text = "Семестр обучения";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.budgetLabel.Location = new System.Drawing.Point(19, 260);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(110, 22);
            this.budgetLabel.TabIndex = 4;
            this.budgetLabel.Text = "Бюджетник";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.Location = new System.Drawing.Point(19, 197);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(141, 22);
            this.birthdayLabel.TabIndex = 3;
            this.birthdayLabel.Text = "Дата рождения";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patronymicLabel.Location = new System.Drawing.Point(19, 140);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(88, 22);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(19, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(19, 26);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(91, 22);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Фамилия";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1028, 548);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 36);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1157, 596);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addStudentsGroupBox);
            this.Controls.Add(this.showStudentsGroupBox);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(987, 635);
            this.Name = "StudentForm";
            this.Text = "Студенты";
            this.showStudentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.addStudentsGroupBox.ResumeLayout(false);
            this.addStudentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox showStudentsGroupBox;
        private GroupBox addStudentsGroupBox;
        private Label groupLabel;
        private Label specialityLabel;
        private Label semesterLabel;
        private Label budgetLabel;
        private Label birthdayLabel;
        private Label patronymicLabel;
        private Label nameLabel;
        private Label surnameLabel;
        private TextBox groupInput;
        private DateTimePicker birthdayInput;
        private NumericUpDown semesterInput;
        private CheckBox budgetInput;
        private TextBox patronymicInput;
        private TextBox nameInput;
        private TextBox surnameInput;
        private ComboBox specialityInput;
        private DataGridView studentTable;
        private Button addButton;
        private Button exitButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn specialityName;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
    }
}