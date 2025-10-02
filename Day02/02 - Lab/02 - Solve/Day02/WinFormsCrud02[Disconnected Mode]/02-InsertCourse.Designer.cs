namespace WinFormsCrud02_Disconnected_Mode_
{
    partial class frmInsertCourse
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtDuration = new TextBox();
            lblId = new Label();
            lblName = new Label();
            lblDuration = new Label();
            btnAddCourse = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(302, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(152, 27);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(302, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 27);
            txtName.TabIndex = 0;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(302, 137);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(152, 27);
            txtDuration.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(225, 74);
            lblId.Name = "lblId";
            lblId.Size = new Size(67, 20);
            lblId.TabIndex = 1;
            lblId.Text = "CourseId";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(225, 107);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(225, 140);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(67, 20);
            lblDuration.TabIndex = 1;
            lblDuration.Text = "Duration";
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(326, 181);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(94, 29);
            btnAddCourse.TabIndex = 2;
            btnAddCourse.Text = "Add";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // frmInsertCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddCourse);
            Controls.Add(lblDuration);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(txtDuration);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "frmInsertCourse";
            Text = "Insert New Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDuration;
        private Label lblId;
        private Label lblName;
        private Label lblDuration;
        private Button btnAddCourse;
    }
}