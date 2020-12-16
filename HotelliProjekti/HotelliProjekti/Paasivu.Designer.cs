namespace HotelliProjekti
{
    partial class Paasivu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asiakkaidenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varaustenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huoneidenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 115);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tervetuloa hallintasivulle! Valitse toiminto ylläolevasta valikosta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asiakkaidenHallintaToolStripMenuItem,
            this.varaustenHallintaToolStripMenuItem,
            this.huoneidenHallintaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asiakkaidenHallintaToolStripMenuItem
            // 
            this.asiakkaidenHallintaToolStripMenuItem.Name = "asiakkaidenHallintaToolStripMenuItem";
            this.asiakkaidenHallintaToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.asiakkaidenHallintaToolStripMenuItem.Text = "Asiakkaiden hallinta";
            this.asiakkaidenHallintaToolStripMenuItem.Click += new System.EventHandler(this.asiakkaidenHallintaToolStripMenuItem_Click);
            // 
            // varaustenHallintaToolStripMenuItem
            // 
            this.varaustenHallintaToolStripMenuItem.Name = "varaustenHallintaToolStripMenuItem";
            this.varaustenHallintaToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.varaustenHallintaToolStripMenuItem.Text = "Varausten hallinta";
            this.varaustenHallintaToolStripMenuItem.Click += new System.EventHandler(this.varaustenHallintaToolStripMenuItem_Click);
            // 
            // huoneidenHallintaToolStripMenuItem
            // 
            this.huoneidenHallintaToolStripMenuItem.Name = "huoneidenHallintaToolStripMenuItem";
            this.huoneidenHallintaToolStripMenuItem.Size = new System.Drawing.Size(176, 29);
            this.huoneidenHallintaToolStripMenuItem.Text = "Huoneiden hallinta";
            this.huoneidenHallintaToolStripMenuItem.Click += new System.EventHandler(this.huoneidenHallintaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelliProjekti.Properties.Resources.roomservice;
            this.pictureBox1.Location = new System.Drawing.Point(55, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Paasivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1121, 707);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paasivu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pääsivu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Paasivu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asiakkaidenHallintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varaustenHallintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huoneidenHallintaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}