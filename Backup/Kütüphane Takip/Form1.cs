using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Kütüphane_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == "admin" && textBox2.Text == "123")
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
    }
}
