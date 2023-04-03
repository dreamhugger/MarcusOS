using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarcusOS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e) //Apaga o texto da caixa de texto.
        {
            richTextBox1.Text = string.Empty;
        }

        private void editorDeCósdigoToolStripMenuItem_Click(object sender, EventArgs e) //Abre o formulário 2 (mockup de IDE) e fecha esse formulário.
        {
            Form2 IDE = new Form2();
            IDE.Show();
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //Muda o tamanho da fonte da Caixa de Texto relativo a barra.
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, trackBar1.Value);
        }
    }
}
