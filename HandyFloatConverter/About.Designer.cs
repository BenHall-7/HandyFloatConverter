namespace HandyFloatConverter
{
    partial class About
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
            this.pB_About = new System.Windows.Forms.PictureBox();
            this.text_AboutDescription = new System.Windows.Forms.TextBox();
            this.Text_Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_About)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_About
            // 
            this.pB_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pB_About.BackgroundImage = global::HandyFloatConverter.Properties.Resources.FoxImage;
            this.pB_About.Location = new System.Drawing.Point(122, 12);
            this.pB_About.Name = "pB_About";
            this.pB_About.Size = new System.Drawing.Size(100, 100);
            this.pB_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB_About.TabIndex = 0;
            this.pB_About.TabStop = false;
            // 
            // text_AboutDescription
            // 
            this.text_AboutDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_AboutDescription.Enabled = false;
            this.text_AboutDescription.Location = new System.Drawing.Point(12, 34);
            this.text_AboutDescription.Multiline = true;
            this.text_AboutDescription.Name = "text_AboutDescription";
            this.text_AboutDescription.ReadOnly = true;
            this.text_AboutDescription.Size = new System.Drawing.Size(100, 100);
            this.text_AboutDescription.TabIndex = 1;
            this.text_AboutDescription.TabStop = false;
            this.text_AboutDescription.Text = "This text replaced with text from the Resources.resx file";
            // 
            // Text_Description
            // 
            this.Text_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Description.Enabled = false;
            this.Text_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Text_Description.Location = new System.Drawing.Point(12, 12);
            this.Text_Description.Name = "Text_Description";
            this.Text_Description.ReadOnly = true;
            this.Text_Description.Size = new System.Drawing.Size(100, 16);
            this.Text_Description.TabIndex = 2;
            this.Text_Description.Text = "What is this?";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 136);
            this.Controls.Add(this.Text_Description);
            this.Controls.Add(this.text_AboutDescription);
            this.Controls.Add(this.pB_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(250, 175);
            this.MinimumSize = new System.Drawing.Size(250, 175);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pB_About)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_About;
        private System.Windows.Forms.TextBox text_AboutDescription;
        private System.Windows.Forms.TextBox Text_Description;
    }
}