namespace CourseWork_With_SQLite.Forms
{
    partial class ExamenEditForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreInput = new System.Windows.Forms.NumericUpDown();
            this.studentInput = new System.Windows.Forms.ComboBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.semesterInput = new System.Windows.Forms.ComboBox();
            this.subjectInput = new System.Windows.Forms.ComboBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scoreInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 742);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Beige;
            this.saveButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(13, 252);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 45);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(171, 252);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 45);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreInput
            // 
            this.scoreInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreInput.Location = new System.Drawing.Point(8, 215);
            this.scoreInput.Margin = new System.Windows.Forms.Padding(4);
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
            this.scoreInput.Size = new System.Drawing.Size(311, 25);
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
            this.studentInput.Enabled = false;
            this.studentInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentInput.FormattingEnabled = true;
            this.studentInput.Location = new System.Drawing.Point(8, 155);
            this.studentInput.Margin = new System.Windows.Forms.Padding(4);
            this.studentInput.Name = "studentInput";
            this.studentInput.Size = new System.Drawing.Size(310, 30);
            this.studentInput.TabIndex = 4;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentLabel.Location = new System.Drawing.Point(39, 129);
            this.studentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(78, 22);
            this.studentLabel.TabIndex = 2;
            this.studentLabel.Text = "Студент";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(39, 189);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(74, 22);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Оценка";
            // 
            // semesterInput
            // 
            this.semesterInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.semesterInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterInput.Enabled = false;
            this.semesterInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.semesterInput.FormattingEnabled = true;
            this.semesterInput.Location = new System.Drawing.Point(8, 95);
            this.semesterInput.Margin = new System.Windows.Forms.Padding(4);
            this.semesterInput.Name = "semesterInput";
            this.semesterInput.Size = new System.Drawing.Size(310, 30);
            this.semesterInput.TabIndex = 2;
            // 
            // subjectInput
            // 
            this.subjectInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectInput.Enabled = false;
            this.subjectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectInput.FormattingEnabled = true;
            this.subjectInput.Location = new System.Drawing.Point(8, 35);
            this.subjectInput.Margin = new System.Windows.Forms.Padding(4);
            this.subjectInput.Name = "subjectInput";
            this.subjectInput.Size = new System.Drawing.Size(310, 30);
            this.subjectInput.TabIndex = 1;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLabel.Location = new System.Drawing.Point(39, 9);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(84, 22);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Предмет";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(39, 69);
            this.semesterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(79, 22);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Семестр";
            // 
            // ExamenEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(327, 308);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.semesterInput);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.studentInput);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(343, 347);
            this.Name = "ExamenEditForm";
            this.RightToLeftLayout = true;
            this.Text = "Редактирование данных экзамена";
            ((System.ComponentModel.ISupportInitialize)(this.scoreInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button saveButton;
        private Button exitButton;
        private NumericUpDown scoreInput;
        private ComboBox studentInput;
        private Label studentLabel;
        private Label scoreLabel;
        private ComboBox semesterInput;
        private ComboBox subjectInput;
        private Label subjectLabel;
        private Label semesterLabel;
    }
}