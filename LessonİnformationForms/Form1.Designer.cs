
namespace LessonİnformationForms
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
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.bYeniDers = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bDetaylar = new System.Windows.Forms.Button();
            this.gbYeni = new System.Windows.Forms.GroupBox();
            this.bKaydet = new System.Windows.Forms.Button();
            this.nudKredi = new System.Windows.Forms.NumericUpDown();
            this.ddlKategori = new System.Windows.Forms.ComboBox();
            this.tbİcerigi = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.lİcerik = new System.Windows.Forms.Label();
            this.lKredisi = new System.Windows.Forms.Label();
            this.lKategorisi = new System.Windows.Forms.Label();
            this.lAdi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.gbYeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDersler.Location = new System.Drawing.Point(-1, 0);
            this.dgvDersler.MultiSelect = false;
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(809, 236);
            this.dgvDersler.TabIndex = 0;
            // 
            // bYeniDers
            // 
            this.bYeniDers.Location = new System.Drawing.Point(8, 242);
            this.bYeniDers.Name = "bYeniDers";
            this.bYeniDers.Size = new System.Drawing.Size(115, 33);
            this.bYeniDers.TabIndex = 1;
            this.bYeniDers.Text = "Yeni Ders Ekle";
            this.bYeniDers.UseVisualStyleBackColor = true;
            this.bYeniDers.Click += new System.EventHandler(this.bYeniDers_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(169, 242);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(91, 33);
            this.bSil.TabIndex = 1;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bDetaylar
            // 
            this.bDetaylar.Location = new System.Drawing.Point(595, 242);
            this.bDetaylar.Name = "bDetaylar";
            this.bDetaylar.Size = new System.Drawing.Size(164, 33);
            this.bDetaylar.TabIndex = 1;
            this.bDetaylar.Text = "DETAYLAR";
            this.bDetaylar.UseVisualStyleBackColor = true;
            this.bDetaylar.Click += new System.EventHandler(this.bDetaylar_Click);
            // 
            // gbYeni
            // 
            this.gbYeni.Controls.Add(this.btnKaydet);
            this.gbYeni.Controls.Add(this.bKaydet);
            this.gbYeni.Controls.Add(this.nudKredi);
            this.gbYeni.Controls.Add(this.ddlKategori);
            this.gbYeni.Controls.Add(this.tbİcerigi);
            this.gbYeni.Controls.Add(this.tbAdi);
            this.gbYeni.Controls.Add(this.lİcerik);
            this.gbYeni.Controls.Add(this.lKredisi);
            this.gbYeni.Controls.Add(this.lKategorisi);
            this.gbYeni.Controls.Add(this.lAdi);
            this.gbYeni.Location = new System.Drawing.Point(-1, 298);
            this.gbYeni.Name = "gbYeni";
            this.gbYeni.Size = new System.Drawing.Size(799, 152);
            this.gbYeni.TabIndex = 2;
            this.gbYeni.TabStop = false;
            this.gbYeni.Text = "groupBox1";
            this.gbYeni.Visible = false;
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(596, 29);
            this.bKaydet.MaximumSize = new System.Drawing.Size(1, 0);
            this.bKaydet.MinimumSize = new System.Drawing.Size(5, 0);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(5, 0);
            this.bKaydet.TabIndex = 5;
            this.bKaydet.Text = "KAYDET";
            this.bKaydet.UseVisualStyleBackColor = true;

            // 
            // nudKredi
            // 
            this.nudKredi.Location = new System.Drawing.Point(398, 104);
            this.nudKredi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKredi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKredi.Name = "nudKredi";
            this.nudKredi.Size = new System.Drawing.Size(100, 20);
            this.nudKredi.TabIndex = 5;
            this.nudKredi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKredi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ddlKategori
            // 
            this.ddlKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKategori.FormattingEnabled = true;
            this.ddlKategori.Location = new System.Drawing.Point(398, 46);
            this.ddlKategori.Name = "ddlKategori";
            this.ddlKategori.Size = new System.Drawing.Size(100, 21);
            this.ddlKategori.TabIndex = 4;
            // 
            // tbİcerigi
            // 
            this.tbİcerigi.Location = new System.Drawing.Point(90, 104);
            this.tbİcerigi.Name = "tbİcerigi";
            this.tbİcerigi.Size = new System.Drawing.Size(100, 20);
            this.tbİcerigi.TabIndex = 3;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(90, 47);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(100, 20);
            this.tbAdi.TabIndex = 2;
            // 
            // lİcerik
            // 
            this.lİcerik.AutoSize = true;
            this.lİcerik.Location = new System.Drawing.Point(6, 111);
            this.lİcerik.Name = "lİcerik";
            this.lİcerik.Size = new System.Drawing.Size(35, 13);
            this.lİcerik.TabIndex = 1;
            this.lİcerik.Text = "İcerigi";
            // 
            // lKredisi
            // 
            this.lKredisi.AutoSize = true;
            this.lKredisi.Location = new System.Drawing.Point(282, 111);
            this.lKredisi.Name = "lKredisi";
            this.lKredisi.Size = new System.Drawing.Size(41, 13);
            this.lKredisi.TabIndex = 1;
            this.lKredisi.Text = "Kredisi:";
            // 
            // lKategorisi
            // 
            this.lKategorisi.AutoSize = true;
            this.lKategorisi.Location = new System.Drawing.Point(282, 54);
            this.lKategorisi.Name = "lKategorisi";
            this.lKategorisi.Size = new System.Drawing.Size(53, 13);
            this.lKategorisi.TabIndex = 1;
            this.lKategorisi.Text = "Kategorisi";
            // 
            // lAdi
            // 
            this.lAdi.AutoSize = true;
            this.lAdi.Location = new System.Drawing.Point(6, 54);
            this.lAdi.Name = "lAdi";
            this.lAdi.Size = new System.Drawing.Size(22, 13);
            this.lAdi.TabIndex = 0;
            this.lAdi.Text = "Adi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(596, 46);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(164, 78);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbYeni);
            this.Controls.Add(this.bDetaylar);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bYeniDers);
            this.Controls.Add(this.dgvDersler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.gbYeni.ResumeLayout(false);
            this.gbYeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button bYeniDers;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bDetaylar;
        private System.Windows.Forms.GroupBox gbYeni;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.NumericUpDown nudKredi;
        private System.Windows.Forms.ComboBox ddlKategori;
        private System.Windows.Forms.TextBox tbİcerigi;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label lİcerik;
        private System.Windows.Forms.Label lKredisi;
        private System.Windows.Forms.Label lKategorisi;
        private System.Windows.Forms.Label lAdi;
        private System.Windows.Forms.Button btnKaydet;
    }
}

