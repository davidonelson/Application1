﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("goodbye");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("good day");
        }
    }
}
