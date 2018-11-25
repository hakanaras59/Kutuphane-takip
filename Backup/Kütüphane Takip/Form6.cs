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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string aramat;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem==comboBox2.Items[5])
            {
                dateTimePicker2.Visible = true;
                textBox1.Visible = false;
                comboBox3.Visible = false;
                aramat = dateTimePicker2.Text;
                
            }
            if (comboBox2.SelectedItem == comboBox2.Items[3])
            {
                textBox1.Visible = false;
                dateTimePicker2.Visible = false;
                comboBox3.Visible = true;

            }
            if (comboBox2.SelectedItem != comboBox2.Items[3] && comboBox2.SelectedItem != comboBox2.Items[5])
            {
                dateTimePicker2.Visible = false;
                textBox1.Visible = true;
                comboBox3.Visible = false;
            }
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
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneDataSet26.kitaplist' table. You can move, or remove it, as needed.
            this.kitaplistTableAdapter.Fill(this.kütüphaneDataSet26.kitaplist);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePicker2.Visible = false;
            textBox1.Visible = true;
            comboBox3.Visible = false;
            göster();
            dataGridView1.ForeColor = Color.Black;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            aramat = dateTimePicker2.Text;
        }
        OleDbDataAdapter asd;
        private void button1_Click(object sender, EventArgs e)
        {
            sesac();
           
            try
            {
                if (comboBox2.SelectedItem == comboBox2.Items[5])
                {
                    baglanti.Open();
                    OleDbDataAdapter asd = new OleDbDataAdapter("Select*from kitaplist where Veriliş_Tarihi='" + aramat + "'", baglanti);
                    DataTable tablo = new DataTable();
                    asd.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();

                    if (comboBox2.SelectedItem == comboBox2.Items[0])
                    {
                        asd = new OleDbDataAdapter("Select*from kitaplist where Kitap_Adi='" + textBox1.Text + "'", baglanti);
                    }
                    if (comboBox2.SelectedItem == comboBox2.Items[1])
                    {
                        asd = new OleDbDataAdapter("Select*from kitaplist where Yazar_Adi='" + textBox1.Text + "'", baglanti);
                    }
                    if (comboBox2.SelectedItem == comboBox2.Items[2])
                    {
                        asd = new OleDbDataAdapter("Select*from kitaplist where Yayin_Evi='" + textBox1.Text + "'", baglanti);
                    }
                    if (comboBox2.SelectedItem == comboBox2.Items[3])
                    {
                        asd = new OleDbDataAdapter("Select*from kitaplist where Kitap_Türü='" + comboBox3.Text + "'", baglanti);
                    }
                    if (comboBox2.SelectedItem == comboBox2.Items[4])
                    {
                        asd = new OleDbDataAdapter("Select*from kitaplist where Barkod_No=" + textBox1.Text + "", baglanti);
                    }
                    DataTable tablo = new DataTable();
                    asd.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglanti.Close();
                    
                }
            }
            catch
            {
            }
            if (dataGridView1.Rows.Count <= 0)
            {
                seshata();
                MessageBox.Show("Aradığınız Kitap Bulunamadı", "HATA");
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            sesac();
            göster();
        }
        Form2 f2 = new Form2();

        private void button5_Click_1(object sender, EventArgs e)
        {
            sesac();
            f2.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            sesac();
            this.Hide();
        }
        OleDbCommand sil;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sesac();
                baglanti.Open();
                if (comboBox2.SelectedItem == comboBox2.Items[5])
                {
                    sil = new OleDbCommand("delete from kitaplist where Veriliş_Tarihi='" + aramat + "'", baglanti);
                }
                if (comboBox2.SelectedItem == comboBox2.Items[0])
                {
                    sil = new OleDbCommand("delete from kitaplist where Kitap_Adi='" + textBox1.Text + "'", baglanti);
                }
                if (comboBox2.SelectedItem == comboBox2.Items[1])
                {
                    sil = new OleDbCommand("delete from kitaplist where Yazar_Adi='" + textBox1.Text + "'", baglanti);
                }
                if (comboBox2.SelectedItem == comboBox2.Items[2])
                {
                    sil = new OleDbCommand("delete from kitaplist where Yayin_Evi='" + textBox1.Text + "'", baglanti);
                }
                if (comboBox2.SelectedItem == comboBox2.Items[3])
                {
                    sil = new OleDbCommand("delete from kitaplist where Kitap_Türü='" + comboBox3.Text + "'", baglanti);
                }
                if (comboBox2.SelectedItem == comboBox2.Items[4])
                {
                    sil = new OleDbCommand("delete from kitaplist where Barkod_No=" + textBox1.Text + "", baglanti);
                }
                sil.ExecuteNonQuery();
                baglanti.Close();
                göster();
            }
            catch
            {
                baglanti.Close();
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && dtp1.Text != "")
                {

                    sesac();
                    string Barkodkontrolüyapılıyor = "";
                    baglanti.Open();
                    OleDbDataAdapter kontrolbarkod = new OleDbDataAdapter("Select*from kitaplist where barkod_no <>" + kntrlcabası + "", baglanti);
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
                        OleDbCommand ekle = new OleDbCommand("update kitaplist set kitap_adi='" + textBox2.Text + "',yazar_adi='" + textBox3.Text + "',yayin_evi='" + textBox4.Text + "',kitap_türü='" + comboBox1.Text + "',veriliş_tarihi='" + dtp1.Text + "',barkod_no='" + textBox5.Text + "' where kimlik=" + id + "", baglanti);
                        ekle.ExecuteNonQuery();
                        baglanti.Close();
                        seshata();
                        MessageBox.Show(id + " Kayıt Numarasına Sahip Kitap Bilgileri Güncellenmiştir");
                        göster();
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";

                    }
                    else
                    {
                        seshata();
                        MessageBox.Show(textBox5.Text + "Barkod Numarasına Sahip Kitap Zaten Var!", "HATA");
                    }
                }
                else
                {
                    seshata();
                    MessageBox.Show("Lütfen Alanları Boş Bırakmayın", "Hata");
                }
            }
            catch
            {
                baglanti.Close();
                seshata();
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kitabı Seçiniz", "Hata");
            }
        }
        int id;
        string kntrlcabası = "";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtp1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                kntrlcabası = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
