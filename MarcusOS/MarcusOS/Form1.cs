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

        private void desligarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 Textos = new Form3();
            Textos.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Textos = new Form3();
            Textos.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 Virus = new Form4();
            Virus.Show();
        }

        private void trojanexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Virus = new Form4();
            Virus.Show();
        }
    }
}