namespace CMSWinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            JobsDetailsForm jobsDetailsForm = new JobsDetailsForm();
            jobsDetailsForm.Show();
            this.Hide();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Reports_Form reportsForm = new Reports_Form();
            reportsForm.Show();
            this.Hide();
        }
    }
}