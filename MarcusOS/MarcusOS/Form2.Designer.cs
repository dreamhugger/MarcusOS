
namespace MarcusOS
{
    partial class Form2
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
            textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.ForeColor = System.Drawing.Color.PaleGreen;
            richTextBox1.Location = new System.Drawing.Point(0, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(584, 536);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "#Código de Exemplo \n\nimport random\nimport os\n\nif random.randint(0, 6) == 1:\n\tos.remove(\"C:\\MarcusOS\\System21\")";
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
            modoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { textoToolStripMenuItem, iDEToolStripMenuItem });
            modoToolStripMenuItem.Name = "modoToolStripMenuItem";
            modoToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            modoToolStripMenuItem.Text = "Modo";
            // 
            // textoToolStripMenuItem
            // 
            textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            textoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            textoToolStripMenuItem.Text = "Bloco de Notas";
            textoToolStripMenuItem.Click += textoToolStripMenuItem_Click;
            // 
            // iDEToolStripMenuItem
            // 
            iDEToolStripMenuItem.Checked = true;
            iDEToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            iDEToolStripMenuItem.Enabled = false;
            iDEToolStripMenuItem.Name = "iDEToolStripMenuItem";
            iDEToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            iDEToolStripMenuItem.Text = "Editor de Código";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(584, 561);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Textos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDEToolStripMenuItem;
    }
}