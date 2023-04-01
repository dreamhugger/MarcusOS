
namespace MarcusOS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editorDeCósdigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            trackBar1 = new System.Windows.Forms.TrackBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(0, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(584, 536);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Boa digitação! :D";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { novoToolStripMenuItem, modoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(584, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // modoToolStripMenuItem
            // 
            modoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { blocoDeNotasToolStripMenuItem, editorDeCósdigoToolStripMenuItem });
            modoToolStripMenuItem.Name = "modoToolStripMenuItem";
            modoToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            modoToolStripMenuItem.Text = "Modo";
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Checked = true;
            blocoDeNotasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            blocoDeNotasToolStripMenuItem.Enabled = false;
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            // 
            // editorDeCósdigoToolStripMenuItem
            // 
            editorDeCósdigoToolStripMenuItem.Name = "editorDeCósdigoToolStripMenuItem";
            editorDeCósdigoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            editorDeCósdigoToolStripMenuItem.Text = "Editor de Código";
            editorDeCósdigoToolStripMenuItem.Click += editorDeCósdigoToolStripMenuItem_Click;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.LargeChange = 1;
            trackBar1.Location = new System.Drawing.Point(0, 529);
            trackBar1.Maximum = 30;
            trackBar1.Minimum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(584, 32);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SteelBlue;
            ClientSize = new System.Drawing.Size(584, 561);
            Controls.Add(trackBar1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Textos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeCósdigoToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}