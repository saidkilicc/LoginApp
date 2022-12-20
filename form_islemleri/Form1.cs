using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kodolustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000,100000);
            textBox4.Text= sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" & textBox2.Text=="1234" & textBox3.Text==textBox4.Text)
            {
                Form2 frm= new Form2();
                frm.kullanici = textBox1.Text;
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş: Kullanıcı Adı veya Şifre yanlış girildi!","Hata", MessageBoxButtons.OK,MessageBoxIcon.Stop);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm= new Form3();
            frm.Show();
            
        }

        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac %2 == 0)
            {
                label3.BackColor = Color.Yellow;
            }
            else
            {
                label3.BackColor = Color.DarkBlue;
            }
            if(sayac == 10)
            {
                sayac= 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
