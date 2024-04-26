using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Kalk
{
    public partial class Rogzites : Form
    {
        public Rogzites()
        {
            InitializeComponent();
        }
        public (double bmi, string kat) BMI;
        private void szamol()
        {
            if (tb_magassag.Text != "" && tb_sulya.Text != "")
            {
                double cm = int.Parse(tb_magassag.Text);
                double kg = double.Parse(tb_sulya.Text);
                BMI.bmi = kg / Math.Pow(cm / 100, 2);
                if (BMI.bmi < 18.49)
                {
                    BMI.kat = "Sovány";
                }
                else if (BMI.bmi > 18.49 && BMI.bmi < 24.99)
                {
                    BMI.kat = "Normál";
                }
                else if (BMI.bmi > 24.99 && BMI.bmi < 29.9)
                {
                    BMI.kat = "Túlsúly";
                }
                else if (BMI.bmi > 29.9)
                {
                    BMI.kat = "Elhízás";
                }

                l_bmiertek.Text = BMI.bmi.ToString("0.00");
                l_bmikat.Text = BMI.kat.ToString();
            }
        }

        private void Rogzites_Load(object sender, EventArgs e)
        {

        }

        private void tb_magassag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_magassag.Text != "")
                {
                    int cm = int.Parse(tb_magassag.Text);
                    szamol();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Csak számot adjon meg!");
                tb_magassag.Text = "";
                tb_magassag.Focus();
            }
        }

        private void tb_sulya_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_sulya.Text != "")
                {
                    double kg = double.Parse(tb_sulya.Text);
                    szamol();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("nem megfelelő bemeneti karakterlánc");
                tb_sulya.Text = "";
                tb_sulya.Focus();
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && tb_magassag.Text != "" && tb_sulya.Text != "" && cb_neme.SelectedItem.ToString() != "")
            {
                var sw = new StreamWriter("adatok.txt", true);
                sw.WriteLine(tb_name.Text + ";" + cb_neme.SelectedItem.ToString() + ";" + tb_magassag.Text + ";" + tb_sulya.Text + ";" + BMI.bmi + ";" + BMI.kat);
                sw.Close();
                MessageBox.Show("Mentve!", "mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("töltsön ki minden mezőt!");
            }
        }

        private void btn_elvet_Click(object sender, EventArgs e)
        {
            DialogResult ja = MessageBox.Show("Biztos elveti az adatokat?", "elveti?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ja == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
