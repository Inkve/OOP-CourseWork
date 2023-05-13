namespace CourseWork_With_SQLite.Forms
{
    partial class SpecialityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialityForm));
            this.showAllGroupBox = new System.Windows.Forms.GroupBox();
            this.specialityTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.specialityNameInput = new System.Windows.Forms.TextBox();
            this.specialityCodeInput = new System.Windows.Forms.TextBox();
            this.facultyInput = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.specialityNameLabel = new System.Windows.Forms.Label();
            this.specialityCodeLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.showAllGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialityTable)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showAllGroupBox
            // 
            this.showAllGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllGroupBox.Controls.Add(this.specialityTable);
            this.showAllGroupBox.Location = new System.Drawing.Point(13, 13);
            this.showAllGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.showAllGroupBox.Name = "showAllGroupBox";
            this.showAllGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.showAllGroupBox.Size = new System.Drawing.Size(884, 321);
            this.showAllGroupBox.TabIndex = 0;
            this.showAllGroupBox.TabStop = false;
            this.showAllGroupBox.Text = "Просмотр специальностей";
            // 
            // specialityTable
            // 
            this.specialityTable.AllowUserToAddRows = false;
            this.specialityTable.AllowUserToDeleteRows = false;
            this.specialityTable.AllowUserToResizeRows = false;
            this.specialityTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialityTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.specialityTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialityTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.specialityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialityTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.Faculty,
            this.SpecialityCode,
            this.SpecialityName,
            this.Edit,
            this.Delete});
            this.specialityTable.Location = new System.Drawing.Point(7, 29);
            this.specialityTable.MultiSelect = false;
            this.specialityTable.Name = "specialityTable";
            this.specialityTable.ReadOnly = true;
            this.specialityTable.RowHeadersVisible = false;
            this.specialityTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.specialityTable.RowTemplate.Height = 25;
            this.specialityTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.specialityTable.ShowCellErrors = false;
            this.specialityTable.ShowCellToolTips = false;
            this.specialityTable.ShowEditingIcon = false;
            this.specialityTable.ShowRowErrors = false;
            this.specialityTable.Size = new System.Drawing.Size(870, 285);
            this.specialityTable.TabIndex = 50;
            this.specialityTable.TabStop = false;
            this.specialityTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.specialityTable_CellContentClick);
            this.specialityTable.SelectionChanged += new System.EventHandler(this.selectionChanged);
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
            this.Number.FillWeight = 25F;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // Faculty
            // 
            this.Faculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Faculty.HeaderText = "Факультет";
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // SpecialityCode
            // 
            this.SpecialityCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpecialityCode.FillWeight = 50F;
            this.SpecialityCode.HeaderText = "Код специальности";
            this.SpecialityCode.Name = "SpecialityCode";
            this.SpecialityCode.ReadOnly = true;
            // 
            // SpecialityName
            // 
            this.SpecialityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpecialityName.HeaderText = "Название";
            this.SpecialityName.Name = "SpecialityName";
            this.SpecialityName.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 12F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 33;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 12F;
            this.Delete.HeaderText = " ";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 33;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGroupBox.Controls.Add(this.specialityNameInput);
            this.addGroupBox.Controls.Add(this.specialityCodeInput);
            this.addGroupBox.Controls.Add(this.facultyInput);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.specialityNameLabel);
            this.addGroupBox.Controls.Add(this.specialityCodeLabel);
            this.addGroupBox.Controls.Add(this.facultyLabel);
            this.addGroupBox.Location = new System.Drawing.Point(904, 13);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(258, 255);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Добавление специальности";
            // 
            // specialityNameInput
            // 
            this.specialityNameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityNameInput.Location = new System.Drawing.Point(6, 165);
            this.specialityNameInput.Name = "specialityNameInput";
            this.specialityNameInput.Size = new System.Drawing.Size(246, 29);
            this.specialityNameInput.TabIndex = 2;
            // 
            // specialityCodeInput
            // 
            this.specialityCodeInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.specialityCodeInput.Location = new System.Drawing.Point(6, 108);
            this.specialityCodeInput.Name = "specialityCodeInput";
            this.specialityCodeInput.Size = new System.Drawing.Size(246, 29);
            this.specialityCodeInput.TabIndex = 1;
            // 
            // facultyInput
            // 
            this.facultyInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.facultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultyInput.FormattingEnabled = true;
            this.facultyInput.Location = new System.Drawing.Point(6, 50);
            this.facultyInput.Name = "facultyInput";
            this.facultyInput.Size = new System.Drawing.Size(246, 30);
            this.facultyInput.TabIndex = 0;
            this.facultyInput.Click += new System.EventHandler(this.updateFacultyList);
            this.facultyInput.Enter += new System.EventHandler(this.updateFacultyList);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Beige;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(72, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 33);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // specialityNameLabel
            // 
            this.specialityNameLabel.AutoSize = true;
            this.specialityNameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityNameLabel.Location = new System.Drawing.Point(21, 140);
            this.specialityNameLabel.Name = "specialityNameLabel";
            this.specialityNameLabel.Size = new System.Drawing.Size(227, 22);
            this.specialityNameLabel.TabIndex = 2;
            this.specialityNameLabel.Text = "Название специальности";
            // 
            // specialityCodeLabel
            // 
            this.specialityCodeLabel.AutoSize = true;
            this.specialityCodeLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialityCodeLabel.Location = new System.Drawing.Point(21, 83);
            this.specialityCodeLabel.Name = "specialityCodeLabel";
            this.specialityCodeLabel.Size = new System.Drawing.Size(176, 22);
            this.specialityCodeLabel.TabIndex = 1;
            this.specialityCodeLabel.Text = "Код специальности";
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facultyLabel.Location = new System.Drawing.Point(21, 25);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(100, 22);
            this.facultyLabel.TabIndex = 0;
            this.facultyLabel.Text = "Факультет";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Beige;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1042, 299);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SpecialityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1174, 344);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.showAllGroupBox);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1126, 364);
            this.Name = "SpecialityForm";
            this.Text = "Специальности";
            this.showAllGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.specialityTable)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox showAllGroupBox;
        private GroupBox addGroupBox;
        private TextBox specialityNameInput;
        private TextBox specialityCodeInput;
        private ComboBox facultyInput;
        private Button addButton;
        private Label specialityNameLabel;
        private Label specialityCodeLabel;
        private Label facultyLabel;
        private Button exitButton;
        private DataGridView specialityTable;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Faculty;
        private DataGridViewTextBoxColumn SpecialityCode;
        private DataGridViewTextBoxColumn SpecialityName;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
    }
}