namespace WinFormsCrud02_Disconnected_Mode_
{
    partial class frmAllCourses
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
            btnAllCourses = new Button();
            dgvAllCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAllCourses).BeginInit();
            SuspendLayout();
            // 
            // btnAllCourses
            // 
            btnAllCourses.Location = new Point(267, 58);
            btnAllCourses.Name = "btnAllCourses";
            btnAllCourses.Size = new Size(213, 29);
            btnAllCourses.TabIndex = 0;
            btnAllCourses.Text = "Click To View All Courses";
            btnAllCourses.UseVisualStyleBackColor = true;
            btnAllCourses.Click += btnAllCourses_Click;
            // 
            // dgvAllCourses
            // 
            dgvAllCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllCourses.Location = new Point(155, 93);
            dgvAllCourses.Name = "dgvAllCourses";
            dgvAllCourses.RowHeadersWidth = 51;
            dgvAllCourses.Size = new Size(425, 418);
            dgvAllCourses.TabIndex = 1;
            // 
            // frmAllCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(dgvAllCourses);
            Controls.Add(btnAllCourses);
            Name = "frmAllCourses";
            Text = "Read All Courses";
            ((System.ComponentModel.ISupportInitialize)dgvAllCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAllCourses;
        private DataGridView dgvAllCourses;
    }
}