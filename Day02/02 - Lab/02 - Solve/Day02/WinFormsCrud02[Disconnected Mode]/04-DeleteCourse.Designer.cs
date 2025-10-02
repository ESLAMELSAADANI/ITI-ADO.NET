namespace WinFormsCrud02_Disconnected_Mode_
{
    partial class frmDeleteCourse
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
            lblCourseId = new Label();
            txtCourseId = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblCourseId
            // 
            lblCourseId.AutoSize = true;
            lblCourseId.Location = new Point(259, 187);
            lblCourseId.Name = "lblCourseId";
            lblCourseId.Size = new Size(69, 20);
            lblCourseId.TabIndex = 0;
            lblCourseId.Text = "CourseID";
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(334, 187);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(162, 27);
            txtCourseId.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(520, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmDeleteCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtCourseId);
            Controls.Add(lblCourseId);
            Name = "frmDeleteCourse";
            Text = "Delete Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseId;
        private TextBox txtCourseId;
        private Button btnDelete;
    }
}