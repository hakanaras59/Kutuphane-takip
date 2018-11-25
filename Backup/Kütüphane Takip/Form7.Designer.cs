namespace Kütüphane_Takip
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kimlikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şuanKiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kirayaVerilişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiraBitişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneDataSet24 = new Kütüphane_Takip.kütüphaneDataSet24();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmtrihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aldığıKitapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitabıAldığıTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncilistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrncilistDataSet14 = new Kütüphane_Takip.ogrncilistDataSet14();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ogrncilistTableAdapter = new Kütüphane_Takip.ogrncilistDataSet14TableAdapters.ogrncilistTableAdapter();
            this.kitaplistTableAdapter = new Kütüphane_Takip.kütüphaneDataSet24TableAdapters.kitaplistTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet24)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrncilistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrncilistDataSet14)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Kitaplar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1016, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Listeyi Yenile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1016, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1034, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod No\'ya Göre";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1132, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kimlikDataGridViewTextBoxColumn1,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.yayinEviDataGridViewTextBoxColumn,
            this.kitapTürüDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.verilişTarihiDataGridViewTextBoxColumn,
            this.şuanKiradaDataGridViewTextBoxColumn,
            this.kirayaVerilişTarihiDataGridViewTextBoxColumn,
            this.kiraBitişTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 143);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kimlikDataGridViewTextBoxColumn1
            // 
            this.kimlikDataGridViewTextBoxColumn1.DataPropertyName = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn1.HeaderText = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn1.Name = "kimlikDataGridViewTextBoxColumn1";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "Kitap_Adi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap_Adi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // yazarAdiDataGridViewTextBoxColumn
            // 
            this.yazarAdiDataGridViewTextBoxColumn.DataPropertyName = "Yazar_Adi";
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "Yazar_Adi";
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            // 
            // yayinEviDataGridViewTextBoxColumn
            // 
            this.yayinEviDataGridViewTextBoxColumn.DataPropertyName = "Yayin_Evi";
            this.yayinEviDataGridViewTextBoxColumn.HeaderText = "Yayin_Evi";
            this.yayinEviDataGridViewTextBoxColumn.Name = "yayinEviDataGridViewTextBoxColumn";
            // 
            // kitapTürüDataGridViewTextBoxColumn
            // 
            this.kitapTürüDataGridViewTextBoxColumn.DataPropertyName = "Kitap_Türü";
            this.kitapTürüDataGridViewTextBoxColumn.HeaderText = "Kitap_Türü";
            this.kitapTürüDataGridViewTextBoxColumn.Name = "kitapTürüDataGridViewTextBoxColumn";
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "Barkod_No";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "Barkod_No";
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            // 
            // verilişTarihiDataGridViewTextBoxColumn
            // 
            this.verilişTarihiDataGridViewTextBoxColumn.DataPropertyName = "Veriliş_Tarihi";
            this.verilişTarihiDataGridViewTextBoxColumn.HeaderText = "Veriliş_Tarihi";
            this.verilişTarihiDataGridViewTextBoxColumn.Name = "verilişTarihiDataGridViewTextBoxColumn";
            // 
            // şuanKiradaDataGridViewTextBoxColumn
            // 
            this.şuanKiradaDataGridViewTextBoxColumn.DataPropertyName = "Şuan_Kirada";
            this.şuanKiradaDataGridViewTextBoxColumn.HeaderText = "Şuan_Kirada";
            this.şuanKiradaDataGridViewTextBoxColumn.Name = "şuanKiradaDataGridViewTextBoxColumn";
            // 
            // kirayaVerilişTarihiDataGridViewTextBoxColumn
            // 
            this.kirayaVerilişTarihiDataGridViewTextBoxColumn.DataPropertyName = "Kiraya_Veriliş_Tarihi";
            this.kirayaVerilişTarihiDataGridViewTextBoxColumn.HeaderText = "Kiraya_Veriliş_Tarihi";
            this.kirayaVerilişTarihiDataGridViewTextBoxColumn.Name = "kirayaVerilişTarihiDataGridViewTextBoxColumn";
            // 
            // kiraBitişTarihiDataGridViewTextBoxColumn
            // 
            this.kiraBitişTarihiDataGridViewTextBoxColumn.DataPropertyName = "Kira_Bitiş_Tarihi";
            this.kiraBitişTarihiDataGridViewTextBoxColumn.HeaderText = "Kira_Bitiş_Tarihi";
            this.kiraBitişTarihiDataGridViewTextBoxColumn.Name = "kiraBitişTarihiDataGridViewTextBoxColumn";
            // 
            // kitaplistBindingSource
            // 
            this.kitaplistBindingSource.DataMember = "kitaplist";
            this.kitaplistBindingSource.DataSource = this.kütüphaneDataSet24;
            // 
            // kütüphaneDataSet24
            // 
            this.kütüphaneDataSet24.DataSetName = "kütüphaneDataSet24";
            this.kütüphaneDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1216, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üyeler";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1016, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Listeyi Yenile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1016, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1034, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No\'ya Göre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1132, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kimlikDataGridViewTextBoxColumn,
            this.tckimlikDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.dgmtrihiDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.aldığıKitapDataGridViewTextBoxColumn,
            this.kitabıAldığıTarihDataGridViewTextBoxColumn,
            this.kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ogrncilistBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1004, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // kimlikDataGridViewTextBoxColumn
            // 
            this.kimlikDataGridViewTextBoxColumn.DataPropertyName = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.Name = "kimlikDataGridViewTextBoxColumn";
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            // 
            // dgmtrihiDataGridViewTextBoxColumn
            // 
            this.dgmtrihiDataGridViewTextBoxColumn.DataPropertyName = "dgm_trihi";
            this.dgmtrihiDataGridViewTextBoxColumn.HeaderText = "dgm_trihi";
            this.dgmtrihiDataGridViewTextBoxColumn.Name = "dgmtrihiDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // aldığıKitapDataGridViewTextBoxColumn
            // 
            this.aldığıKitapDataGridViewTextBoxColumn.DataPropertyName = "AldığıKitap";
            this.aldığıKitapDataGridViewTextBoxColumn.HeaderText = "AldığıKitap";
            this.aldığıKitapDataGridViewTextBoxColumn.Name = "aldığıKitapDataGridViewTextBoxColumn";
            // 
            // kitabıAldığıTarihDataGridViewTextBoxColumn
            // 
            this.kitabıAldığıTarihDataGridViewTextBoxColumn.DataPropertyName = "Kitabı_Aldığı_Tarih";
            this.kitabıAldığıTarihDataGridViewTextBoxColumn.HeaderText = "Kitabı_Aldığı_Tarih";
            this.kitabıAldığıTarihDataGridViewTextBoxColumn.Name = "kitabıAldığıTarihDataGridViewTextBoxColumn";
            // 
            // kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn
            // 
            this.kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn.DataPropertyName = "Kitabın_Verilmesi_Gereken_Tarih";
            this.kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn.HeaderText = "Kitabın_Verilmesi_Gereken_Tarih";
            this.kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn.Name = "kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn";
            // 
            // ogrncilistBindingSource
            // 
            this.ogrncilistBindingSource.DataMember = "ogrncilist";
            this.ogrncilistBindingSource.DataSource = this.ogrncilistDataSet14;
            // 
            // ogrncilistDataSet14
            // 
            this.ogrncilistDataSet14.DataSetName = "ogrncilistDataSet14";
            this.ogrncilistDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "VER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogrncilistTableAdapter
            // 
            this.ogrncilistTableAdapter.ClearBeforeFill = true;
            // 
            // kitaplistTableAdapter
            // 
            this.kitaplistTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1216, 48);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(759, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Akıllı Gösterge Aç";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1132, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Çıkış";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1000, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ana Menü";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1016, 119);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(191, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "Sadece Gecikmişleri Göster";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1016, 125);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(191, 40);
            this.button10.TabIndex = 10;
            this.button10.Text = "Sadece Gecikmişleri Göster";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1239, 433);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.Text = "Kitap Kirala/Teslim Al";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet24)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrncilistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrncilistDataSet14)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ogrncilistDataSet14 ogrncilistDataSet14;
        private System.Windows.Forms.BindingSource ogrncilistBindingSource;
        private Kütüphane_Takip.ogrncilistDataSet14TableAdapters.ogrncilistTableAdapter ogrncilistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmtrihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aldığıKitapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitabıAldığıTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitabınVerilmesiGerekenTarihDataGridViewTextBoxColumn;
        private kütüphaneDataSet24 kütüphaneDataSet24;
        private System.Windows.Forms.BindingSource kitaplistBindingSource;
        private Kütüphane_Takip.kütüphaneDataSet24TableAdapters.kitaplistTableAdapter kitaplistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şuanKiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kirayaVerilişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiraBitişTarihiDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}