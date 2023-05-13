namespace CourseWork_With_SQLite.Forms
{
    partial class SubjectEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectEditForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.specialityInput = new System.Windows.Forms.ComboBox();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(243, 144);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Beige;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(13, 144);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 38);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameInput.Location = new System.Drawing.Point(15, 95);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(363, 29);
            this.nameInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(37, 69);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 22);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название";
            // 
            // specialityInput
            // 
            this.specialityInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityInput.Enabled = false;
            this.specialityInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialityInput.FormattingEnabled = true;
            this.specialityInput.Location = new System.Drawing.Point(15, 35);
            this.specialityInput.Margin = new System.Windows.Forms.Padding(4);
            this.specialityInput.Name = "specialityInput";
            this.specialityInput.Size = new System.Drawing.Size(363, 30);
            this.specialityInput.TabIndex = 0;
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(37, 9);
            this.specialityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(176, 22);
            this.specialityLabel.TabIndex = 0;
            this.specialityLabel.Text = "Код специальности";
            // 
            // SubjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(390, 198);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.specialityLabel);
            this.Controls.Add(this.specialityInput);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 237);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(406, 237);
            this.Name = "SubjectEditForm";
            this.Text = "Редактирование данных дисциплины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitButton;
        private Button saveButton;
        private TextBox nameInput;
        private Label nameLabel;
        private ComboBox specialityInput;
        private Label specialityLabel;
    }
}