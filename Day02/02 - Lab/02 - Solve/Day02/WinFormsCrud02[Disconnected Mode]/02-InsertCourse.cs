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
    public partial class frmInsertCourse : Form
    {
        public frmInsertCourse()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "select * from course";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(commandString,conn);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            adapter.Fill(dt);

            int.TryParse(txtId.Text, out int id);
            string name = txtName.Text;
            int.TryParse(txtDuration.Text, out int duration);

            dt.Rows.Add(id, name, duration);
            adapter.Update(dt);
            MessageBox.Show($"Course Added Successfully");
        }
    }
}
