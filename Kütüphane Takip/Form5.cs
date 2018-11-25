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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sesac();
            this.Hide();
        }
        public void göster()
        {
            baglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from ogrncilist", baglanti);
            DataTable tablo = new DataTable();
            asd.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
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
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ogrncilist.accdb");
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrncilistDataSet12.ogrncilist' table. You can move, or remove it, as needed.
            this.ogrncilistTableAdapter.Fill(this.ogrncilistDataSet12.ogrncilist);
            göster();
            dataGridView1.ForeColor = Color.Black;
            radioButton1.Checked = true;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        string tckontrolcabası = "";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Erkek")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                id= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tckontrolcabası = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
            }
            
        }
        string id;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter asd = new OleDbDataAdapter("Select*from ogrncilist where tckimlik='"+textBox1.Text+"'", baglanti);
            DataTable tablo = new DataTable();
            asd.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            if (dataGridView1.Rows.Count < 1)
            {
                seshata();
                MessageBox.Show("Aradığınız TC li Öğrenci Bulunamadı");
            }
            else
            {
                sesac();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sesac();
            göster();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        Form2 f2 = new Form2();

        private void button5_Click(object sender, EventArgs e)
        {
            sesac();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string silkntrolstring = "";
                baglanti.Open();
                OleDbDataAdapter silkontrol = new OleDbDataAdapter("Select*from ogrncilist", baglanti);
                DataTable silkontroltablo = new DataTable();
                silkontrol.Fill(silkontroltablo);
                for (int i = 0; i < silkontroltablo.Rows.Count; i++)
                {
                    if (silkontroltablo.Rows[i][1].ToString() == textBox1.Text)
                    {
                        silkntrolstring = "1";
                    }
                }
                baglanti.Close();
                if (silkntrolstring == "1")
                {
                    sesac();
                    baglanti.Open();
                    OleDbCommand sil = new OleDbCommand("delete from ogrncilist where tckimlik='" + textBox1.Text + "'", baglanti);
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    seshata();
                    MessageBox.Show(textBox1.Text + " Tc Li Öğrencinin Kaydı Silinmiştir");
                    göster();
                }
                else
                {
                    seshata();
                    MessageBox.Show(textBox1.Text + " TC li Öğrenci Bulunamadı");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Lütfen İşlem Yapmak İçin Boş Alan Bırakmayınız!", "HATA");
            }
        }
        string cinsiyet;
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "")
            {
                string tckontroldurumu = "";
                baglanti.Open();
                OleDbDataAdapter tckontrol = new OleDbDataAdapter("Select*from ogrncilist where tckimlik <> '" + tckontrolcabası + "'", baglanti);
                DataTable tckontroltablo = new DataTable();
                tckontrol.Fill(tckontroltablo);
                baglanti.Close();
                for (int i = 0; i < tckontroltablo.Rows.Count; i++)
                {
                    if (tckontroltablo.Rows[i][1].ToString() == textBox2.Text)
                    {
                        tckontroldurumu = "1";
                    }
                }
                if (tckontroldurumu != "1")
                {
                    try
                    {
                        sesac();
                        baglanti.Open();
                        OleDbCommand ekle = new OleDbCommand("update ogrncilist set tckimlik='" + textBox2.Text + "',adi='" + textBox3.Text + "',soyadi='" + textBox4.Text + "',cinsiyet='" + cinsiyet + "',dgm_trihi='" + dateTimePicker1.Text + "',tel='" + textBox5.Text + "',adres='" + textBox6.Text + "' where Kimlik=" + id + "", baglanti);
                        ekle.ExecuteNonQuery();
                        baglanti.Close();
                        seshata();
                        MessageBox.Show(id + " Kayıt Numarasına Sahip Öğrenci Bilgileri Güncellenmiştir");
                        göster();
                    }
                    catch
                    {
                        baglanti.Close();
                        seshata();
                        MessageBox.Show("Güncellemek İstediğiniz Öğrenciyi Seçiniz", "Hata");
                    }
                }
                else
                {
                    seshata();
                    MessageBox.Show(textBox2.Text + "TC li Öğrenci Zaten Kayıtlı", "HATA");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Lütfen Alanları Boş Bırakmayınız", "Hata");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet="Kadın";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                cinsiyet = "Erkek";
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
