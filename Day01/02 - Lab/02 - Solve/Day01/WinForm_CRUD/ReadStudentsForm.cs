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
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }

        private void btnReadAllStudents_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "select * from student";
            List<Student> students = [];
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandString, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            students.Add(new Student()
                            {
                                Id = reader.GetInt32(0),
                                FName = reader.GetString(1),
                                LName = reader.GetString(2),
                                Address = reader.GetString(3),
                                Age = reader.GetInt32(4)
                            });
                        }
                        dgvStudents.DataSource = null;  // to make refresh
                        dgvStudents.DataSource = students;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error " + ex.Message);
                    }
                }
            }
        }
    }
}
