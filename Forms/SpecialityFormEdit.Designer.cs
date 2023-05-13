namespace CourseWork_With_SQLite.Forms
{
    partial class SpecialityFormEdit
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
            this.specialityNameInput = new System.Windows.Forms.TextBox();
            this.specialityCodeInput = new System.Windows.Forms.TextBox();
            this.facultyInput = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.specialityNameLabel = new System.Windows.Forms.Label();
            this.specialityCodeLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // specialityNameInput
            // 
            this.specialityNameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityNameInput.Location = new System.Drawing.Point(13, 150);
            this.specialityNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.specialityNameInput.Name = "specialityNameInput";
            this.specialityNameInput.Size = new System.Drawing.Size(418, 29);
            this.specialityNameInput.TabIndex = 8;
            // 
            // specialityCodeInput
            // 
            this.specialityCodeInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityCodeInput.Location = new System.Drawing.Point(13, 91);
            this.specialityCodeInput.Margin = new System.Windows.Forms.Padding(4);
            this.specialityCodeInput.Name = "specialityCodeInput";
            this.specialityCodeInput.ReadOnly = true;
            this.specialityCodeInput.Size = new System.Drawing.Size(418, 29);
            this.specialityCodeInput.TabIndex = 6;
            // 
            // facultyInput
            // 
            this.facultyInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.facultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyInput.Enabled = false;
            this.facultyInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultyInput.FormattingEnabled = true;
            this.facultyInput.Location = new System.Drawing.Point(13, 31);
            this.facultyInput.Margin = new System.Windows.Forms.Padding(4);
            this.facultyInput.Name = "facultyInput";
            this.facultyInput.Size = new System.Drawing.Size(418, 30);
            this.facultyInput.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Beige;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(13, 198);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 37);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // specialityNameLabel
            // 
            this.specialityNameLabel.AutoSize = true;
            this.specialityNameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityNameLabel.Location = new System.Drawing.Point(35, 124);
            this.specialityNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialityNameLabel.Name = "specialityNameLabel";
            this.specialityNameLabel.Size = new System.Drawing.Size(227, 22);
            this.specialityNameLabel.TabIndex = 9;
            this.specialityNameLabel.Text = "Название специальности";
            // 
            // specialityCodeLabel
            // 
            this.specialityCodeLabel.AutoSize = true;
            this.specialityCodeLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityCodeLabel.Location = new System.Drawing.Point(35, 65);
            this.specialityCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialityCodeLabel.Name = "specialityCodeLabel";
            this.specialityCodeLabel.Size = new System.Drawing.Size(176, 22);
            this.specialityCodeLabel.TabIndex = 7;
            this.specialityCodeLabel.Text = "Код специальности";
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facultyLabel.Location = new System.Drawing.Point(35, 5);
            this.facultyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(100, 22);
            this.facultyLabel.TabIndex = 5;
            this.facultyLabel.Text = "Факультет";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Beige;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(277, 198);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(154, 37);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SpecialityFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 246);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.specialityNameInput);
            this.Controls.Add(this.specialityCodeInput);
            this.Controls.Add(this.facultyInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.specialityNameLabel);
            this.Controls.Add(this.specialityCodeLabel);
            this.Controls.Add(this.facultyLabel);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 285);
            this.Name = "SpecialityFormEdit";
            this.Text = "Редактирование данных специальности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox specialityNameInput;
        private TextBox specialityCodeInput;
        private ComboBox facultyInput;
        private Button saveButton;
        private Label specialityNameLabel;
        private Label specialityCodeLabel;
        private Label facultyLabel;
        private Button closeButton;
    }
}