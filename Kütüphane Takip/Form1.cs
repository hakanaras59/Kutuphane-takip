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

namespace Kütüphane_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        OleDbConnection baglanti=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sifre.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter sifrekntrol = new OleDbDataAdapter("Select*from sifre", baglanti);
            DataTable sifretablo = new DataTable();
            sifrekntrol.Fill(sifretablo);
            baglanti.Close();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == sifretablo.Rows[0][1].ToString() && textBox2.Text ==sifretablo.Rows[0][2].ToString())
                {

                    sesac();
                    frm2.Show();
                    this.Hide();

                }
                else
                {
                    seshata();
                    MessageBox.Show("Lütfen Kullanıcı Adı/Şifre Tekrar Kontrol Ediniz", "Hata");
                }
            }

            else
            {
                seshata();
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
            Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sesac();
            e.Cancel = true;
            this.Hide();
        }
        private NotifyIcon nicon;
        private ContextMenu cMenu;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            sesac();
            nicon = new NotifyIcon();
            nicon.Text = "Kütüp Hane Takip Programı";
            nicon.Visible = true;
            nicon.Icon = new Icon("favicon.ico");
            cMenu = new ContextMenu();
            cMenu.MenuItems.Add(0, new MenuItem("Göster", new System.EventHandler(Goster_Click)));
            cMenu.MenuItems.Add(1, new MenuItem("Tamamen Kapat", new System.EventHandler(Kapat_Click)));
            nicon.ContextMenu = cMenu;
        }
        protected void Goster_Click(object sender, System.EventArgs e)
        {
            sesac();
            Show();
        }
        protected void Kapat_Click(object sender, System.EventArgs e)
        {
            sesac();
            Application.Exit();
            Application.ExitThread();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sesac();
            if (textBox5.Text != "" && textBox4.Text != "" && textBox3.Text != "" && textBox6.Text != "")
            {
                baglanti.Open();
                OleDbDataAdapter gizlisifreyial = new OleDbDataAdapter("Select*from sifre", baglanti);
                DataTable gizlisifretablo = new DataTable();
                gizlisifreyial.Fill(gizlisifretablo);
                baglanti.Close();
                if (textBox6.Text == gizlisifretablo.Rows[0][3].ToString())
                {
                    baglanti.Open();
                    OleDbCommand sifregncelle=new OleDbCommand("update sifre set id='"+textBox4.Text+"',pw='"+textBox3.Text+"',gizli_sifre='"+textBox5.Text+"' where kimlik="+1+"",baglanti);
                    sifregncelle.ExecuteNonQuery();
                    MessageBox.Show("Şifre Değiştirme Başarılı!");
                    baglanti.Close();
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                else
                {
                    seshata();
                    MessageBox.Show("Girilen Gizli Şifre Yanlış!", "HATA");
                }
            }
            else
            {
                seshata();
                MessageBox.Show("Lütfen Kullanıcı Adı, Şifre, Gizli Şifre ve Yeni Gizli Şifre Böşümlerini Boş Bırakmayın!", "HATA");

            }
        }
    }
}
