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
    public partial class Statisztika : Form
    {
        public Statisztika()
        {
            InitializeComponent();
        }
        class adatok
        {
            // trolling 
            public ((string nev, string nem, double magassag, double suly) szemely, (double ertek, string kat) bmi) ember;
            public adatok(string be)
            {
                string[] dbok = be.Split(';');
                ember.szemely.nev = dbok[0];
                ember.szemely.nem = dbok[1];
                ember.szemely.magassag = double.Parse(dbok[2]);
                ember.szemely.suly = double.Parse(dbok[3]);
                ember.bmi.ertek = double.Parse(dbok[4]);
                ember.bmi.kat = dbok[5];
            }

        }
        List<adatok> adatokList = new List<adatok>();
        private void olvas()
        {
            dataGridView1.Rows.Clear();
            adatokList.Clear();
            var sr = new StreamReader("adatok.txt");
            while (!sr.EndOfStream)
            {
                adatokList.Add(new adatok(sr.ReadLine()));
            }
            sr.Close();
            foreach (var adat in adatokList)
            {
                dataGridView1.Rows.Add(adat.ember.szemely.nev, adat.ember.szemely.nem, adat.ember.szemely.magassag, adat.ember.szemely.suly, adat.ember.bmi.ertek, adat.ember.bmi.kat);
            }
        }
        private void Statisztika_Load(object sender, EventArgs e)
        {
            rb_ossz.Checked = true;
            cb_kat.Visible = false;
            if (File.Exists("adatok.txt"))
            {
                olvas();
            }
        }

        private void rb_ossz_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ossz.Checked)
            {
                olvas();
                foreach (var adat in adatokList)
                {
                    dataGridView1.Rows.Add(adat.ember.szemely.nev, adat.ember.szemely.nem, adat.ember.szemely.magassag, adat.ember.szemely.suly, adat.ember.bmi.ertek, adat.ember.bmi.kat);
                }
                l_ossz.Text=adatokList.Count.ToString();
                int fsz = adatokList.Count(x => x.ember.szemely.nem == "Férfi");
                int nsz = adatokList.Count(x => x.ember.szemely.nem == "Nő");
                l_fsz.Text = nsz.ToString();
                l_nsz.Text = fsz.ToString();
                l_fp.Text = ((double)fsz / (fsz + nsz) * 100).ToString();
                l_np.Text= ((double)nsz / (fsz + nsz) * 100).ToString();
                cb_kat.Visible = false;
            }

        }

        private void rb_szur_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_szur.Checked)
            {
                cb_kat.Visible = true;
                cb_kat.SelectedItem = 0;
            }
        }

        private void cb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            olvas();
            int i = 0;
            int f = 0;
            int n = 0;
            foreach (var adat in adatokList)
            {
                if (adat.ember.bmi.kat==cb_kat.SelectedItem.ToString())
                {
                    dataGridView1.Rows.Add(adat.ember.szemely.nev, adat.ember.szemely.nem, adat.ember.szemely.magassag, adat.ember.szemely.suly, adat.ember.bmi.ertek, adat.ember.bmi.kat);
                    i++;
                    if (adat.ember.szemely.nem=="Férfi")
                    {
                        f++;
                    }
                    else
                    {
                        n++;
                    }
                }
            }
            l_ossz.Text = i.ToString();
            l_fsz.Text = f.ToString();
            l_nsz.Text = n.ToString();
            l_fp.Text = ((double)f / (f + n) * 100).ToString();
            l_np.Text = ((double)n / (f + n) * 100).ToString();
        }
    }
}
