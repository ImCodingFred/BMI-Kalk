namespace BMI_Kalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void r�gz�t�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rogzites rogzites = new Rogzites();
            rogzites.ShowDialog();
        }

        private void statisztik�kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statisztika stat = new Statisztika();
            stat.ShowDialog();
        }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
