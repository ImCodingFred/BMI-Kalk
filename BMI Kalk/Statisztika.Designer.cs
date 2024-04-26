namespace BMI_Kalk
{
    partial class Statisztika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            nev = new DataGridViewTextBoxColumn();
            nem = new DataGridViewTextBoxColumn();
            magassag = new DataGridViewTextBoxColumn();
            suly = new DataGridViewTextBoxColumn();
            bmi = new DataGridViewTextBoxColumn();
            Kategoria = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cb_kat = new ComboBox();
            rb_szur = new RadioButton();
            rb_ossz = new RadioButton();
            label1 = new Label();
            l_ossz = new Label();
            label3 = new Label();
            l_fsz = new Label();
            l_fp = new Label();
            label4 = new Label();
            l_nsz = new Label();
            l_np = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nev, nem, magassag, suly, bmi, Kategoria });
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(393, 376);
            dataGridView1.TabIndex = 0;
            // 
            // nev
            // 
            nev.HeaderText = "Név";
            nev.Name = "nev";
            // 
            // nem
            // 
            nem.HeaderText = "Nem";
            nem.Name = "nem";
            // 
            // magassag
            // 
            magassag.HeaderText = "Magassag";
            magassag.Name = "magassag";
            // 
            // suly
            // 
            suly.HeaderText = "Súly";
            suly.Name = "suly";
            // 
            // bmi
            // 
            bmi.HeaderText = "BMI";
            bmi.Name = "bmi";
            // 
            // Kategoria
            // 
            Kategoria.HeaderText = "Kategória";
            Kategoria.Name = "Kategoria";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_kat);
            groupBox1.Controls.Add(rb_szur);
            groupBox1.Controls.Add(rb_ossz);
            groupBox1.Location = new Point(437, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Szűűűűrés";
            // 
            // cb_kat
            // 
            cb_kat.FormattingEnabled = true;
            cb_kat.Items.AddRange(new object[] { "Sovány", "Normál", "Túlsúly", "Elhízás" });
            cb_kat.Location = new Point(23, 90);
            cb_kat.Name = "cb_kat";
            cb_kat.Size = new Size(286, 23);
            cb_kat.TabIndex = 1;
            cb_kat.SelectedIndexChanged += cb_kat_SelectedIndexChanged;
            // 
            // rb_szur
            // 
            rb_szur.AutoSize = true;
            rb_szur.Location = new Point(23, 56);
            rb_szur.Name = "rb_szur";
            rb_szur.Size = new Size(112, 19);
            rb_szur.TabIndex = 0;
            rb_szur.TabStop = true;
            rb_szur.Text = "Kategória szerint";
            rb_szur.UseVisualStyleBackColor = true;
            rb_szur.CheckedChanged += rb_szur_CheckedChanged;
            // 
            // rb_ossz
            // 
            rb_ossz.AutoSize = true;
            rb_ossz.Location = new Point(23, 31);
            rb_ossz.Name = "rb_ossz";
            rb_ossz.Size = new Size(60, 19);
            rb_ossz.TabIndex = 0;
            rb_ossz.TabStop = true;
            rb_ossz.Text = "Összes";
            rb_ossz.UseVisualStyleBackColor = true;
            rb_ossz.CheckedChanged += rb_ossz_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 239);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Összes:";
            // 
            // l_ossz
            // 
            l_ossz.AutoSize = true;
            l_ossz.Location = new Point(545, 239);
            l_ossz.Name = "l_ossz";
            l_ossz.Size = new Size(38, 15);
            l_ossz.TabIndex = 2;
            l_ossz.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 294);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Férfi";
            // 
            // l_fsz
            // 
            l_fsz.AutoSize = true;
            l_fsz.Location = new Point(534, 294);
            l_fsz.Name = "l_fsz";
            l_fsz.Size = new Size(38, 15);
            l_fsz.TabIndex = 2;
            l_fsz.Text = "label1";
            // 
            // l_fp
            // 
            l_fp.AutoSize = true;
            l_fp.Location = new Point(604, 294);
            l_fp.Name = "l_fp";
            l_fp.Size = new Size(38, 15);
            l_fp.TabIndex = 2;
            l_fp.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 325);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 2;
            label4.Text = "Nő";
            // 
            // l_nsz
            // 
            l_nsz.AutoSize = true;
            l_nsz.Location = new Point(534, 325);
            l_nsz.Name = "l_nsz";
            l_nsz.Size = new Size(38, 15);
            l_nsz.TabIndex = 2;
            l_nsz.Text = "label1";
            // 
            // l_np
            // 
            l_np.AutoSize = true;
            l_np.Location = new Point(604, 325);
            l_np.Name = "l_np";
            l_np.Size = new Size(38, 15);
            l_np.TabIndex = 2;
            l_np.Text = "label1";
            // 
            // Statisztika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(l_np);
            Controls.Add(l_nsz);
            Controls.Add(l_fp);
            Controls.Add(label4);
            Controls.Add(l_fsz);
            Controls.Add(label3);
            Controls.Add(l_ossz);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Statisztika";
            Text = "Statisztika";
            Load += Statisztika_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox cb_kat;
        private RadioButton rb_szur;
        private RadioButton rb_ossz;
        private Label label1;
        private Label l_ossz;
        private Label label3;
        private Label l_fsz;
        private Label l_fp;
        private Label label4;
        private Label l_nsz;
        private Label l_np;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn nem;
        private DataGridViewTextBoxColumn magassag;
        private DataGridViewTextBoxColumn suly;
        private DataGridViewTextBoxColumn bmi;
        private DataGridViewTextBoxColumn Kategoria;
    }
}