﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarcusOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e) //Abre o formulário 3 (mockup de editor de texto) e fecha esse formulário.
        {
            Form3 Textos = new Form3();
            Textos.Show();
            this.Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e) //Apaga o texto da caixa de texto.
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
