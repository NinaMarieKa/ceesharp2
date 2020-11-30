namespace Kirjautumislomake
{
    partial class Paaikkuna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuljePaa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TervetuloaPN = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TervetuloaPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TervetuloaPN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 445);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa pääsivulle!";
            // 
            // SuljePaa
            // 
            this.SuljePaa.AutoSize = true;
            this.SuljePaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuljePaa.Location = new System.Drawing.Point(447, 0);
            this.SuljePaa.Name = "SuljePaa";
            this.SuljePaa.Size = new System.Drawing.Size(31, 29);
            this.SuljePaa.TabIndex = 1;
            this.SuljePaa.Text = "X";
            this.SuljePaa.Click += new System.EventHandler(this.SuljePaa_Click);
            this.SuljePaa.MouseEnter += new System.EventHandler(this.SuljePaa_MouseEnter);
            this.SuljePaa.MouseLeave += new System.EventHandler(this.SuljePaa_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kirjautumislomake.Properties.Resources.waving_hand_emoji_clipart_md;
            this.pictureBox1.Location = new System.Drawing.Point(77, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TervetuloaPN
            // 
            this.TervetuloaPN.BackColor = System.Drawing.Color.Gainsboro;
            this.TervetuloaPN.Controls.Add(this.label1);
            this.TervetuloaPN.Controls.Add(this.SuljePaa);
            this.TervetuloaPN.Location = new System.Drawing.Point(0, 0);
            this.TervetuloaPN.Name = "TervetuloaPN";
            this.TervetuloaPN.Size = new System.Drawing.Size(478, 90);
            this.TervetuloaPN.TabIndex = 3;
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paaikkuna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pääikkuna";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TervetuloaPN.ResumeLayout(false);
            this.TervetuloaPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SuljePaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TervetuloaPN;
    }
}