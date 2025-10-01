namespace WinForm_CRUD
{
    partial class frmAddStudent
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
            textId = new TextBox();
            textFname = new TextBox();
            textLname = new TextBox();
            textAddress = new TextBox();
            textAge = new TextBox();
            lblID = new Label();
            lblFname = new Label();
            lblLname = new Label();
            lblAddress = new Label();
            lblAge = new Label();
            btnAddStudent = new Button();
            SuspendLayout();
            // 
            // textId
            // 
            textId.Location = new Point(330, 75);
            textId.Name = "textId";
            textId.Size = new Size(162, 27);
            textId.TabIndex = 0;
            // 
            // textFname
            // 
            textFname.Location = new Point(330, 118);
            textFname.Name = "textFname";
            textFname.Size = new Size(162, 27);
            textFname.TabIndex = 0;
            // 
            // textLname
            // 
            textLname.Location = new Point(330, 161);
            textLname.Name = "textLname";
            textLname.Size = new Size(162, 27);
            textLname.TabIndex = 0;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(330, 204);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(162, 27);
            textAddress.TabIndex = 0;
            // 
            // textAge
            // 
            textAge.Location = new Point(330, 248);
            textAge.Name = "textAge";
            textAge.Size = new Size(162, 27);
            textAge.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(241, 82);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(241, 125);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(53, 20);
            lblFname.TabIndex = 1;
            lblFname.Text = "Fname";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(241, 168);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(53, 20);
            lblLname.TabIndex = 1;
            lblLname.Text = "Lname";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(241, 211);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(241, 255);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(361, 297);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 29);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddStudent);
            Controls.Add(lblAge);
            Controls.Add(lblAddress);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(lblID);
            Controls.Add(textAge);
            Controls.Add(textAddress);
            Controls.Add(textLname);
            Controls.Add(textFname);
            Controls.Add(textId);
            Name = "frmAddStudent";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textId;
        private TextBox textFname;
        private TextBox textLname;
        private TextBox textAddress;
        private TextBox textAge;
        private Label lblID;
        private Label lblFname;
        private Label lblLname;
        private Label lblAddress;
        private Label lblAge;
        private Button btnAddStudent;
    }
}