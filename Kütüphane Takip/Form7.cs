using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace Kütüphane_Takip
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void sesac()
        {
            SoundPlayer player = new SoundPlayer();
            string path = "1.wav";
            player.SoundLocation = path;
            player.Play();
        }
        private void seshata()
        {
            SoundPlayer player = new SoundPlayer();
            string path = "2.wav";
            player.SoundLocation = path;
            player.Play();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            sesac();
            e.Cancel = true;
            this.Hide();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            button1.Enabled = false;
            button11.Enabled = false;
            // TODO: This line of code loads data into the 'kütüphaneDataSet24.kitaplist' table. You can move, or remove it, as needed.
            this.kitaplistTableAdapter.Fill(this.kütüphaneDataSet24.kitaplist);
            // TODO: This line of code loads data into the 'ogrncilistDataSet14.ogrncilist' table. You can move, or remove it, as needed.
            this.ogrncilistTableAdapter.Fill(this.ogrncilistDataSet14.ogrncilist);
            göster();
            gösterögrenci();

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kütüphane.accdb");
        OleDbConnection ögrencibaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ogrncilist.accdb");
        private void göster()
        {
            baglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from kitaplist", baglanti);
            DataTable asd1 = new DataTable();
            asd.Fill(asd1);
            for (int i = 0; i < asd1.Rows.Count; i++)
            {
                if (asd1.Rows[i][7].ToString() == "")
                {
                    OleDbCommand asd2 = new OleDbCommand("update kitaplist set şuan_kirada='" + "Hayır" + "' where şuan_kirada is null", baglanti);
                    asd2.ExecuteNonQuery();
                }
            }
            asd1.Clear();
            OleDbDataAdapter asd3 = new OleDbDataAdapter("Select*from kitaplist", baglanti);
            asd3.Fill(asd1);
            dataGridView1.DataSource = asd1;
        
            baglanti.Close();
            //
            
        }
        private void gösterögrenci()
        {
            ögrencibaglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from ogrncilist", ögrencibaglanti);
            DataTable asd1 = new DataTable();
            asd.Fill(asd1);
            for (int i = 0; i < asd1.Rows.Count; i++)
            {
                if (asd1.Rows[i][8].ToString() == "")
                {
                    OleDbCommand asd2 = new OleDbCommand("update ogrncilist set aldığıkitap='" + "Yok" + "' where aldığıkitap is null", ögrencibaglanti);
                    asd2.ExecuteNonQuery();
                }
            }
            asd1.Clear();
            OleDbDataAdapter asd3 = new OleDbDataAdapter("Select*from ogrncilist", ögrencibaglanti);
            asd3.Fill(asd1);
            dataGridView2.DataSource = asd1;
            ögrencibaglanti.Close();
        }
        string seçilikitapid = "";
        string seçiliögrenciid = "";
        string kitapadi;
        string kntrlvrlmismi;
        int kitapadikontrol;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                seçilikitapid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (label1.Text != "")
                {
                    label2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " Adlı Kitabı";
                }
                kitapadi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                kntrlvrlmismi = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                kitapadikontrol = e.RowIndex;
            }
            catch
            {
            }
        }
        string kontrolögrencikitapalmismi;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                seçiliögrenciid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                label1.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString() + " Adlı Öğrenciye(den)";
                if (seçilikitapid != "")
                {
                    label2.Text = dataGridView1.Rows[kitapadikontrol].Cells[1].Value.ToString() + " Adlı Kitabı";

                }
                kontrolögrencikitapalmismi = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sesac();
            if (label1.Text != "" && label2.Text != "")
            {
                if (kntrlvrlmismi == "Hayır")
                {
                    if (kontrolögrencikitapalmismi == "Yok")
                    {

                        baglanti.Open();
                        OleDbCommand kitapalınıyor = new OleDbCommand("update kitaplist set şuan_kirada='" + "Evet" + "',kiraya_veriliş_tarihi='" + DateTime.Now.ToLongDateString() + "',kira_bitiş_tarihi='" + DateTime.Now.AddDays(7).ToLongDateString() + "' where kimlik=" + seçilikitapid + "", baglanti);
                        kitapalınıyor.ExecuteNonQuery();
                        baglanti.Close();
                        ögrencibaglanti.Open();
                        OleDbCommand asd2 = new OleDbCommand("update ogrncilist set aldığıkitap='" + kitapadi + " Kitabı" + "',kitabı_aldığı_tarih='" + DateTime.Now.ToLongDateString() + "',kitabın_verilmesi_gereken_tarih='" + DateTime.Now.AddDays(7).ToLongDateString() + "' where kimlik=" + seçiliögrenciid + "", ögrencibaglanti);
                        asd2.ExecuteNonQuery();
                        ögrencibaglanti.Close();
                        göster();
                        gösterögrenci();
                        MessageBox.Show(label1.Text + " " + label2.Text + " Verilmiştir.");
                        label1.Text = "";
                        label2.Text = "";
                    }
                    else
                    {
                        seshata();
                        MessageBox.Show("Bu Öğrenci Zaten Kitap Almış!", "Hata");
                    }
                }
                else
                {
                    seshata();
                    MessageBox.Show("Bu Kitap Zaten Başkasında!", "Hata");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Lütfen Kitabı ve Alacak Üyeyi Seçiniz", "HATA");
            }

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text != "" && label2.Text != "")
            {
                button1.Enabled = true;
                button11.Enabled = true;
            }
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text != "" && label2.Text != "")
            {
                button1.Enabled = true;
                button11.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sesac();
            try
            {
                if (textBox1.Text != "")
                {
                    ögrencibaglanti.Open();
                    OleDbDataAdapter bul = new OleDbDataAdapter("Select*from ogrncilist where tckimlik='" + textBox1.Text + "'", ögrencibaglanti);
                    DataTable bulundu = new DataTable();
                    bul.Fill(bulundu);
                    dataGridView2.DataSource = bulundu;
                    ögrencibaglanti.Close();
                    if (dataGridView2.Rows.Count < 1)
                    {
                        seshata();
                        MessageBox.Show(textBox1.Text + " Tcli Öğrenci Bulunamadı");
                    }
                }
                else
                {
                    seshata();
                    MessageBox.Show("Lütfen Aramak İstediğiniz TC yi Giriniz");
                }
            }
            catch
            {
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sesac();
            gösterögrenci();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sesac();
            try
            {
                if (textBox2.Text != "")
                {
                    baglanti.Open();
                    OleDbDataAdapter bul = new OleDbDataAdapter("Select*from kitaplist where barkod_no=" + textBox2.Text + "", baglanti);
                    DataTable bulundu = new DataTable();
                    bul.Fill(bulundu);
                    dataGridView1.DataSource = bulundu;
                    baglanti.Close();
                    if (dataGridView1.Rows.Count < 1)
                    {
                        seshata();
                        MessageBox.Show(textBox1.Text + " Borkod Nolu Kitap Bulunamadı");
                    }
                }
                else
                {
                    seshata();
                    MessageBox.Show("Lütfen Aramak İstediğinz Barkod Numarasını Giriniz!");
                }
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sesac();
            göster();
        }
        Form2 f2 = new Form2();
        private void button6_Click(object sender, EventArgs e)
        {
            sesac();
            f2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sesac();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[9].Value.ToString() != "")
                {
                    string x = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    string y = DateTime.Now.ToLongDateString();
                    if (String.Compare(x, y) == -1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
        
                    }
                }
            }
            for (int j = 0; j < dataGridView2.Rows.Count; j++)
            {
                if (dataGridView2.Rows[j].Cells[9].Value.ToString() != "")
                {
                    string kx = dataGridView2.Rows[j].Cells[9].Value.ToString();
                    string ky = DateTime.Now.ToLongDateString();
                    if (String.Compare(kx, ky) == -1)
                    {
                        dataGridView2.Rows[j].DefaultCellStyle.BackColor = Color.Red;
        
                    }
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sesac();
            if (button8.Text == "Akıllı Gösterge Aç")
            {
                timer1.Enabled = true;
                button8.Text = "Akıllı Gösterge Kapat";
            }
            else
            {
                timer1.Enabled = false;
                button8.Text = "Akıllı Gösterge Aç";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[9].Value.ToString() != "")
                    {
                        string x = dataGridView1.Rows[i].Cells[9].Value.ToString();
                        string y = DateTime.Now.ToLongDateString();
                        if (String.Compare(x, y) == -1)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                           
            
                        }
                    }
                }
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                {
                    if (dataGridView2.Rows[j].Cells[9].Value.ToString() != "")
                    {
                        string kx = dataGridView2.Rows[j].Cells[9].Value.ToString();
                        string ky = DateTime.Now.ToLongDateString();
                        if (String.Compare(kx, ky) == -1)
                        {
                            dataGridView2.Rows[j].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sesac();
            ögrencibaglanti.Open();
            OleDbDataAdapter gecikmislerigöster = new OleDbDataAdapter("Select*from ogrncilist where kitabın_verilmesi_gereken_tarih<'" + DateTime.Now.ToLongDateString() + "'", ögrencibaglanti);
            DataTable gecikmisler = new DataTable();
            gecikmislerigöster.Fill(gecikmisler);
            dataGridView2.DataSource = gecikmisler;
            ögrencibaglanti.Close();
            if (dataGridView2.Rows.Count == 0)
            {
                gösterögrenci();
                MessageBox.Show("Gecikmiş Yok");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sesac();
            baglanti.Open();
            OleDbDataAdapter gecikmislerigöster = new OleDbDataAdapter("Select*from kitaplist where kira_bitiş_tarihi<'" + DateTime.Now.ToLongDateString() + "'", baglanti);
            DataTable gecikmisler = new DataTable();
            gecikmislerigöster.Fill(gecikmisler);
            dataGridView1.DataSource = gecikmisler;
            baglanti.Close();
            if (dataGridView1.Rows.Count == 0)
            {  
                göster();
                MessageBox.Show("Gecikmiş Yok");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sesac();
            if (label1.Text != "" && label2.Text != "")
            {
                if (kntrlvrlmismi != "Hayır")
                {
                    if (kontrolögrencikitapalmismi != "Yok")
                    {
                        baglanti.Open();
                        OleDbDataAdapter dneme = new OleDbDataAdapter("Select*from kitaplist where kimlik=" + seçilikitapid + "", baglanti);
                        DataTable denemetablo = new DataTable();
                        dneme.Fill(denemetablo);
                        baglanti.Close();
                        ögrencibaglanti.Open();
                        OleDbDataAdapter deneme2 = new OleDbDataAdapter("Select*from ogrncilist where kimlik=" + seçiliögrenciid + "", ögrencibaglanti);
                        DataTable deneme2tablo = new DataTable();
                        deneme2.Fill(deneme2tablo);
                        ögrencibaglanti.Close();
                        //
                        if (denemetablo.Rows[0][1].ToString()+" Kitabı" == deneme2tablo.Rows[0][8].ToString())
                        {
                            baglanti.Open();
                            OleDbCommand kitapalınıyor = new OleDbCommand("update kitaplist set şuan_kirada='" + "Hayır" + "',kiraya_veriliş_tarihi='" + "" + "',kira_bitiş_tarihi='" + "" + "' where kimlik=" + seçilikitapid + "", baglanti);
                            kitapalınıyor.ExecuteNonQuery();
                            baglanti.Close();
                            ögrencibaglanti.Open();
                            OleDbCommand asd2 = new OleDbCommand("update ogrncilist set aldığıkitap='" + "Yok" + "',kitabı_aldığı_tarih='" + "" + "',kitabın_verilmesi_gereken_tarih='" + "" + "' where kimlik=" + seçiliögrenciid + "", ögrencibaglanti);
                            asd2.ExecuteNonQuery();
                            ögrencibaglanti.Close();
                            MessageBox.Show(label1.Text + " " + label2.Text + " Alınmıştır");
                            göster();
                            gösterögrenci();
                            label1.Text = "";
                            label2.Text = "";
                        }
                        else
                        {
                            seshata();
                            MessageBox.Show(label1.Text + " " + label2.Text + " Zaten Almamış !!", "HATA");
                        }
                    }
                    else
                    {
                        seshata();
                        MessageBox.Show("Bu Öğrenci Zaten Kitap Almamış", "Hata");
                    }
                }
                else
                {
                    seshata();
                    MessageBox.Show("Bu Kitap Zaten Verilmemiş", "Hata");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Lütfen Alacağınız Kitabı ve Verecek Üyeyi Seçiniz", "HATA");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
