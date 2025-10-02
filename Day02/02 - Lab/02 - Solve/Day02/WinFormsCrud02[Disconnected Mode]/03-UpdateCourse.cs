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

namespace WinFormsCrud02_Disconnected_Mode_
{
    public partial class frmUpdateCourse : Form
    {
        public frmUpdateCourse()
        {
            InitializeComponent();
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "SELECT * FROM course";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Adapter needs a select command
                SqlDataAdapter adapter = new SqlDataAdapter(commandString, conn);

                // Command builder can now auto-generate insert, update, delete
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();

                // Load schema + data
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Read values from UI
                string? selectedColumn = cmbCourseColumns?.SelectedItem?.ToString();  // your dropdown
                int.TryParse(txtCourseId.Text, out int courseId);
                string newValue = txtNewValue.Text;

                if (string.IsNullOrEmpty(selectedColumn) || courseId == 0 || string.IsNullOrEmpty(newValue))
                {
                    MessageBox.Show("Please fill all fields correctly.");
                    return;
                }

                // Find the row by CourseId
                DataRow[] rows = dt.Select($"Crs_Id = {courseId}");
                if (rows.Length > 0)
                {
                    rows[0][selectedColumn] = newValue; // update value in datatable
                }
                else
                {
                    MessageBox.Show("Course not found!");
                    return;
                }

                // Push changes back to DB
                adapter.Update(dt);

                MessageBox.Show("Course updated successfully!");
            }


        }
    }
}
