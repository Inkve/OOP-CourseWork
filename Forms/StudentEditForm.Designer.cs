namespace CourseWork_With_SQLite.Forms
{
    partial class StudentEditForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.semesterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(213, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Beige;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(13, 460);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 35);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // groupInput
            // 
            this.groupInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupInput.Location = new System.Drawing.Point(13, 415);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(314, 29);
            this.groupInput.TabIndex = 8;
            // 
            // birthdayInput
            // 
            this.birthdayInput.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.birthdayInput.Location = new System.Drawing.Point(12, 205);
            this.birthdayInput.Name = "birthdayInput";
            this.birthdayInput.Size = new System.Drawing.Size(315, 29);
            this.birthdayInput.TabIndex = 4;
            // 
            // semesterInput
            // 
            this.semesterInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.semesterInput.Location = new System.Drawing.Point(13, 299);
            this.semesterInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.semesterInput.Size = new System.Drawing.Size(314, 29);
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
            this.budgetInput.Location = new System.Drawing.Point(156, 244);
            this.budgetInput.Name = "budgetInput";
            this.budgetInput.Size = new System.Drawing.Size(49, 26);
            this.budgetInput.TabIndex = 5;
            this.budgetInput.Text = "Да";
            this.budgetInput.UseVisualStyleBackColor = true;
            // 
            // patronymicInput
            // 
            this.patronymicInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.patronymicInput.Location = new System.Drawing.Point(12, 148);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(315, 29);
            this.patronymicInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameInput.Location = new System.Drawing.Point(8, 91);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(319, 29);
            this.nameInput.TabIndex = 2;
            // 
            // surnameInput
            // 
            this.surnameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.surnameInput.Location = new System.Drawing.Point(8, 34);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(319, 29);
            this.surnameInput.TabIndex = 1;
            // 
            // specialityInput
            // 
            this.specialityInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialityInput.FormattingEnabled = true;
            this.specialityInput.Location = new System.Drawing.Point(13, 357);
            this.specialityInput.Name = "specialityInput";
            this.specialityInput.Size = new System.Drawing.Size(314, 30);
            this.specialityInput.TabIndex = 7;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupLabel.Location = new System.Drawing.Point(29, 390);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(68, 22);
            this.groupLabel.TabIndex = 7;
            this.groupLabel.Text = "Группа";
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(29, 332);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(176, 22);
            this.specialityLabel.TabIndex = 6;
            this.specialityLabel.Text = "Код специальности";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(27, 273);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(163, 22);
            this.semesterLabel.TabIndex = 5;
            this.semesterLabel.Text = "Семестр обучения";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.budgetLabel.Location = new System.Drawing.Point(27, 244);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(110, 22);
            this.budgetLabel.TabIndex = 4;
            this.budgetLabel.Text = "Бюджетник";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.Location = new System.Drawing.Point(27, 180);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(141, 22);
            this.birthdayLabel.TabIndex = 3;
            this.birthdayLabel.Text = "Дата рождения";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patronymicLabel.Location = new System.Drawing.Point(27, 123);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(88, 22);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(27, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(27, 9);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(91, 22);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Фамилия";
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 504);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.birthdayInput);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.semesterInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.budgetInput);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.patronymicInput);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.specialityInput);
            this.Controls.Add(this.specialityLabel);
            this.Controls.Add(this.groupLabel);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 543);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 543);
            this.Name = "StudentEditForm";
            this.Text = "Редактирование данных студента";
            ((System.ComponentModel.ISupportInitialize)(this.semesterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitButton;
        private Button saveButton;
        private TextBox groupInput;
        private DateTimePicker birthdayInput;
        private NumericUpDown semesterInput;
        private CheckBox budgetInput;
        private TextBox patronymicInput;
        private TextBox nameInput;
        private TextBox surnameInput;
        private ComboBox specialityInput;
        private Label groupLabel;
        private Label specialityLabel;
        private Label semesterLabel;
        private Label budgetLabel;
        private Label birthdayLabel;
        private Label patronymicLabel;
        private Label nameLabel;
        private Label surnameLabel;
    }
}