namespace WinForm_CRUD
{
    partial class frmUpdateStudent
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
            cmbStColumns = new ComboBox();
            lblCombo = new Label();
            txtNewValue = new TextBox();
            lblTextBox = new Label();
            btnUpdate = new Button();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            SuspendLayout();
            // 
            // cmbStColumns
            // 
            cmbStColumns.FormattingEnabled = true;
            cmbStColumns.Items.AddRange(new object[] { "St_Id", "St_Fname", "St_Lname", "St_Address", "St_Age" });
            cmbStColumns.Location = new Point(314, 101);
            cmbStColumns.Name = "cmbStColumns";
            cmbStColumns.Size = new Size(151, 28);
            cmbStColumns.TabIndex = 0;
            // 
            // lblCombo
            // 
            lblCombo.AutoSize = true;
            lblCombo.Location = new Point(274, 78);
            lblCombo.Name = "lblCombo";
            lblCombo.Size = new Size(250, 20);
            lblCombo.TabIndex = 1;
            lblCombo.Text = "Select the column needed to update";
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(314, 233);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(151, 27);
            txtNewValue.TabIndex = 2;
            // 
            // lblTextBox
            // 
            lblTextBox.AutoSize = true;
            lblTextBox.Location = new Point(335, 210);
            lblTextBox.Name = "lblTextBox";
            lblTextBox.Size = new Size(113, 20);
            lblTextBox.TabIndex = 3;
            lblTextBox.Text = "Enter new value";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(344, 278);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(335, 143);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(115, 20);
            lblStudentId.TabIndex = 3;
            lblStudentId.Text = "Enter Student Id";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(314, 166);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(151, 27);
            txtStudentId.TabIndex = 2;
            // 
            // frmUpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(lblStudentId);
            Controls.Add(lblTextBox);
            Controls.Add(txtStudentId);
            Controls.Add(txtNewValue);
            Controls.Add(lblCombo);
            Controls.Add(cmbStColumns);
            Name = "frmUpdateStudent";
            Text = "UpdateStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStColumns;
        private Label lblCombo;
        private TextBox txtNewValue;
        private Label lblTextBox;
        private Button btnUpdate;
        private Label lblStudentId;
        private TextBox txtStudentId;
    }
}