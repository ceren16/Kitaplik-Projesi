
namespace Kitaplik_Projesi
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdKullanılmıs = new System.Windows.Forms.RadioButton();
            this.rdSifir = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtbul = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 296);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 142);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Yazar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kitap Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap Tür :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Durum : ";
            // 
            // rdKullanılmıs
            // 
            this.rdKullanılmıs.AutoSize = true;
            this.rdKullanılmıs.Location = new System.Drawing.Point(188, 223);
            this.rdKullanılmıs.Name = "rdKullanılmıs";
            this.rdKullanılmıs.Size = new System.Drawing.Size(83, 22);
            this.rdKullanılmıs.TabIndex = 12;
            this.rdKullanılmıs.TabStop = true;
            this.rdKullanılmıs.Text = "İkinci El";
            this.rdKullanılmıs.UseVisualStyleBackColor = true;
            this.rdKullanılmıs.CheckedChanged += new System.EventHandler(this.rdKullanılmıs_CheckedChanged);
            // 
            // rdSifir
            // 
            this.rdSifir.AutoSize = true;
            this.rdSifir.Location = new System.Drawing.Point(308, 225);
            this.rdSifir.Name = "rdSifir";
            this.rdSifir.Size = new System.Drawing.Size(53, 22);
            this.rdSifir.TabIndex = 13;
            this.rdSifir.TabStop = true;
            this.rdSifir.Text = "Sıfır";
            this.rdSifir.UseVisualStyleBackColor = true;
            this.rdSifir.CheckedChanged += new System.EventHandler(this.rdSifir_CheckedChanged);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(475, 40);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(172, 36);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(475, 82);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(172, 41);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(475, 129);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(172, 38);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(475, 173);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 35);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(188, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 25);
            this.txtID.TabIndex = 18;
            // 
            // txtbul
            // 
            this.txtbul.Location = new System.Drawing.Point(475, 225);
            this.txtbul.Name = "txtbul";
            this.txtbul.Size = new System.Drawing.Size(172, 25);
            this.txtbul.TabIndex = 19;
            this.txtbul.TextChanged += new System.EventHandler(this.txtbul_TextChanged);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(188, 115);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(171, 25);
            this.txtYazar.TabIndex = 20;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(188, 148);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(171, 25);
            this.txtSayfa.TabIndex = 21;
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir"});
            this.cmbTur.Location = new System.Drawing.Point(188, 182);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(171, 26);
            this.cmbTur.TabIndex = 23;
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(475, 256);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(75, 33);
            this.btnbul.TabIndex = 24;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(188, 82);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 25);
            this.txtAd.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kitap Ad :";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(572, 256);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 33);
            this.btnara.TabIndex = 27;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtbul);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.rdSifir);
            this.Controls.Add(this.rdKullanılmıs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdKullanılmıs;
        private System.Windows.Forms.RadioButton rdSifir;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtbul;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnara;
    }
}

