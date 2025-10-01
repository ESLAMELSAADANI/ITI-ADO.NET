namespace WinForm_CRUD
{
    partial class frmDeleteInstructor
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
            lblDelete = new Label();
            txtId = new TextBox();
            btnDeleteInstructor = new Button();
            SuspendLayout();
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(239, 185);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(63, 20);
            lblDelete.TabIndex = 0;
            lblDelete.Text = "Enter Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(308, 182);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 1;
            // 
            // btnDeleteInstructor
            // 
            btnDeleteInstructor.Location = new Point(479, 182);
            btnDeleteInstructor.Name = "btnDeleteInstructor";
            btnDeleteInstructor.Size = new Size(81, 32);
            btnDeleteInstructor.TabIndex = 2;
            btnDeleteInstructor.Text = "Delete";
            btnDeleteInstructor.UseVisualStyleBackColor = true;
            btnDeleteInstructor.Click += btnDeleteInstructor_Click;
            // 
            // frmDeleteInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteInstructor);
            Controls.Add(txtId);
            Controls.Add(lblDelete);
            Name = "frmDeleteInstructor";
            Text = "DeleteInstructorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDelete;
        private TextBox txtId;
        private Button btnDeleteInstructor;
    }
}