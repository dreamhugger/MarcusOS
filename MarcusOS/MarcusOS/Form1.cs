using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MarcusOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e) //Mostra e mantém atualizado o horário atual do computador.
        {
            toolStripLabel1.Text = DateTime.Now.ToString();
        }

        private void desligarToolStripMenuItem_Click(object sender, EventArgs e) //Fecha a aplicação.
        {
            this.Close();
        }

        private void editorDeTextoToolStripMenuItem_Click_1(object sender, EventArgs e) //Abre o formulário 3 (mockup de editor de texto).
        {
            Form3 Textos = new Form3();
            Textos.Show();
        }

        private void trojanexeToolStripMenuItem_Click_1(object sender, EventArgs e) //Abre o formulário 4 (gif/mockup de vírus).
        {
            Form4 Barata = new Form4();
            Barata.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e) //Abre o formulário 4 (gif/mockup de vírus).
        {
            Form4 Barata = new Form4();
            Barata.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e) //Abre o formulário 3 (mockup de editor de texto).
        {
            Form3 Textos = new Form3();
            Textos.Show();
        }

        private void iDEToolStripMenuItem_Click(object sender, EventArgs e) //Abre o formulário 2 (mockup de IDE).
        {
            Form2 IDE = new Form2();
            IDE.Show();
        }
    }
}