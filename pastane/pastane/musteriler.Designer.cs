namespace pastane
{
    partial class musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmusteriadsoyad = new System.Windows.Forms.TextBox();
            this.txtmusterisiparisno = new System.Windows.Forms.TextBox();
            this.maskedtxttel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnraporlar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 89;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // txtmusteriadsoyad
            // 
            this.txtmusteriadsoyad.Location = new System.Drawing.Point(776, 320);
            this.txtmusteriadsoyad.Name = "txtmusteriadsoyad";
            this.txtmusteriadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriadsoyad.TabIndex = 93;
            // 
            // txtmusterisiparisno
            // 
            this.txtmusterisiparisno.Location = new System.Drawing.Point(776, 401);
            this.txtmusterisiparisno.Name = "txtmusterisiparisno";
            this.txtmusterisiparisno.Size = new System.Drawing.Size(100, 20);
            this.txtmusterisiparisno.TabIndex = 95;
            // 
            // maskedtxttel
            // 
            this.maskedtxttel.Location = new System.Drawing.Point(776, 360);
            this.maskedtxttel.Mask = "(999) 000-0000";
            this.maskedtxttel.Name = "maskedtxttel";
            this.maskedtxttel.Size = new System.Drawing.Size(100, 20);
            this.maskedtxttel.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(626, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(626, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "Müşteri Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(626, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "Sipariş No:";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Transparent;
            this.btnekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnekle.BackgroundImage")));
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnekle.Location = new System.Drawing.Point(911, 248);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(49, 42);
            this.btnekle.TabIndex = 101;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguncelle.BackgroundImage")));
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguncelle.Location = new System.Drawing.Point(911, 296);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(49, 42);
            this.btnguncelle.TabIndex = 102;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Transparent;
            this.btnara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnara.BackgroundImage")));
            this.btnara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnara.Location = new System.Drawing.Point(911, 344);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(49, 41);
            this.btnara.TabIndex = 103;
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsil.BackgroundImage")));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.Location = new System.Drawing.Point(911, 391);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(49, 42);
            this.btnsil.TabIndex = 104;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistele.BackgroundImage")));
            this.btnlistele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlistele.Location = new System.Drawing.Point(911, 441);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(49, 42);
            this.btnlistele.TabIndex = 105;
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(966, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 106;
            this.label4.Text = "Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(966, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Güncelle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(966, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 108;
            this.label7.Text = "Ara";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(966, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 109;
            this.label8.Text = "Sil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(966, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 110;
            this.label9.Text = "Listele";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 161);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnraporlar
            // 
            this.btnraporlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnraporlar.BackgroundImage")));
            this.btnraporlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnraporlar.Location = new System.Drawing.Point(911, 489);
            this.btnraporlar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnraporlar.Name = "btnraporlar";
            this.btnraporlar.Size = new System.Drawing.Size(49, 44);
            this.btnraporlar.TabIndex = 112;
            this.btnraporlar.UseVisualStyleBackColor = true;
            this.btnraporlar.Click += new System.EventHandler(this.btnraporlar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(967, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 113;
            this.label10.Text = "Raporlar";
            // 
            // musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 552);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnraporlar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedtxttel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmusterisiparisno);
            this.Controls.Add(this.txtmusteriadsoyad);
            this.Controls.Add(this.menuStrip1);
            this.Name = "musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİLER";
            // this.Load += new System.EventHandler(this.musteriler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TextBox txtmusteriadsoyad;
        private System.Windows.Forms.TextBox txtmusterisiparisno;
        private System.Windows.Forms.MaskedTextBox maskedtxttel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnraporlar;
        private System.Windows.Forms.Label label10;
    }
}