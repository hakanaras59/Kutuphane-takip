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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sesac();
            this.Hide();
        }
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        private void button1_Click(object sender, EventArgs e)
        {
            sesac();
            f3.Show();
            this.Hide();
        }
        private void sesac()
        {
            SoundPlayer player = new SoundPlayer();
            string path = "1.wav";
            player.SoundLocation = path;
            player.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sesac();
            f4.Show();
            this.Hide();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            sesac();
            f5.Show();
            this.Hide();
        }
        Form7 frm7;
        private void button5_Click(object sender, EventArgs e)
        {
            frm7 = new Form7();
            sesac();
            frm7.Show();
            this.Hide();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            sesac();
            f6.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sesac();
            e.Cancel = true;
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f3 = new Form3();
            f4 = new Form4();
            f5 = new Form5();
            f6 = new Form6(); 
        }
    }
}
