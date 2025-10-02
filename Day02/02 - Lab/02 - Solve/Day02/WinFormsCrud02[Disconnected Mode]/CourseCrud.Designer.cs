namespace WinFormsCrud02_Disconnected_Mode_
{
    partial class frmCourseCrud
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReadAllCrs = new Button();
            btnInsertCrs = new Button();
            btnUpdateCrs = new Button();
            btnDeleteCrs = new Button();
            SuspendLayout();
            // 
            // btnReadAllCrs
            // 
            btnReadAllCrs.Location = new Point(47, 183);
            btnReadAllCrs.Name = "btnReadAllCrs";
            btnReadAllCrs.Size = new Size(167, 29);
            btnReadAllCrs.TabIndex = 0;
            btnReadAllCrs.Text = "All Courses";
            btnReadAllCrs.UseVisualStyleBackColor = true;
            btnReadAllCrs.Click += btnReadAllCrs_Click;
            // 
            // btnInsertCrs
            // 
            btnInsertCrs.Location = new Point(220, 183);
            btnInsertCrs.Name = "btnInsertCrs";
            btnInsertCrs.Size = new Size(167, 29);
            btnInsertCrs.TabIndex = 0;
            btnInsertCrs.Text = "Add Course";
            btnInsertCrs.UseVisualStyleBackColor = true;
            btnInsertCrs.Click += btnInsertCrs_Click;
            // 
            // btnUpdateCrs
            // 
            btnUpdateCrs.Location = new Point(393, 183);
            btnUpdateCrs.Name = "btnUpdateCrs";
            btnUpdateCrs.Size = new Size(167, 29);
            btnUpdateCrs.TabIndex = 0;
            btnUpdateCrs.Text = "Update Course";
            btnUpdateCrs.UseVisualStyleBackColor = true;
            btnUpdateCrs.Click += btnUpdateCrs_Click;
            // 
            // btnDeleteCrs
            // 
            btnDeleteCrs.Location = new Point(566, 183);
            btnDeleteCrs.Name = "btnDeleteCrs";
            btnDeleteCrs.Size = new Size(167, 29);
            btnDeleteCrs.TabIndex = 0;
            btnDeleteCrs.Text = "Delete Course";
            btnDeleteCrs.UseVisualStyleBackColor = true;
            btnDeleteCrs.Click += btnDeleteCrs_Click;
            // 
            // frmCourseCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteCrs);
            Controls.Add(btnUpdateCrs);
            Controls.Add(btnInsertCrs);
            Controls.Add(btnReadAllCrs);
            Name = "frmCourseCrud";
            Text = "CRUD";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadAllCrs;
        private Button btnInsertCrs;
        private Button btnUpdateCrs;
        private Button btnDeleteCrs;
    }
}
