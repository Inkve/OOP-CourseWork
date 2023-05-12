namespace CourseWork_With_SQLite.Forms
{
    partial class SubjectsForm
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
            this.showAllGroupBox = new System.Windows.Forms.GroupBox();
            this.subjectTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.specialityInput = new System.Windows.Forms.ComboBox();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.showAllGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).BeginInit();
            this.addSubjectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showAllGroupBox
            // 
            this.showAllGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllGroupBox.Controls.Add(this.subjectTable);
            this.showAllGroupBox.Location = new System.Drawing.Point(12, 12);
            this.showAllGroupBox.Name = "showAllGroupBox";
            this.showAllGroupBox.Size = new System.Drawing.Size(1002, 284);
            this.showAllGroupBox.TabIndex = 0;
            this.showAllGroupBox.TabStop = false;
            this.showAllGroupBox.Text = "Просмотр предметов";
            // 
            // subjectTable
            // 
            this.subjectTable.AllowUserToAddRows = false;
            this.subjectTable.AllowUserToDeleteRows = false;
            this.subjectTable.AllowUserToResizeColumns = false;
            this.subjectTable.AllowUserToResizeRows = false;
            this.subjectTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subjectTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.subjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.SpecialityCode,
            this.NameSubject,
            this.Edit,
            this.Delete});
            this.subjectTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.subjectTable.Location = new System.Drawing.Point(6, 28);
            this.subjectTable.MultiSelect = false;
            this.subjectTable.Name = "subjectTable";
            this.subjectTable.ReadOnly = true;
            this.subjectTable.RowHeadersVisible = false;
            this.subjectTable.RowTemplate.Height = 25;
            this.subjectTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.subjectTable.ShowCellToolTips = false;
            this.subjectTable.ShowEditingIcon = false;
            this.subjectTable.ShowRowErrors = false;
            this.subjectTable.Size = new System.Drawing.Size(990, 250);
            this.subjectTable.TabIndex = 0;
            this.subjectTable.TabStop = false;
            this.subjectTable.SelectionChanged += new System.EventHandler(this.selectionChanged);
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
            // SpecialityCode
            // 
            this.SpecialityCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpecialityCode.HeaderText = "Направление специальности";
            this.SpecialityCode.Name = "SpecialityCode";
            this.SpecialityCode.ReadOnly = true;
            // 
            // NameSubject
            // 
            this.NameSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameSubject.FillWeight = 200F;
            this.NameSubject.HeaderText = "Название";
            this.NameSubject.Name = "NameSubject";
            this.NameSubject.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 33;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 33;
            // 
            // addSubjectGroupBox
            // 
            this.addSubjectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSubjectGroupBox.Controls.Add(this.addButton);
            this.addSubjectGroupBox.Controls.Add(this.nameInput);
            this.addSubjectGroupBox.Controls.Add(this.nameLabel);
            this.addSubjectGroupBox.Controls.Add(this.specialityInput);
            this.addSubjectGroupBox.Controls.Add(this.specialityLabel);
            this.addSubjectGroupBox.Location = new System.Drawing.Point(1020, 12);
            this.addSubjectGroupBox.Name = "addSubjectGroupBox";
            this.addSubjectGroupBox.Size = new System.Drawing.Size(233, 203);
            this.addSubjectGroupBox.TabIndex = 1;
            this.addSubjectGroupBox.TabStop = false;
            this.addSubjectGroupBox.Text = "Добавление предмета";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Beige;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(64, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 35);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameInput.Location = new System.Drawing.Point(6, 108);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(221, 29);
            this.nameInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(6, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 22);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название";
            // 
            // specialityInput
            // 
            this.specialityInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialityInput.FormattingEnabled = true;
            this.specialityInput.Location = new System.Drawing.Point(6, 50);
            this.specialityInput.Name = "specialityInput";
            this.specialityInput.Size = new System.Drawing.Size(221, 30);
            this.specialityInput.TabIndex = 0;
            this.specialityInput.Click += new System.EventHandler(this.updateVariants);
            this.specialityInput.Enter += new System.EventHandler(this.updateVariants);
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(6, 25);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(176, 22);
            this.specialityLabel.TabIndex = 0;
            this.specialityLabel.Text = "Код специальности";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1149, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1265, 308);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addSubjectGroupBox);
            this.Controls.Add(this.showAllGroupBox);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(852, 310);
            this.Name = "SubjectsForm";
            this.Text = "Предметы";
            this.showAllGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).EndInit();
            this.addSubjectGroupBox.ResumeLayout(false);
            this.addSubjectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox showAllGroupBox;
        private GroupBox addSubjectGroupBox;
        private DataGridView subjectTable;
        private Button addButton;
        private TextBox nameInput;
        private Label nameLabel;
        private ComboBox specialityInput;
        private Label specialityLabel;
        private Button exitButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn SpecialityCode;
        private DataGridViewTextBoxColumn NameSubject;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
    }
}