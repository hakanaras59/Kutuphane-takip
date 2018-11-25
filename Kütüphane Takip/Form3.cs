using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;

namespace Kütüphane_Takip
{
    public partial class Form3 : Form
    {
        public Form3()
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
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneDataSet25.kitaplist' table. You can move, or remove it, as needed.
            this.kitaplistTableAdapter.Fill(this.kütüphaneDataSet25.kitaplist);
            comboBox1.SelectedIndex = 0;

            göster();
            label7.Text = DateTime.Now.ToLongDateString();
            dataGridView1.ForeColor = Color.Black;
            
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kütüphane.accdb");
        public void göster()
        {
            baglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from kitaplist", baglanti);
            DataTable tablo = new DataTable();
            asd.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox5.Text != "" && label7.Text != "")
            {
                string Barkodkontrolüyapılıyor = "";
                baglanti.Open();
                OleDbDataAdapter kontrolbarkod = new OleDbDataAdapter("Select*from kitaplist", baglanti);
                DataTable barkodtablo = new DataTable();
                kontrolbarkod.Fill(barkodtablo);
                baglanti.Close();
                for (int i = 0; i < barkodtablo.Rows.Count; i++)
                {
                    if (barkodtablo.Rows[i][5].ToString() == textBox5.Text)
                    {
                        Barkodkontrolüyapılıyor = "1";
                    }
                }
                if (Barkodkontrolüyapılıyor != "1")
                {

                    baglanti.Open();
                    OleDbCommand kaydet = new OleDbCommand("insert into kitaplist (Kitap_Adi,Yazar_Adi,Yayin_Evi,Kitap_Türü,Barkod_No,veriliş_tarihi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "'," + textBox5.Text + ",'" + label7.Text + "')", baglanti);
                    kaydet.ExecuteNonQuery();
                    baglanti.Close();
                    göster();
                    seshata();
                    MessageBox.Show("Yeni Kitap Listeye Eklendi!", "Hata");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    textBox5.Text = "";

                }
                else
                {
                    seshata();
                    MessageBox.Show(textBox5.Text + " Barkod Numarasına Sahip Kitap Zaten Var. Lütfen Farklı Bir Barkod Numarası Giriniz..");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Boş Alanları Lütfen Doldurunuz / Kontrol Ediniz", "Hata");
            }
            
        }
        Form2 f2 = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            sesac();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sesac();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            sesac();
            e.Cancel = true;
            this.Hide();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
