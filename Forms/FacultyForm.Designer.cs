﻿namespace CourseWork_With_SQLite
{
    partial class FacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyForm));
            this.showAllGroupBox = new System.Windows.Forms.GroupBox();
            this.facultyTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addingGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.showAllGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyTable)).BeginInit();
            this.addingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showAllGroupBox
            // 
            this.showAllGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllGroupBox.Controls.Add(this.facultyTable);
            this.showAllGroupBox.Location = new System.Drawing.Point(12, 12);
            this.showAllGroupBox.Name = "showAllGroupBox";
            this.showAllGroupBox.Size = new System.Drawing.Size(720, 196);
            this.showAllGroupBox.TabIndex = 0;
            this.showAllGroupBox.TabStop = false;
            this.showAllGroupBox.Text = "Просмотр факультетов";
            // 
            // facultyTable
            // 
            this.facultyTable.AllowUserToAddRows = false;
            this.facultyTable.AllowUserToDeleteRows = false;
            this.facultyTable.AllowUserToResizeColumns = false;
            this.facultyTable.AllowUserToResizeRows = false;
            this.facultyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facultyTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facultyTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultyTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.facultyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Number,
            this.FacultyName,
            this.EditColumn,
            this.DeleteColumn});
            this.facultyTable.Location = new System.Drawing.Point(6, 28);
            this.facultyTable.MultiSelect = false;
            this.facultyTable.Name = "facultyTable";
            this.facultyTable.ReadOnly = true;
            this.facultyTable.RowHeadersVisible = false;
            this.facultyTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.facultyTable.RowTemplate.Height = 25;
            this.facultyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.facultyTable.ShowCellErrors = false;
            this.facultyTable.ShowCellToolTips = false;
            this.facultyTable.ShowEditingIcon = false;
            this.facultyTable.ShowRowErrors = false;
            this.facultyTable.Size = new System.Drawing.Size(708, 162);
            this.facultyTable.TabIndex = 50;
            this.facultyTable.TabStop = false;
            this.facultyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyTable_CellContentClick);
            this.facultyTable.SelectionChanged += new System.EventHandler(this.selectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.FillWeight = 15F;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyName.FillWeight = 92.12199F;
            this.FacultyName.HeaderText = "Название";
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.FillWeight = 17.00508F;
            this.EditColumn.HeaderText = "";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Width = 33;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 6.448539F;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 33;
            // 
            // addingGroupBox
            // 
            this.addingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addingGroupBox.Controls.Add(this.addButton);
            this.addingGroupBox.Controls.Add(this.nameInput);
            this.addingGroupBox.Controls.Add(this.nameLabel);
            this.addingGroupBox.Location = new System.Drawing.Point(738, 12);
            this.addingGroupBox.Name = "addingGroupBox";
            this.addingGroupBox.Size = new System.Drawing.Size(274, 135);
            this.addingGroupBox.TabIndex = 1;
            this.addingGroupBox.TabStop = false;
            this.addingGroupBox.Text = "Добавление факультета";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Beige;
            this.addButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(75, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 36);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameInput.Location = new System.Drawing.Point(6, 53);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(262, 29);
            this.nameInput.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(28, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 22);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Beige;
            this.closeButton.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(895, 167);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(117, 36);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 215);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addingGroupBox);
            this.Controls.Add(this.showAllGroupBox);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(789, 254);
            this.Name = "FacultyForm";
            this.Text = "Факультеты";
            this.showAllGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facultyTable)).EndInit();
            this.addingGroupBox.ResumeLayout(false);
            this.addingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox showAllGroupBox;
        private DataGridView facultyTable;
        private GroupBox addingGroupBox;
        private Button addButton;
        private TextBox nameInput;
        private Label nameLabel;
        private Button closeButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn FacultyName;
        private DataGridViewTextBoxColumn EditColumn;
        private DataGridViewTextBoxColumn DeleteColumn;
    }
}