﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2___LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Usuario.Text == "Admin")&&(Contraseña.Text == "Admin12345"))
            {
                MessageBox.Show("Autorizado a ingresar");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        
        }
    }
}
