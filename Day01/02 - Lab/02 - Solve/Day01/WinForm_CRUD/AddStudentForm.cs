using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CRUD
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "insert into student(St_Id,St_Fname,St_Lname,St_Address,St_Age) values(@Id,@Fname,@Lname,@Address,@Age)";
            int id = int.Parse(textId.Text);
            string fname = textFname.Text;
            string lname = textLname.Text;
            string address = textAddress.Text;
            int age = int.Parse(textAge.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandString, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Fname", fname);
                    cmd.Parameters.AddWithValue("@Lname", lname);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Age", age);

                    try
                    {
                        conn.Open();
                        int rowAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowAffected} row inserted.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
