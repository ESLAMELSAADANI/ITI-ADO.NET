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
    public partial class frmAllCourses : Form
    {
        public frmAllCourses()
        {
            InitializeComponent();
        }

        private void btnAllCourses_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "select * from course";
            List<Course> courses = [];



            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(commandString, conn);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                int.TryParse(dr[0]?.ToString(), out int id);
                string? name = dr[1]?.ToString();
                int.TryParse(dr[2].ToString(), out int duration);

                Course course = new Course()
                {
                    Id = id,
                    Name = name,
                    Duration = duration
                };
                courses.Add(course);
            }
            dgvAllCourses.DataSource = null;
            dgvAllCourses.DataSource = courses;

        }
    }
}
