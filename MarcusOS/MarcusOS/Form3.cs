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

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void editorDeCósdigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 IDE = new Form2();
            IDE.Show();
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, trackBar1.Value);
        }
    }
}
