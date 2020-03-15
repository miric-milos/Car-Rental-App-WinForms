namespace tvpProjekatPrvi
{
    partial class frmRezervacija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrikaziTermine = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBrVrata = new System.Windows.Forms.ComboBox();
            this.cmbMenjac = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPogon = new System.Windows.Forms.ComboBox();
            this.cmbGodiste = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKubikaza = new System.Windows.Forms.ComboBox();
            this.cmbGorivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKaroserija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.datePreuzimanje = new System.Windows.Forms.DateTimePicker();
            this.dateVracanje = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnPrikaziTermine);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbBrVrata);
            this.groupBox1.Controls.Add(this.cmbMenjac);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbPogon);
            this.groupBox1.Controls.Add(this.cmbGodiste);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbKubikaza);
            this.groupBox1.Controls.Add(this.cmbGorivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbKaroserija);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir automobila i termina";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(299, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 364);
            this.listBox1.TabIndex = 18;
            // 
            // btnPrikaziTermine
            // 
            this.btnPrikaziTermine.Location = new System.Drawing.Point(6, 360);
            this.btnPrikaziTermine.Name = "btnPrikaziTermine";
            this.btnPrikaziTermine.Size = new System.Drawing.Size(277, 60);
            this.btnPrikaziTermine.TabIndex = 1;
            this.btnPrikaziTermine.Text = "Prikazi dostupne termine ";
            this.btnPrikaziTermine.UseVisualStyleBackColor = true;
            this.btnPrikaziTermine.Click += new System.EventHandler(this.btnPrikaziTermine_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Broj vrata";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Menjac";
            // 
            // cmbBrVrata
            // 
            this.cmbBrVrata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrVrata.FormattingEnabled = true;
            this.cmbBrVrata.Location = new System.Drawing.Point(6, 269);
            this.cmbBrVrata.Name = "cmbBrVrata";
            this.cmbBrVrata.Size = new System.Drawing.Size(132, 26);
            this.cmbBrVrata.TabIndex = 15;
            this.cmbBrVrata.SelectedIndexChanged += new System.EventHandler(this.cmbBrVrata_SelectedIndexChanged);
            // 
            // cmbMenjac
            // 
            this.cmbMenjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenjac.FormattingEnabled = true;
            this.cmbMenjac.Location = new System.Drawing.Point(151, 219);
            this.cmbMenjac.Name = "cmbMenjac";
            this.cmbMenjac.Size = new System.Drawing.Size(132, 26);
            this.cmbMenjac.TabIndex = 14;
            this.cmbMenjac.SelectedIndexChanged += new System.EventHandler(this.cmbMenjac_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pogon";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(6, 119);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(132, 26);
            this.cmbModel.TabIndex = 3;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Godiste";
            // 
            // cmbPogon
            // 
            this.cmbPogon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPogon.FormattingEnabled = true;
            this.cmbPogon.Location = new System.Drawing.Point(6, 219);
            this.cmbPogon.Name = "cmbPogon";
            this.cmbPogon.Size = new System.Drawing.Size(132, 26);
            this.cmbPogon.TabIndex = 11;
            this.cmbPogon.SelectedIndexChanged += new System.EventHandler(this.cmbPogon_SelectedIndexChanged);
            // 
            // cmbGodiste
            // 
            this.cmbGodiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodiste.FormattingEnabled = true;
            this.cmbGodiste.Location = new System.Drawing.Point(151, 269);
            this.cmbGodiste.Name = "cmbGodiste";
            this.cmbGodiste.Size = new System.Drawing.Size(132, 26);
            this.cmbGodiste.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Karoserija";
            // 
            // cmbKubikaza
            // 
            this.cmbKubikaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKubikaza.FormattingEnabled = true;
            this.cmbKubikaza.Location = new System.Drawing.Point(6, 169);
            this.cmbKubikaza.Name = "cmbKubikaza";
            this.cmbKubikaza.Size = new System.Drawing.Size(132, 26);
            this.cmbKubikaza.TabIndex = 7;
            this.cmbKubikaza.SelectedIndexChanged += new System.EventHandler(this.cmbKubikaza_SelectedIndexChanged);
            // 
            // cmbGorivo
            // 
            this.cmbGorivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGorivo.FormattingEnabled = true;
            this.cmbGorivo.Location = new System.Drawing.Point(151, 119);
            this.cmbGorivo.Name = "cmbGorivo";
            this.cmbGorivo.Size = new System.Drawing.Size(132, 26);
            this.cmbGorivo.TabIndex = 6;
            this.cmbGorivo.SelectedIndexChanged += new System.EventHandler(this.cmbGorivo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kubikaza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gorivo";
            // 
            // cmbKaroserija
            // 
            this.cmbKaroserija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKaroserija.FormattingEnabled = true;
            this.cmbKaroserija.Location = new System.Drawing.Point(151, 169);
            this.cmbKaroserija.Name = "cmbKaroserija";
            this.cmbKaroserija.Size = new System.Drawing.Size(132, 26);
            this.cmbKaroserija.TabIndex = 2;
            this.cmbKaroserija.SelectedIndexChanged += new System.EventHandler(this.cmbKaroserija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite marku";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DisplayMember = "Audi";
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(6, 52);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(277, 26);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // datePreuzimanje
            // 
            this.datePreuzimanje.Location = new System.Drawing.Point(6, 65);
            this.datePreuzimanje.Name = "datePreuzimanje";
            this.datePreuzimanje.Size = new System.Drawing.Size(200, 24);
            this.datePreuzimanje.TabIndex = 0;
            this.datePreuzimanje.ValueChanged += new System.EventHandler(this.datePreuzimanje_ValueChanged_1);
            // 
            // dateVracanje
            // 
            this.dateVracanje.Location = new System.Drawing.Point(6, 117);
            this.dateVracanje.Name = "dateVracanje";
            this.dateVracanje.Size = new System.Drawing.Size(200, 24);
            this.dateVracanje.TabIndex = 1;
            this.dateVracanje.ValueChanged += new System.EventHandler(this.dateVracanje_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Datum preuzimanja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Datum vracanja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Cena rezervacije:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNazad);
            this.groupBox2.Controls.Add(this.btnRezervisi);
            this.groupBox2.Controls.Add(this.txtUkupnaCena);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateVracanje);
            this.groupBox2.Controls.Add(this.datePreuzimanje);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(625, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervacija";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(6, 384);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(224, 36);
            this.btnNazad.TabIndex = 24;
            this.btnNazad.Text = "Nazad na nalog";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Location = new System.Drawing.Point(6, 342);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(224, 36);
            this.btnRezervisi.TabIndex = 19;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUkupnaCena.Location = new System.Drawing.Point(131, 251);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(75, 24);
            this.txtUkupnaCena.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Odaberite ponudu";
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrikaziTermine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBrVrata;
        private System.Windows.Forms.ComboBox cmbMenjac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPogon;
        private System.Windows.Forms.ComboBox cmbGodiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKubikaza;
        private System.Windows.Forms.ComboBox cmbGorivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbKaroserija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker datePreuzimanje;
        private System.Windows.Forms.DateTimePicker dateVracanje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label label13;
    }
}

