
namespace MarcusOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            trojanexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            desligarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripDropDownButton1, toolStripLabel2, toolStripSeparator1, toolStripLabel1, toolStripButton1 });
            toolStrip1.Name = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { arquivosToolStripMenuItem, editorDeTextoToolStripMenuItem, iDEToolStripMenuItem, desligarToolStripMenuItem });
            resources.ApplyResources(toolStripDropDownButton1, "toolStripDropDownButton1");
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // arquivosToolStripMenuItem
            // 
            arquivosToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { trojanexeToolStripMenuItem });
            arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            resources.ApplyResources(arquivosToolStripMenuItem, "arquivosToolStripMenuItem");
            // 
            // trojanexeToolStripMenuItem
            // 
            trojanexeToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            trojanexeToolStripMenuItem.Name = "trojanexeToolStripMenuItem";
            resources.ApplyResources(trojanexeToolStripMenuItem, "trojanexeToolStripMenuItem");
            trojanexeToolStripMenuItem.Click += trojanexeToolStripMenuItem_Click_1;
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            resources.ApplyResources(editorDeTextoToolStripMenuItem, "editorDeTextoToolStripMenuItem");
            editorDeTextoToolStripMenuItem.Click += editorDeTextoToolStripMenuItem_Click_1;
            // 
            // iDEToolStripMenuItem
            // 
            iDEToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            iDEToolStripMenuItem.Name = "iDEToolStripMenuItem";
            resources.ApplyResources(iDEToolStripMenuItem, "iDEToolStripMenuItem");
            iDEToolStripMenuItem.Click += iDEToolStripMenuItem_Click;
            // 
            // desligarToolStripMenuItem
            // 
            desligarToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(desligarToolStripMenuItem, "desligarToolStripMenuItem");
            desligarToolStripMenuItem.Name = "desligarToolStripMenuItem";
            desligarToolStripMenuItem.Click += desligarToolStripMenuItem_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(toolStripLabel2, "toolStripLabel2");
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = System.Drawing.Color.HotPink;
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(toolStripLabel1, "toolStripLabel1");
            toolStripLabel1.Name = "toolStripLabel1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.Name = "toolStripButton1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Thistle;
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            TransparencyKey = System.Drawing.Color.MediumPurple;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem desligarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trojanexeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem iDEToolStripMenuItem;
    }
}

