namespace BMI_Kalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rogzites rogzites = new Rogzites();
            rogzites.ShowDialog();
        }

        private void statisztikákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statisztika stat = new Statisztika();
            stat.ShowDialog();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
