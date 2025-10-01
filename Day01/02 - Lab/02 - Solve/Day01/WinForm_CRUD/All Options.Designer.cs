namespace WinForm_CRUD
{
    partial class frmAllOptions
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
            btnRead = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(92, 207);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(143, 29);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read All Students";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(241, 207);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(143, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert New Student";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(390, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update Students";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(539, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete Instructor";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmAllOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnRead);
            Name = "frmAllOptions";
            Text = "CRUD Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
