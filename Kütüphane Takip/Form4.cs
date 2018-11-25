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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
        string cinsiyet;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text !="" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "")
            {
                string tckontroldurumu = "";
                baglanti.Open();
                OleDbDataAdapter tckontrol = new OleDbDataAdapter("Select*from ogrncilist", baglanti);
                DataTable tckontroltablo = new DataTable();
                tckontrol.Fill(tckontroltablo);
                baglanti.Close();
                for (int i = 0; i < tckontroltablo.Rows.Count; i++)
                {
                    if (tckontroltablo.Rows[i][1].ToString() == textBox1.Text)
                    {
                        tckontroldurumu = "1";
                    }
                }
                if (tckontroldurumu != "1")
                {

                    if (radioButton1.Checked == true)
                    {
                        cinsiyet = "Erkek";

                    }
                    else
                    {
                        cinsiyet = "Kadın";
                    }
                    baglanti.Open();
                    OleDbCommand kaydet = new OleDbCommand("insert into ogrncilist (tckimlik,adi,soyadi,cinsiyet,dgm_trihi,tel,adres) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + cinsiyet + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
                    kaydet.ExecuteNonQuery();
                    baglanti.Close();
                    sesac();
                    göster();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
                else
                {
                    seshata();
                    MessageBox.Show(textBox1.Text + "TC lin Öğrenci Zaten Kayıtlı!", "HATA!");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Boş Alanları Lütfen Doldurunuz / Kontrol Ediniz", "Hata");
            }
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ogrncilist.accdb");
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrncilistDataSet11.ogrncilist' table. You can move, or remove it, as needed.
            this.ogrncilistTableAdapter.Fill(this.ogrncilistDataSet11.ogrncilist);
            göster();
            radioButton1.Checked = true;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            sesac();
            e.Cancel = true;
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
