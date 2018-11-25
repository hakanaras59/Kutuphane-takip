namespace Kütüphane_Takip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneDataSet25 = new Kütüphane_Takip.kütüphaneDataSet25();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitaplistTableAdapter = new Kütüphane_Takip.kütüphaneDataSet25TableAdapters.kitaplistTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet25)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(329, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aforizmalar",
            "Ahlak",
            "Aile Bilgileri",
            "Aile/İnsan",
            "Aile/İnsan - Kadın",
            "Aksiyon ve Macera",
            "Anı",
            "Anı ve İnceleme",
            "Anı ve Seyahatname",
            "Anı, Mektup, Müzik",
            "Anı-Günlük-Mektup",
            "Anı/Gezi",
            "Anılar ve Biyografiler",
            "Anlatı",
            "Ansiklopedi",
            "Antoloji",
            "Antropoloji",
            "Araştırma",
            "Aritmetik,Cebir,Geometri",
            "Arkeoloji",
            "Arkeoloji ve Eski Çağ",
            "Askerlik Bilimi",
            "Askerlik ve Ordu",
            "Astroloji",
            "Astronomi ve YerBilimleri",
            "Aşk / Roman",
            "Aşk Şiirleri",
            "Aşk ve Romantizm",
            "Atatürk",
            "Atatürkçülük / Kemalizm",
            "Atlaslar, Planlar, Rehber",
            "Avcılık / Balıkçılık / Sp",
            "Avrupa Tarihi",
            "Azınlıklar ve Etnik Grup",
            "Balkanlar Tarihi",
            "Bankacılık",
            "Basın Yayın Tarihi",
            "Başvuru Eserleri",
            "Batı Resim Sanatı",
            "Belge/İnceleme",
            "Belgesel",
            "Belirtilmemiş",
            "Bilgi Kuramı/Epistemoloji",
            "Bilgisayar",
            "Bilim",
            "Bilim - Astronomi",
            "Bilim - Jeoloji - Deprem",
            "Bilim - Popüler bilim",
            "Bilim - Teknoloji",
            "Bilim Kurgu",
            "Bilim Tarihi",
            "Bilim-Biyoloji ve Genetik",
            "Bilim-Teknik",
            "Bilim/Ekoloji",
            "Bitkiler Alemi",
            "Biyografi",
            "Biyografi ve Anı",
            "Biyografi/Otobiyografi",
            "Büro ve Yönetimi",
            "Büyü,Gizem ve Kehanet",
            "Ceza Hukuku",
            "Cinsellik",
            "Cinsellik ve Üreme Etiği",
            "Coğrafya ve Seyahat",
            "Cumhuriyet Dönemi Öykü",
            "Cumhuriyet Tarihi",
            "Çağdaş Klasikler",
            "Çeviri Şiirler",
            "Çevre ve Ekoloji",
            "Çizgi Roman",
            "Çocuk Edebiyatı",
            "Çocuk Eğitimi",
            "Çocuk Eğitimi/Okul Öncesi",
            "Çocuk Eğitimi/Okul Sonras",
            "Çocuk Gelişimi",
            "Çocuk Kitapları",
            "Çocuk Psikolojisi",
            "Çocuk ve Ergen Gelişimi",
            "Demokrasi",
            "Deneme",
            "Derleme",
            "Devlet/Ordu",
            "Devrim/İhtilal",
            "Dış Politika/Uluslararası",
            "Diğer",
            "Diğer Dillerin Edebiyatı",
            "Dil",
            "Dil / Kurs Kitapları",
            "Dil Bilgisi",
            "Dil/Etimoloji",
            "Dilbilim",
            "Din",
            "Din / Araştırma",
            "Din / Budizm",
            "Din / Hırıstiyanlık",
            "Din / İslam",
            "Din-İslamiyet",
            "Din-Metafizik-Ruhbilim",
            "Din: İslam Araştırmaları",
            "Din: İslam Fıkıh (Hukuk)",
            "Din: İslam Mezhepleri",
            "Din: İslam Tarihi",
            "Din: İslam-Tasavvuf",
            "Din: Kuran ve Hadis",
            "Divan Edebiyatı",
            "Doğa Bilimleri",
            "Doğaüstü-Gizem",
            "Duygu Bozuklukları",
            "Dünya Dinleri",
            "Dünya Edebiyatı-Toplumsal",
            "Dünya Klasikleri",
            "Dünya Siyaseti",
            "Düşünce",
            "Düşünürler",
            "Edebiyat",
            "Edebiyat (Öykü - Roman)",
            "Edebiyat İncelemesi",
            "Edebiyat: Osmanlı Divan Ş",
            "Edebiyat: Türk Şiiri",
            "Efsaneler/Destanlar",
            "Eğitim",
            "Eğitim - Eğitim Bilim",
            "Eğitim - KPDS-ÜDS",
            "Eğitim > Dil Eğitimi",
            "Eğitim ve Ders Kitapları",
            "Eğlence",
            "Eğlence ve Gülmece",
            "Eğlence-Mizah",
            "Ekoloji",
            "Ekonomi",
            "Ekonomi Politikaları",
            "Ekonomi ve Finans",
            "Ekonomi-Emek-İş Dünyası",
            "Eleştiri",
            "Emperyalizm",
            "Ermeni Sorunu",
            "Estetik ve SanatFelsefesi",
            "Etik (Ahlak Felsefesi)",
            "Etnik Gruplar",
            "Fal / Rüya / Astroloji",
            "Fal-Burç-Büyü",
            "Fantastik",
            "Fantastik Roman",
            "Felsefe",
            "Felsefe ve Psikoloji",
            "Felsefe-Düşünce",
            "Fıkra",
            "Fizik, Kimya Bilimleri",
            "Folklor ve Gelenekler",
            "Fotoğraf",
            "Gazeteci Kitapları-Makale",
            "Gazeteci Yazarlar",
            "Gazetecilik, Yayıncılık",
            "Gençlik Edebiyatı",
            "Gençlik Kitapları",
            "Gençlik-Macera",
            "Genel Hukuk",
            "Genel Konular",
            "Gerilim ve Korku",
            "Gezi-Yorum",
            "Gizli Cemiyetler",
            "Gösteri Sanatları",
            "Günlük-Günce",
            "Güzel Sanatlar",
            "Güzel-Özlü Sözler",
            "Haber, Medya",
            "Halı, Kilim ve Dokuma",
            "Halk Edebiyatı",
            "Halkla İlişkiler",
            "Hatıra",
            "Hayvanlar Alemi",
            "Hiciv ve Mizah",
            "Hikaye",
            "Hobi",
            "Hobi - Briç-Satranç",
            "Hobi - El Sanatları",
            "Hobi - Fotoğrafçılık",
            "Hobi - Yemek kitapları",
            "Hobi / Bakım",
            "Hobi / Bakım-Güzellik",
            "Hobi ve Eğlence",
            "Hobi,Eğlence-SofraKültürü",
            "Hobi:Moda ve Giyim",
            "Hukuk",
            "Hukuk Felsefesi",
            "İç Politika",
            "İktisadi Düşünceler",
            "İktisadi Teoriler",
            "İletişim",
            "İnceleme-Araştırma",
            "İncelemeler, Tenkidler",
            "İnsan Kaynakları",
            "İnsan ve Toplum",
            "İslam",
            "İslâmiyet/Dua-İbadet",
            "İslâmiyet/Kuran-Hadisler",
            "İslâmiyet/Mezhep-Tarikat",
            "İstanbul Kitapları",
            "İstihbarat ve Casusluk",
            "İş Dünyası",
            "İş Dünyası-Kariyer",
            "İş İdaresi, Yöneticilik",
            "Kadın",
            "Kadın-Erkek İlişkileri",
            "Karikatür",
            "Kariyer ve Liderlik",
            "Katalog-Bibliyografya",
            "Kent /Çevre / Turizm",
            "Kent, Yerel Yönetim",
            "Keşif ve İcatlar",
            "Kişisel Gelişim",
            "Klasik Polisiye Romanlar",
            "Klasik Türk Edebiyatı",
            "Klavuz Kitaplar",
            "Kolektif",
            "Korku",
            "Korku-Gerilim",
            "Kuşkuculuk",
            "Kültür",
            "Kültür Sanat - Albüm",
            "Kültür Sanat-Mimari",
            "Kültür Tarihi",
            "Kültür-Sanat",
            "Küreselleşme",
            "Laiklik-Şeriat",
            "Macera",
            "Macera / Korku",
            "Makale",
            "Mantık",
            "Marksizm / Sol",
            "Masal",
            "Masal ve Fıkra",
            "Meditasyon/Yoga",
            "Medya ve İletişim",
            "Mektup",
            "Mesleki-Referans",
            "Metafizik-Ufo ve Uzay",
            "Meyvecilik ve Bahçecilik",
            "Mitoloji",
            "Mitolojik Masallar",
            "Mizah",
            "Modern Türkiye Tarihi",
            "Modern Türkiye ve Atatürk",
            "Müze - Sergi - Bienal",
            "Müzik",
            "Okkültizm (Gizlicilik)",
            "Okul Öncesi Eğitim",
            "Ordu-Polis-İstihbarat Örg",
            "Orta Asya Türk Tarihi",
            "Osmanlı Divan Şiiri",
            "Osmanlı Tarihi",
            "Otobiyografi",
            "Oyun",
            "Öykü",
            "Özdeyişler",
            "Parapsikoloji",
            "Periyodik Yayınlar",
            "PEYZAJ MİMARLIĞI",
            "Polisiye",
            "Polisiye - Macera",
            "Polisiye / Roman",
            "Polisiye Gerilim",
            "Polisiye-Casusluk",
            "Politika",
            "Politika - Devlet Yönetim",
            "Politika - Siyasi Tarih",
            "Politika - Siyasi Yazılar",
            "Politika-Devlet Yönetimi",
            "Politika-Devrim-İhtilal",
            "Politika-İç Politika",
            "Politika-Laiklik-Şeriat",
            "Politika-Siyaset",
            "Politika-Siyasi İdeoloji",
            "Politika-Siyasi Partiler",
            "Politika-Sosyal Politika",
            "Popüler Bilim",
            "Popüler Kültür",
            "Postmodernizm",
            "Psikanaliz",
            "Psikoloji",
            "Psikoloji - Davranışbilim",
            "Psikoloji - İletişim",
            "Psikoloji - Motivasyon",
            "Psikoloji - Psikanaliz",
            "Psikoloji - Psikiyatri",
            "Psikoloji > İnceleme",
            "Psikoloji Kuramları",
            "Psikoloji ve Pedagoji",
            "Psikoloji-Düşünce",
            "Psikoloji-Kişilik ve Zeka",
            "Psikoloji-Yaklaşımlar",
            "Reklamcılık",
            "Resimli Tarih",
            "Roman",
            "Röportaj",
            "Röportaj-Söyleşi",
            "Rus ve Slav Dilleri Edb.",
            "Sağlık",
            "Sağlık/Tıp",
            "Sahhaf",
            "Sanat",
            "Sanat - Fotoğraf",
            "Sanat - Resim",
            "Sanat - Sinema",
            "Sanat - Tarih",
            "Sanat - Tiyatro",
            "Sanat Tarihi",
            "Sanat ve Mimari",
            "Sanat ve Mimari: Hat",
            "Sanat ve Mimari:Ebru",
            "Sanat ve Mimari:Minyatür",
            "Sanat ve Mimari:Tezhib",
            "Sanat ve Mimarlık üzerine",
            "Sanat-Resim-Ressamlar",
            "Satranç, Briç, Oyun",
            "Senaryo-Sinema",
            "Senaryo/Oyun",
            "Serbest",
            "Seyahatname",
            "Sinema / Belgesel",
            "Sinema / Televizyon",
            "Sinema/Tiyatro",
            "Siyasal Akımlar",
            "Siyasal Bilimler",
            "Siyaset",
            "Siyaset Bilimi",
            "Siyaset-Doğu-Güneydoğu",
            "Siyasi İdeolojiler",
            "Siyasi Partiler",
            "Siyasi Tarih",
            "Sosyal Bilimler",
            "Sosyal Psikoloji",
            "Sosyoloji",
            "Söyleşi-Röportaj",
            "Söylev ve Mektuplar",
            "Sözlük",
            "Spor - Bireysel Sporlar",
            "Spor - Futbol",
            "Spor - Takım Sporları",
            "Şehir Tarihi",
            "Şiir",
            "Tarih",
            "Tarih - I. Dünya Savaşı",
            "Tarih - İlkçağ ve Öncesi",
            "Tarih - İnceleme",
            "Tarih - İslam Tarihi",
            "Tarih - Kurtuluş Savaşı",
            "Tarih - Medeniyetler",
            "Tarih - Mitoloji",
            "Tarih - Ortaçağ Tarihi",
            "Tarih - Ortadoğu",
            "Tarih - Osmanlı ve Öncesi",
            "Tarih - Popüler Tarih",
            "Tarih - Savaşlar/İsyanlar",
            "Tarih - Toplumsal Tarih",
            "Tarih - Türk Tarihi",
            "Tarih - Uygarlık Tarihi",
            "Tarih - Yakın Tarih",
            "Tarih / Anadolu Uygarlıkl",
            "Tarih / Anı",
            "Tarih / Araştırma",
            "Tarih / Cumhuriyet Tarihi",
            "Tarih ve Politika",
            "Tarih-Türkiye Cumhuriyeti",
            "Tarih: Antik Çağ",
            "Tarih: Askeri Tarih",
            "Tarih: Asya Tarihi",
            "Tarih: Bilim Tarihi",
            "Tarih: Dünya Tarihi",
            "Tarih: Osmanlı Tarihi",
            "Tarih: Şehir Tarihleri",
            "Tarihi roman",
            "Tarihi Seyahatnameler",
            "Tasavvuf",
            "Tasavvuf Edebiyatı",
            "Tasavvuf ve Tarikatlar",
            "Tenkidler",
            "Terör ve Suç Örgütleri",
            "Tiyatro",
            "Tiyatro / Oyun",
            "Tiyatro Oyunu-Piyes",
            "Toplumbilim (Sosyoloji)",
            "Toplumsal Değişimler",
            "Toplumsal Sorunlar",
            "Turizm",
            "Türk Dili Grameri,Lehçe",
            "Türk Edebiyatı",
            "Türk Resim Sanatı",
            "Türkiye Cumhuriyeti Tarih",
            "Türkiye Ekonomisi",
            "Türkiye Tarihi",
            "Türkiye Üzerine",
            "Türkiye Üzerine Araştırma",
            "Uluslararası İlişkiler",
            "Ussalcılık (Rasyonalizm)",
            "Uygarlık Tarihi",
            "Uygulamalı Bilimler",
            "Varoluşçuluk",
            "Yabancı Dil Öğrenim",
            "Yasa- Mevzuat",
            "Yaşam ve Psikoloji",
            "Yaşamöykü/Anı/Mektup",
            "Yaşamöyküsü",
            "Yeme, İçme ve Gurme",
            "Yemek",
            "Yeni Dünya Düzeni",
            "Yönetim",
            "Zooloji"});
            this.comboBox1.Location = new System.Drawing.Point(142, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 134);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 22);
            this.textBox5.TabIndex = 10;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Veriliş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitap Türü:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 74);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayın Evi:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(147, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(273, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kimlikDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.yayinEviDataGridViewTextBoxColumn,
            this.kitapTürüDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.verilişTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 230);
            this.dataGridView1.TabIndex = 4;
            // 
            // kimlikDataGridViewTextBoxColumn
            // 
            this.kimlikDataGridViewTextBoxColumn.DataPropertyName = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.Name = "kimlikDataGridViewTextBoxColumn";
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
            // kitaplistBindingSource
            // 
            this.kitaplistBindingSource.DataMember = "kitaplist";
            this.kitaplistBindingSource.DataSource = this.kütüphaneDataSet25;
            // 
            // kütüphaneDataSet25
            // 
            this.kütüphaneDataSet25.DataSetName = "kütüphaneDataSet25";
            this.kütüphaneDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(355, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tam Liste";
            // 
            // kitaplistTableAdapter
            // 
            this.kitaplistTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 321);
            this.MinimumSize = new System.Drawing.Size(839, 321);
            this.Name = "Form3";
            this.Text = "Kitap Kayıt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet25)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilişTarihiDataGridViewTextBoxColumn;
        private kütüphaneDataSet25 kütüphaneDataSet25;
        private System.Windows.Forms.BindingSource kitaplistBindingSource;
        private Kütüphane_Takip.kütüphaneDataSet25TableAdapters.kitaplistTableAdapter kitaplistTableAdapter;
    }
}