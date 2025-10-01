using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace WinForm_CRUD
{
    public partial class frmAllOptions : Form
    {
        public frmAllOptions()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            frmRead frmRead = new frmRead();
            frmRead.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAdd = new frmAddStudent();
            frmAdd.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateStudent frmUpdate = new frmUpdateStudent();
            frmUpdate.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteInstructor frmDelete = new frmDeleteInstructor();
            frmDelete.Show();
        }
    }
}
