namespace WinFormsCrud02_Disconnected_Mode_
{
    public partial class frmCourseCrud : Form
    {
        public frmCourseCrud()
        {
            InitializeComponent();
        }

        private void btnReadAllCrs_Click(object sender, EventArgs e)
        {
            frmAllCourses frmAllCourses = new frmAllCourses();
            frmAllCourses.Show();
        }

        private void btnInsertCrs_Click(object sender, EventArgs e)
        {
            frmInsertCourse frmInsertCourse = new frmInsertCourse();
            frmInsertCourse.Show();
        }

        private void btnUpdateCrs_Click(object sender, EventArgs e)
        {
            frmUpdateCourse frmUpdateCourse = new frmUpdateCourse();
            frmUpdateCourse.Show();
        }

        private void btnDeleteCrs_Click(object sender, EventArgs e)
        {
            frmDeleteCourse frmDeleteCourse = new frmDeleteCourse();
            frmDeleteCourse.Show();
        }
    }
}
