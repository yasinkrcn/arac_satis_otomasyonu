namespace Araç_Satış_Otomasyonu
{
    partial class frmSözleşme
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
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblE_Yeri = new System.Windows.Forms.Label();
            this.txtEhliyetVerildigiYer = new System.Windows.Forms.TextBox();
            this.txtEhliyetTarihi = new System.Windows.Forms.TextBox();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblE_Tarihi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateDonus = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtModelYil = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiraSekli = new System.Windows.Forms.ComboBox();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSozlesmeEkle = new System.Windows.Forms.Button();
            this.btnSozlesmeGuncelle = new System.Windows.Forms.Button();
            this.btnAracTeslim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblE_Yeri);
            this.groupBox1.Controls.Add(this.txtEhliyetVerildigiYer);
            this.groupBox1.Controls.Add(this.txtEhliyetTarihi);
            this.groupBox1.Controls.Add(this.txtEhliyetNo);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.lblE_Tarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(136, 36);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(147, 26);
            this.txtTcAra.TabIndex = 12;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(40, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 21);
            this.label18.TabIndex = 11;
            this.label18.Text = "TC ARA";
            // 
            // lblE_Yeri
            // 
            this.lblE_Yeri.AutoSize = true;
            this.lblE_Yeri.Location = new System.Drawing.Point(16, 255);
            this.lblE_Yeri.Name = "lblE_Yeri";
            this.lblE_Yeri.Size = new System.Drawing.Size(93, 19);
            this.lblE_Yeri.TabIndex = 3;
            this.lblE_Yeri.Text = "E_Verildiği Yer";
            // 
            // txtEhliyetVerildigiYer
            // 
            this.txtEhliyetVerildigiYer.Location = new System.Drawing.Point(136, 253);
            this.txtEhliyetVerildigiYer.Name = "txtEhliyetVerildigiYer";
            this.txtEhliyetVerildigiYer.Size = new System.Drawing.Size(147, 26);
            this.txtEhliyetVerildigiYer.TabIndex = 10;
            // 
            // txtEhliyetTarihi
            // 
            this.txtEhliyetTarihi.Location = new System.Drawing.Point(136, 216);
            this.txtEhliyetTarihi.Name = "txtEhliyetTarihi";
            this.txtEhliyetTarihi.Size = new System.Drawing.Size(147, 26);
            this.txtEhliyetTarihi.TabIndex = 9;
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(136, 179);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(147, 26);
            this.txtEhliyetNo.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(136, 105);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(147, 26);
            this.txtAdSoyad.TabIndex = 6;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(136, 68);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(147, 26);
            this.txtTC.TabIndex = 5;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // lblE_Tarihi
            // 
            this.lblE_Tarihi.AutoSize = true;
            this.lblE_Tarihi.Location = new System.Drawing.Point(20, 219);
            this.lblE_Tarihi.Name = "lblE_Tarihi";
            this.lblE_Tarihi.Size = new System.Drawing.Size(84, 19);
            this.lblE_Tarihi.TabIndex = 4;
            this.lblE_Tarihi.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGun);
            this.groupBox2.Controls.Add(this.txtKiraUcreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtModelYil);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiraSekli);
            this.groupBox2.Controls.Add(this.comboAraclar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(647, 107);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 65);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(646, 182);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(110, 71);
            this.btnHesapla.TabIndex = 24;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dateDonus);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(489, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 73);
            this.panel2.TabIndex = 23;
            // 
            // dateDonus
            // 
            this.dateDonus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDonus.Location = new System.Drawing.Point(11, 31);
            this.dateDonus.Name = "dateDonus";
            this.dateDonus.Size = new System.Drawing.Size(114, 26);
            this.dateDonus.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "Dönüş Tarihi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateCikis);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(333, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 73);
            this.panel1.TabIndex = 22;
            // 
            // dateCikis
            // 
            this.dateCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCikis.Location = new System.Drawing.Point(15, 31);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(114, 26);
            this.dateCikis.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(418, 138);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(196, 26);
            this.txtTutar.TabIndex = 21;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(418, 99);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(196, 26);
            this.txtGun.TabIndex = 20;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(418, 60);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(196, 26);
            this.txtKiraUcreti.TabIndex = 19;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(95, 190);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(196, 26);
            this.txtRenk.TabIndex = 18;
            // 
            // txtModelYil
            // 
            this.txtModelYil.Location = new System.Drawing.Point(95, 149);
            this.txtModelYil.Name = "txtModelYil";
            this.txtModelYil.Size = new System.Drawing.Size(196, 26);
            this.txtModelYil.TabIndex = 17;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(95, 108);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(196, 26);
            this.txtSeri.TabIndex = 16;
            this.txtSeri.TextChanged += new System.EventHandler(this.txtSeri_TextChanged);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(95, 67);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(196, 26);
            this.txtMarka.TabIndex = 15;
            // 
            // comboKiraSekli
            // 
            this.comboKiraSekli.FormattingEnabled = true;
            this.comboKiraSekli.Items.AddRange(new object[] {
            "Günlük ",
            "Haftalık",
            "Aylık"});
            this.comboKiraSekli.Location = new System.Drawing.Point(418, 20);
            this.comboKiraSekli.Name = "comboKiraSekli";
            this.comboKiraSekli.Size = new System.Drawing.Size(196, 27);
            this.comboKiraSekli.TabIndex = 12;
            this.comboKiraSekli.SelectedIndexChanged += new System.EventHandler(this.comboKiraSekli_SelectedIndexChanged);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Location = new System.Drawing.Point(95, 25);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(196, 27);
            this.comboAraclar.TabIndex = 11;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(341, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 19);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Model(Yıl)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 321);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSozlesmeEkle
            // 
            this.btnSozlesmeEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnSozlesmeEkle.Location = new System.Drawing.Point(339, 278);
            this.btnSozlesmeEkle.Name = "btnSozlesmeEkle";
            this.btnSozlesmeEkle.Size = new System.Drawing.Size(132, 48);
            this.btnSozlesmeEkle.TabIndex = 24;
            this.btnSozlesmeEkle.Text = "Sözleşme Ekle";
            this.btnSozlesmeEkle.UseVisualStyleBackColor = false;
            this.btnSozlesmeEkle.Click += new System.EventHandler(this.btnSozlesmeEkle_Click);
            // 
            // btnSozlesmeGuncelle
            // 
            this.btnSozlesmeGuncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnSozlesmeGuncelle.Location = new System.Drawing.Point(489, 278);
            this.btnSozlesmeGuncelle.Name = "btnSozlesmeGuncelle";
            this.btnSozlesmeGuncelle.Size = new System.Drawing.Size(153, 48);
            this.btnSozlesmeGuncelle.TabIndex = 25;
            this.btnSozlesmeGuncelle.Text = "Sözleşme Güncelle";
            this.btnSozlesmeGuncelle.UseVisualStyleBackColor = false;
            this.btnSozlesmeGuncelle.Click += new System.EventHandler(this.btnSozlesmeGuncelle_Click);
            // 
            // btnAracTeslim
            // 
            this.btnAracTeslim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAracTeslim.Location = new System.Drawing.Point(971, 284);
            this.btnAracTeslim.Name = "btnAracTeslim";
            this.btnAracTeslim.Size = new System.Drawing.Size(132, 37);
            this.btnAracTeslim.TabIndex = 3;
            this.btnAracTeslim.Text = "Araç Teslim";
            this.btnAracTeslim.UseVisualStyleBackColor = false;
            this.btnAracTeslim.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Alacak/Verecek Durumu";
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(956, 340);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(147, 26);
            this.txtEkstra.TabIndex = 16;
            this.txtEkstra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(136, 141);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(147, 26);
            this.txtTelNo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon No";
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1125, 715);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSozlesmeGuncelle);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.btnAracTeslim);
            this.Controls.Add(this.btnSozlesmeEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSözleşme";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblE_Yeri;
        private TextBox txtEhliyetVerildigiYer;
        private TextBox txtEhliyetTarihi;
        private TextBox txtEhliyetNo;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label lblE_Tarihi;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Panel panel2;
        private DateTimePicker dateDonus;
        private Label label17;
        private Panel panel1;
        private DateTimePicker dateCikis;
        private Label label16;
        private TextBox txtTutar;
        private TextBox txtGun;
        private TextBox txtKiraUcreti;
        private TextBox txtRenk;
        private TextBox txtModelYil;
        private TextBox txtSeri;
        private TextBox txtMarka;
        private ComboBox comboKiraSekli;
        private ComboBox comboAraclar;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnSozlesmeEkle;
        private Button btnSozlesmeGuncelle;
        private Button btnAracTeslim;
        private Button btnHesapla;
        private Button btnTemizle;
        private TextBox txtTcAra;
        private Label label18;
        private Label label6;
        private TextBox txtEkstra;
        private TextBox txtTelNo;
        private Label label3;
    }
}