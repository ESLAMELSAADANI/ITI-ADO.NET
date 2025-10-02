namespace WinFormsCrud02_Disconnected_Mode_
{
    partial class frmUpdateCourse
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
            cmbCourseColumns = new ComboBox();
            lblCombo = new Label();
            lblCourseId = new Label();
            txtCourseId = new TextBox();
            lblNewValue = new Label();
            txtNewValue = new TextBox();
            btnUpdateCourse = new Button();
            SuspendLayout();
            // 
            // cmbCourseColumns
            // 
            cmbCourseColumns.FormattingEnabled = true;
            cmbCourseColumns.Items.AddRange(new object[] { "Crs_Id", "Crs_Name", "Crs_Duration" });
            cmbCourseColumns.Location = new Point(281, 100);
            cmbCourseColumns.Name = "cmbCourseColumns";
            cmbCourseColumns.Size = new Size(242, 28);
            cmbCourseColumns.TabIndex = 0;
            // 
            // lblCombo
            // 
            lblCombo.AutoSize = true;
            lblCombo.Location = new Point(295, 77);
            lblCombo.Name = "lblCombo";
            lblCombo.Size = new Size(213, 20);
            lblCombo.TabIndex = 1;
            lblCombo.Text = "Select Column Need ToUpdate";
            // 
            // lblCourseId
            // 
            lblCourseId.AutoSize = true;
            lblCourseId.Location = new Point(335, 148);
            lblCourseId.Name = "lblCourseId";
            lblCourseId.Size = new Size(109, 20);
            lblCourseId.TabIndex = 2;
            lblCourseId.Text = "Enter Course Id";
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(281, 171);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(242, 27);
            txtCourseId.TabIndex = 3;
            // 
            // lblNewValue
            // 
            lblNewValue.AutoSize = true;
            lblNewValue.Location = new Point(335, 216);
            lblNewValue.Name = "lblNewValue";
            lblNewValue.Size = new Size(117, 20);
            lblNewValue.TabIndex = 2;
            lblNewValue.Text = "Enter New Value";
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(281, 239);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(242, 27);
            txtNewValue.TabIndex = 3;
            // 
            // btnUpdateCourse
            // 
            btnUpdateCourse.Location = new Point(350, 289);
            btnUpdateCourse.Name = "btnUpdateCourse";
            btnUpdateCourse.Size = new Size(94, 29);
            btnUpdateCourse.TabIndex = 4;
            btnUpdateCourse.Text = "Update";
            btnUpdateCourse.UseVisualStyleBackColor = true;
            btnUpdateCourse.Click += btnUpdateCourse_Click;
            // 
            // frmUpdateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateCourse);
            Controls.Add(txtNewValue);
            Controls.Add(txtCourseId);
            Controls.Add(lblNewValue);
            Controls.Add(lblCourseId);
            Controls.Add(lblCombo);
            Controls.Add(cmbCourseColumns);
            Name = "frmUpdateCourse";
            Text = "Update Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCourseColumns;
        private Label lblCombo;
        private Label lblCourseId;
        private TextBox txtCourseId;
        private Label lblNewValue;
        private TextBox txtNewValue;
        private Button btnUpdateCourse;
    }
}