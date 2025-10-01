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
    public partial class frmUpdateStudent : Form
    {
        public frmUpdateStudent()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string? column = cmbStColumns?.SelectedItem?.ToString();
            string commandString = $"Update student set {column} = @newValue where st_Id = @Id";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandString, conn))
                {
                    cmd.Parameters.AddWithValue("@newValue", txtNewValue.Text);
                    cmd.Parameters.AddWithValue("@Id", txtStudentId.Text);

                    try
                    {
                        conn.Open();
                        int rowAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowAffected} row updated.");   
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
