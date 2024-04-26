namespace BMI_Kalk
{
    partial class Rogzites
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_name = new TextBox();
            tb_magassag = new TextBox();
            btn_ment = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_sulya = new TextBox();
            btn_elvet = new Button();
            cb_neme = new ComboBox();
            l_bmiertek = new Label();
            l_bmikat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 41);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Neve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 110);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "Magassága [cm]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(69, 182);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            label3.Text = "BMI érték";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(109, 38);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(238, 23);
            tb_name.TabIndex = 1;
            // 
            // tb_magassag
            // 
            tb_magassag.Location = new Point(169, 107);
            tb_magassag.Name = "tb_magassag";
            tb_magassag.Size = new Size(100, 23);
            tb_magassag.TabIndex = 1;
            tb_magassag.TextChanged += tb_magassag_TextChanged;
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(95, 237);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(174, 44);
            btn_ment.TabIndex = 2;
            btn_ment.Text = "Mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 41);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Neme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 110);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 0;
            label5.Text = "Súlya";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(404, 182);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 0;
            label6.Text = "BMI kategória";
            // 
            // tb_sulya
            // 
            tb_sulya.Location = new Point(448, 107);
            tb_sulya.Name = "tb_sulya";
            tb_sulya.Size = new Size(100, 23);
            tb_sulya.TabIndex = 1;
            tb_sulya.TextChanged += tb_sulya_TextChanged;
            // 
            // btn_elvet
            // 
            btn_elvet.Location = new Point(382, 237);
            btn_elvet.Name = "btn_elvet";
            btn_elvet.Size = new Size(166, 44);
            btn_elvet.TabIndex = 2;
            btn_elvet.Text = "Elvetés";
            btn_elvet.UseVisualStyleBackColor = true;
            btn_elvet.Click += btn_elvet_Click;
            // 
            // cb_neme
            // 
            cb_neme.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_neme.FormattingEnabled = true;
            cb_neme.Items.AddRange(new object[] { "Férfi", "Nő" });
            cb_neme.Location = new Point(448, 38);
            cb_neme.Name = "cb_neme";
            cb_neme.Size = new Size(121, 23);
            cb_neme.TabIndex = 3;
            // 
            // l_bmiertek
            // 
            l_bmiertek.AutoSize = true;
            l_bmiertek.ForeColor = Color.Red;
            l_bmiertek.Location = new Point(140, 182);
            l_bmiertek.Name = "l_bmiertek";
            l_bmiertek.Size = new Size(40, 15);
            l_bmiertek.TabIndex = 0;
            l_bmiertek.Text = "label1";
            // 
            // l_bmikat
            // 
            l_bmikat.AutoSize = true;
            l_bmikat.ForeColor = Color.Red;
            l_bmikat.Location = new Point(490, 182);
            l_bmikat.Name = "l_bmikat";
            l_bmikat.Size = new Size(40, 15);
            l_bmikat.TabIndex = 0;
            l_bmikat.Text = "label1";
            // 
            // Rogzites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 344);
            Controls.Add(cb_neme);
            Controls.Add(btn_elvet);
            Controls.Add(btn_ment);
            Controls.Add(tb_sulya);
            Controls.Add(tb_magassag);
            Controls.Add(l_bmikat);
            Controls.Add(label6);
            Controls.Add(tb_name);
            Controls.Add(label5);
            Controls.Add(l_bmiertek);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "Rogzites";
            Text = "Rogzites";
            Load += Rogzites_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_name;
        private TextBox tb_magassag;
        private Button btn_ment;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_sulya;
        private Button btn_elvet;
        private ComboBox cb_neme;
        private Label l_bmiertek;
        private Label l_bmikat;
    }
}