namespace CourseWork_With_SQLite.Forms
{
    partial class ExamenForm
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
            this.redactorViewGroupBox = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.semesterInput = new System.Windows.Forms.ComboBox();
            this.subjectInput = new System.Windows.Forms.ComboBox();
            this.specialityInput = new System.Windows.Forms.ComboBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.addingNewGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.scoreInput = new System.Windows.Forms.NumericUpDown();
            this.studentInput = new System.Windows.Forms.ComboBox();
            this.showAllGroupBox = new System.Windows.Forms.GroupBox();
            this.examTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.redactorViewGroupBox.SuspendLayout();
            this.addingNewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreInput)).BeginInit();
            this.showAllGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examTable)).BeginInit();
            this.SuspendLayout();
            // 
            // redactorViewGroupBox
            // 
            this.redactorViewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redactorViewGroupBox.Controls.Add(this.showButton);
            this.redactorViewGroupBox.Controls.Add(this.semesterInput);
            this.redactorViewGroupBox.Controls.Add(this.subjectInput);
            this.redactorViewGroupBox.Controls.Add(this.specialityInput);
            this.redactorViewGroupBox.Controls.Add(this.subjectLabel);
            this.redactorViewGroupBox.Controls.Add(this.specialityLabel);
            this.redactorViewGroupBox.Controls.Add(this.semesterLabel);
            this.redactorViewGroupBox.Location = new System.Drawing.Point(1001, 12);
            this.redactorViewGroupBox.Name = "redactorViewGroupBox";
            this.redactorViewGroupBox.Size = new System.Drawing.Size(257, 255);
            this.redactorViewGroupBox.TabIndex = 0;
            this.redactorViewGroupBox.TabStop = false;
            this.redactorViewGroupBox.Text = "Редактирование просмотра";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Beige;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showButton.Location = new System.Drawing.Point(70, 205);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(114, 38);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Применить";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // semesterInput
            // 
            this.semesterInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.semesterInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.semesterInput.FormattingEnabled = true;
            this.semesterInput.Location = new System.Drawing.Point(6, 169);
            this.semesterInput.Name = "semesterInput";
            this.semesterInput.Size = new System.Drawing.Size(242, 30);
            this.semesterInput.TabIndex = 2;
            // 
            // subjectInput
            // 
            this.subjectInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectInput.FormattingEnabled = true;
            this.subjectInput.Location = new System.Drawing.Point(6, 111);
            this.subjectInput.Name = "subjectInput";
            this.subjectInput.Size = new System.Drawing.Size(242, 30);
            this.subjectInput.TabIndex = 1;
            this.subjectInput.Enter += new System.EventHandler(this.specialityInput_Enter);
            // 
            // specialityInput
            // 
            this.specialityInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialityInput.FormattingEnabled = true;
            this.specialityInput.Location = new System.Drawing.Point(6, 53);
            this.specialityInput.Name = "specialityInput";
            this.specialityInput.Size = new System.Drawing.Size(242, 30);
            this.specialityInput.TabIndex = 0;
            this.specialityInput.Click += new System.EventHandler(this.specialityInput_Enter);
            this.specialityInput.MouseCaptureChanged += new System.EventHandler(this.specialityInput_Enter);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLabel.Location = new System.Drawing.Point(31, 86);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(84, 22);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Предмет";
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(31, 28);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(140, 22);
            this.specialityLabel.TabIndex = 0;
            this.specialityLabel.Text = "Специальность";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(31, 144);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(79, 22);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Семестр";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentLabel.Location = new System.Drawing.Point(31, 25);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(78, 22);
            this.studentLabel.TabIndex = 2;
            this.studentLabel.Text = "Студент";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(31, 83);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(74, 22);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Оценка";
            // 
            // addingNewGroupBox
            // 
            this.addingNewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addingNewGroupBox.Controls.Add(this.addButton);
            this.addingNewGroupBox.Controls.Add(this.scoreInput);
            this.addingNewGroupBox.Controls.Add(this.studentInput);
            this.addingNewGroupBox.Controls.Add(this.studentLabel);
            this.addingNewGroupBox.Controls.Add(this.scoreLabel);
            this.addingNewGroupBox.Location = new System.Drawing.Point(1001, 273);
            this.addingNewGroupBox.Name = "addingNewGroupBox";
            this.addingNewGroupBox.Size = new System.Drawing.Size(257, 191);
            this.addingNewGroupBox.TabIndex = 5;
            this.addingNewGroupBox.TabStop = false;
            this.addingNewGroupBox.Text = "Добавление результата";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Beige;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(70, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 38);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // scoreInput
            // 
            this.scoreInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreInput.Location = new System.Drawing.Point(6, 108);
            this.scoreInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scoreInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(242, 25);
            this.scoreInput.TabIndex = 5;
            this.scoreInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // studentInput
            // 
            this.studentInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.studentInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentInput.FormattingEnabled = true;
            this.studentInput.Location = new System.Drawing.Point(6, 50);
            this.studentInput.Name = "studentInput";
            this.studentInput.Size = new System.Drawing.Size(242, 30);
            this.studentInput.TabIndex = 4;
            // 
            // showAllGroupBox
            // 
            this.showAllGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllGroupBox.Controls.Add(this.examTable);
            this.showAllGroupBox.Location = new System.Drawing.Point(12, 12);
            this.showAllGroupBox.Name = "showAllGroupBox";
            this.showAllGroupBox.Size = new System.Drawing.Size(983, 501);
            this.showAllGroupBox.TabIndex = 6;
            this.showAllGroupBox.TabStop = false;
            this.showAllGroupBox.Text = "Просмотр экзаменов";
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
            this.examTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.studentName,
            this.subjectName,
            this.semester,
            this.score,
            this.edit,
            this.delete});
            this.examTable.Location = new System.Drawing.Point(6, 28);
            this.examTable.MultiSelect = false;
            this.examTable.Name = "examTable";
            this.examTable.ReadOnly = true;
            this.examTable.RowHeadersVisible = false;
            this.examTable.RowTemplate.Height = 25;
            this.examTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.examTable.ShowCellErrors = false;
            this.examTable.ShowCellToolTips = false;
            this.examTable.ShowEditingIcon = false;
            this.examTable.ShowRowErrors = false;
            this.examTable.Size = new System.Drawing.Size(971, 467);
            this.examTable.TabIndex = 50;
            this.examTable.TabStop = false;
            this.examTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examTable_CellContentClick);
            this.examTable.SelectionChanged += new System.EventHandler(this.selectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentName.FillWeight = 200F;
            this.studentName.HeaderText = "ФИО";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // subjectName
            // 
            this.subjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectName.HeaderText = "Дисциплина";
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            // 
            // semester
            // 
            this.semester.FillWeight = 50F;
            this.semester.HeaderText = "Семестр";
            this.semester.Name = "semester";
            this.semester.ReadOnly = true;
            this.semester.Width = 80;
            // 
            // score
            // 
            this.score.FillWeight = 50F;
            this.score.HeaderText = "Оценка";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.Width = 70;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 33;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 33;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1144, 475);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 38);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ExamenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1270, 525);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showAllGroupBox);
            this.Controls.Add(this.addingNewGroupBox);
            this.Controls.Add(this.redactorViewGroupBox);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1136, 564);
            this.Name = "ExamenForm";
            this.Text = "Экзамены";
            this.MouseCaptureChanged += new System.EventHandler(this.specialityInput_Enter);
            this.redactorViewGroupBox.ResumeLayout(false);
            this.redactorViewGroupBox.PerformLayout();
            this.addingNewGroupBox.ResumeLayout(false);
            this.addingNewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreInput)).EndInit();
            this.showAllGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox redactorViewGroupBox;
        private Button showButton;
        private ComboBox semesterInput;
        private ComboBox subjectInput;
        private ComboBox specialityInput;
        private Label subjectLabel;
        private Label specialityLabel;
        private Label semesterLabel;
        private Label studentLabel;
        private Label scoreLabel;
        private GroupBox addingNewGroupBox;
        private Button addButton;
        private NumericUpDown scoreInput;
        private ComboBox studentInput;
        private GroupBox showAllGroupBox;
        private DataGridView examTable;
        private Button exitButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn subjectName;
        private DataGridViewTextBoxColumn semester;
        private DataGridViewTextBoxColumn score;
        private DataGridViewTextBoxColumn edit;
        private DataGridViewTextBoxColumn delete;
    }
}