﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace practice1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
