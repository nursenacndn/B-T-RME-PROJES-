﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriAramaSayfası listele = new MüşteriAramaSayfası();
            listele.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriKayıtSayfası ekle = new MüşteriKayıtSayfası();
            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ÜrünStokSorgulamaSayfası listele = new ÜrünStokSorgulamaSayfası();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÜrünKayıtSayfası kayıt = new ÜrünKayıtSayfası();
            kayıt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
