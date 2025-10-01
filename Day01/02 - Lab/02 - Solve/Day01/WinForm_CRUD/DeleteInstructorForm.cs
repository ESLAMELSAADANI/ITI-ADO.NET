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
    public partial class frmDeleteInstructor : Form
    {
        public frmDeleteInstructor()
        {
            InitializeComponent();
        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "DELETE FROM Instructor WHERE Ins_Id = @Id";
            //int id = int.Parse(txtDelete.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandString, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show($"{rowsAffected} row(s) deleted successfully.");
                        else
                            MessageBox.Show("No student found with this Id.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
