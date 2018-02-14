namespace HandyFloatConverter
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.repositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tB_Hex = new System.Windows.Forms.TextBox();
            this.tB_Float = new System.Windows.Forms.TextBox();
            this.lb_Hex = new System.Windows.Forms.Label();
            this.lb_Float = new System.Windows.Forms.Label();
            this.cB_Double = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositoryToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip.Size = new System.Drawing.Size(259, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // repositoryToolStripMenuItem
            // 
            this.repositoryToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
            this.repositoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.repositoryToolStripMenuItem.Text = "Repository";
            this.repositoryToolStripMenuItem.Click += new System.EventHandler(this.repositoryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tB_Hex
            // 
            this.tB_Hex.Location = new System.Drawing.Point(51, 70);
            this.tB_Hex.Name = "tB_Hex";
            this.tB_Hex.Size = new System.Drawing.Size(130, 20);
            this.tB_Hex.TabIndex = 1;
            this.tB_Hex.TextChanged += new System.EventHandler(this.UpdateFloatFromHex);
            this.tB_Hex.Enter += new System.EventHandler(this.tB_Hex_Enter);
            // 
            // tB_Float
            // 
            this.tB_Float.Location = new System.Drawing.Point(51, 33);
            this.tB_Float.Name = "tB_Float";
            this.tB_Float.Size = new System.Drawing.Size(130, 20);
            this.tB_Float.TabIndex = 2;
            this.tB_Float.TextChanged += new System.EventHandler(this.UpdateHexFromFloat);
            this.tB_Float.Enter += new System.EventHandler(this.tB_Float_Enter);
            // 
            // lb_Hex
            // 
            this.lb_Hex.AutoSize = true;
            this.lb_Hex.Location = new System.Drawing.Point(24, 73);
            this.lb_Hex.Name = "lb_Hex";
            this.lb_Hex.Size = new System.Drawing.Size(21, 13);
            this.lb_Hex.TabIndex = 3;
            this.lb_Hex.Text = "0x:";
            // 
            // lb_Float
            // 
            this.lb_Float.AutoSize = true;
            this.lb_Float.Location = new System.Drawing.Point(12, 36);
            this.lb_Float.Name = "lb_Float";
            this.lb_Float.Size = new System.Drawing.Size(33, 13);
            this.lb_Float.TabIndex = 4;
            this.lb_Float.Text = "Float:";
            // 
            // cB_Double
            // 
            this.cB_Double.AutoSize = true;
            this.cB_Double.Location = new System.Drawing.Point(187, 36);
            this.cB_Double.Name = "cB_Double";
            this.cB_Double.Size = new System.Drawing.Size(60, 17);
            this.cB_Double.TabIndex = 5;
            this.cB_Double.Text = "Double";
            this.cB_Double.UseVisualStyleBackColor = true;
            this.cB_Double.CheckedChanged += new System.EventHandler(this.cB_Double_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 111);
            this.Controls.Add(this.cB_Double);
            this.Controls.Add(this.lb_Float);
            this.Controls.Add(this.lb_Hex);
            this.Controls.Add(this.tB_Float);
            this.Controls.Add(this.tB_Hex);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(275, 150);
            this.MinimumSize = new System.Drawing.Size(275, 150);
            this.Name = "MainForm";
            this.Text = "Float Converter";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem repositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox tB_Hex;
        private System.Windows.Forms.TextBox tB_Float;
        private System.Windows.Forms.Label lb_Hex;
        private System.Windows.Forms.Label lb_Float;
        private System.Windows.Forms.CheckBox cB_Double;
    }
}

