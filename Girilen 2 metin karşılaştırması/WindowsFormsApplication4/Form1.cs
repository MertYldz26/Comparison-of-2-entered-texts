﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            int dönendeğer;
            s1 =textBox1.Text;
            s2 = textBox2.Text;
            dönendeğer = string.Compare(s1, s2);
            if (dönendeğer == 0)
            {
                label1.Text = "metinler aynı";
            }
            else
            {
                label1.Text = "metinler farklı";
            }

        }
    }
}
