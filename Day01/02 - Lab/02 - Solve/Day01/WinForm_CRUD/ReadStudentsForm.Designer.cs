namespace WinForm_CRUD
{
    partial class frmRead
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
            btnReadAllStudents = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnReadAllStudents
            // 
            btnReadAllStudents.Location = new Point(285, 86);
            btnReadAllStudents.Name = "btnReadAllStudents";
            btnReadAllStudents.Size = new Size(201, 29);
            btnReadAllStudents.TabIndex = 0;
            btnReadAllStudents.Text = "Click To Read All Students";
            btnReadAllStudents.UseVisualStyleBackColor = true;
            btnReadAllStudents.Click += btnReadAllStudents_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 133);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(782, 613);
            dgvStudents.TabIndex = 1;
            // 
            // frmRead
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 749);
            Controls.Add(dgvStudents);
            Controls.Add(btnReadAllStudents);
            Name = "frmRead";
            Text = "ReadStudentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadAllStudents;
        private DataGridView dgvStudents;
    }
}