﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAlabirent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Kolay Yoldan Başarı Yok");
            Application.Exit();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Tebikler Bitişe Ulaştınız");
            this.Hide();

              
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac==100)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz Doldu.");
                Application.Exit();
            }

            progressBar1.Value = sayac;
            label29.Text=sayac.ToString();
            sayac++;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Lütfen Başlangıç Kısmından Girin");
            Application.Exit();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Lütfen Başlangıç Kısmından Girin");
            Application.Exit();
        }

        private void label30_MouseEnter_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Denemeye Devam 'Engeller beni durduramaz, her bir engel kararlılığımı daha da güçlendirir.'-Leonardo da Vinci- .","Oyunu Kaybettiniz :(" );
            Application.Exit();
        } 
    }
}
