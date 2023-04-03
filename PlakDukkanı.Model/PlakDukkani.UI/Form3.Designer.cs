namespace PlakDukkani.UI
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            dgwAlbum = new DataGridView();
            btnEkle = new Button();
            lblAlbumAdi = new Label();
            txtAlbumAdi = new TextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpReleaseDate = new DateTimePicker();
            cbList = new ComboBox();
            label1 = new Label();
            txtArtistName = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnArtistSil = new Button();
            btnArtistGuncelle = new Button();
            btnArtistEkle = new Button();
            txtArtistDes = new TextBox();
            label6 = new Label();
            cbArtist = new ComboBox();
            nupPrice = new NumericUpDown();
            btnview = new Button();
            btnTumList = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgwAlbum).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrice).BeginInit();
            SuspendLayout();
            // 
            // dgwAlbum
            // 
            dgwAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAlbum.Location = new Point(880, 37);
            dgwAlbum.Margin = new Padding(4);
            dgwAlbum.Name = "dgwAlbum";
            dgwAlbum.RowHeadersWidth = 51;
            dgwAlbum.RowTemplate.Height = 29;
            dgwAlbum.Size = new Size(729, 676);
            dgwAlbum.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LimeGreen;
            btnEkle.Location = new Point(60, 599);
            btnEkle.Margin = new Padding(4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(184, 133);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblAlbumAdi
            // 
            lblAlbumAdi.AutoSize = true;
            lblAlbumAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumAdi.Location = new Point(76, 70);
            lblAlbumAdi.Margin = new Padding(4, 0, 4, 0);
            lblAlbumAdi.Name = "lblAlbumAdi";
            lblAlbumAdi.Size = new Size(125, 28);
            lblAlbumAdi.TabIndex = 2;
            lblAlbumAdi.Text = "Albüm Adı : ";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(246, 70);
            txtAlbumAdi.Margin = new Padding(4);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(271, 34);
            txtAlbumAdi.TabIndex = 3;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(491, 599);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(184, 133);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Salmon;
            btnGuncelle.Location = new Point(281, 599);
            btnGuncelle.Margin = new Padding(4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(184, 133);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GUNCELLE";
            toolTip1.SetToolTip(btnGuncelle, "Güncellemek istediğiniz veriyi yan tarafındki liste üzerinden değişiklik yaparak butona tıkladığınızda güncelleme gerçekleşir");
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 6;
            label2.Text = "Sanatçısı\\Grup :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 8;
            label3.Text = "Çıkış Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(124, 307);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 10;
            label4.Text = "Fiyat : ";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(246, 229);
            dtpReleaseDate.Margin = new Padding(4);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(271, 34);
            dtpReleaseDate.TabIndex = 12;
            // 
            // cbList
            // 
            cbList.FormattingEnabled = true;
            cbList.Items.AddRange(new object[] { "• Satışı durmuş albümler (Sadece albüm adı ve sanatçısı/grubu) (2 numaralı liste)", "• Satışı devam eden albümler (Sadece albüm adı ve sanatçısı/grubu) (3 numaralı liste)", "• Sisteme en son eklenen 10 albüm (Sadece albüm adı ve sanatçısı/grubu) (4 numaralı liste)", "• İndirimdeki albümler (Sadece albüm adı ve sanatçısı/grubu) (İndirim oranına göre sıralanmış olarak) (En çok indirim oranından en az indirim oranına doğru) (5 numaralı liste)" });
            cbList.Location = new Point(216, 422);
            cbList.Margin = new Padding(4);
            cbList.Name = "cbList";
            cbList.Size = new Size(627, 36);
            cbList.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 422);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 14;
            label1.Text = "Listeler : ";
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(22, 74);
            txtArtistName.Margin = new Padding(4);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(236, 34);
            txtArtistName.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 15;
            label5.Text = "Sanatcı Adı : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnArtistSil);
            groupBox1.Controls.Add(btnArtistGuncelle);
            groupBox1.Controls.Add(btnArtistEkle);
            groupBox1.Controls.Add(txtArtistDes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtArtistName);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(548, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 338);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sanatçı Ekle";
            // 
            // btnArtistSil
            // 
            btnArtistSil.BackColor = Color.Red;
            btnArtistSil.Location = new Point(141, 223);
            btnArtistSil.Margin = new Padding(4);
            btnArtistSil.Name = "btnArtistSil";
            btnArtistSil.Size = new Size(89, 48);
            btnArtistSil.TabIndex = 21;
            btnArtistSil.Text = "Sil";
            btnArtistSil.UseVisualStyleBackColor = false;
            btnArtistSil.Click += btnArtistSil_Click;
            // 
            // btnArtistGuncelle
            // 
            btnArtistGuncelle.BackColor = Color.Chocolate;
            btnArtistGuncelle.Location = new Point(62, 283);
            btnArtistGuncelle.Margin = new Padding(4);
            btnArtistGuncelle.Name = "btnArtistGuncelle";
            btnArtistGuncelle.Size = new Size(133, 48);
            btnArtistGuncelle.TabIndex = 20;
            btnArtistGuncelle.Text = "Güncelle";
            toolTip1.SetToolTip(btnArtistGuncelle, "Güncellemek istediğiniz sanatçıyı yan tarafdaki açılır listeden seçiniz");
            btnArtistGuncelle.UseVisualStyleBackColor = false;
            btnArtistGuncelle.Click += btnArtistGuncelle_Click;
            // 
            // btnArtistEkle
            // 
            btnArtistEkle.BackColor = Color.LimeGreen;
            btnArtistEkle.Location = new Point(22, 223);
            btnArtistEkle.Margin = new Padding(4);
            btnArtistEkle.Name = "btnArtistEkle";
            btnArtistEkle.Size = new Size(89, 48);
            btnArtistEkle.TabIndex = 19;
            btnArtistEkle.Text = "EKLE";
            btnArtistEkle.UseVisualStyleBackColor = false;
            btnArtistEkle.Click += btnArtistEkle_Click;
            // 
            // txtArtistDes
            // 
            txtArtistDes.Location = new Point(22, 170);
            txtArtistDes.Margin = new Padding(4);
            txtArtistDes.Name = "txtArtistDes";
            txtArtistDes.Size = new Size(236, 34);
            txtArtistDes.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(49, 123);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 28);
            label6.TabIndex = 17;
            label6.Text = "Açıklama : ";
            // 
            // cbArtist
            // 
            cbArtist.FormattingEnabled = true;
            cbArtist.Location = new Point(246, 150);
            cbArtist.Name = "cbArtist";
            cbArtist.Size = new Size(271, 36);
            cbArtist.TabIndex = 18;
            // 
            // nupPrice
            // 
            nupPrice.Location = new Point(246, 307);
            nupPrice.Name = "nupPrice";
            nupPrice.Size = new Size(271, 34);
            nupPrice.TabIndex = 19;
            // 
            // btnview
            // 
            btnview.BackColor = Color.Wheat;
            btnview.Location = new Point(625, 465);
            btnview.Name = "btnview";
            btnview.Size = new Size(218, 52);
            btnview.TabIndex = 20;
            btnview.Text = "Görüntüle";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnview_Click;
            // 
            // btnTumList
            // 
            btnTumList.BackColor = Color.Wheat;
            btnTumList.Location = new Point(682, 599);
            btnTumList.Name = "btnTumList";
            btnTumList.Size = new Size(184, 133);
            btnTumList.TabIndex = 21;
            btnTumList.Text = "Tümünü Görüntüle";
            btnTumList.UseVisualStyleBackColor = false;
            btnTumList.Click += btnTumList_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 744);
            Controls.Add(btnTumList);
            Controls.Add(btnview);
            Controls.Add(nupPrice);
            Controls.Add(cbArtist);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cbList);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(txtAlbumAdi);
            Controls.Add(lblAlbumAdi);
            Controls.Add(btnEkle);
            Controls.Add(dgwAlbum);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAlbum).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwAlbum;
        private Button btnEkle;
        private Label lblAlbumAdi;
        private TextBox txtAlbumAdi;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpReleaseDate;
        private ComboBox cbList;
        private Label label1;
        private TextBox txtArtistName;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtArtistDes;
        private Label label6;
        private ComboBox cbArtist;
        private Button btnArtistEkle;
        private Button btnArtistSil;
        private Button btnArtistGuncelle;
        private NumericUpDown nupPrice;
        private Button btnview;
        private Button btnTumList;
        private ToolTip toolTip1;
    }
}