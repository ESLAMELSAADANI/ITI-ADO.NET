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
    public partial class frmDeleteCourse : Form
    {
        public frmDeleteCourse()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "select * from course";

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(commandString, conn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                adapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                int.TryParse(txtCourseId.Text, out int courseId);

                DataRow[] rows = dt.Select($"Crs_Id = {courseId}");
                if (rows.Length > 0)
                {
                    rows[0].Delete();
                }
                else
                {
                    MessageBox.Show("Course not found!");
                    return;
                }

                // Push changes back to DB
                adapter.Update(dt);

                MessageBox.Show("Course Deleted successfully!");

            }
        }
    }
}
