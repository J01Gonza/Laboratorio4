﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistorialServiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new ServiceReference1.WebService1SoapClient();
            String paciente = cliente.getHistorial("juang", textBox1.Text);
            label1.Text = paciente;
        }
    }
}
