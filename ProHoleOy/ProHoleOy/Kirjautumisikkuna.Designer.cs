namespace ProHoleOy
{
    partial class Kirjautumisikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirjautumisikkuna));
            this.TunnuksetPNL = new System.Windows.Forms.Panel();
            this.kirjauduBTN = new System.Windows.Forms.Button();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.logoPNL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TunnuksetPNL.SuspendLayout();
            this.logoPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TunnuksetPNL
            // 
            this.TunnuksetPNL.BackColor = System.Drawing.Color.Black;
            this.TunnuksetPNL.Controls.Add(this.kirjauduBTN);
            this.TunnuksetPNL.Controls.Add(this.kayttajaTB);
            this.TunnuksetPNL.Controls.Add(this.salasanaTB);
            this.TunnuksetPNL.Controls.Add(this.salasanaLB);
            this.TunnuksetPNL.Controls.Add(this.KayttajaLB);
            this.TunnuksetPNL.Location = new System.Drawing.Point(12, 185);
            this.TunnuksetPNL.Name = "TunnuksetPNL";
            this.TunnuksetPNL.Size = new System.Drawing.Size(475, 253);
            this.TunnuksetPNL.TabIndex = 0;
            // 
            // kirjauduBTN
            // 
            this.kirjauduBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduBTN.Location = new System.Drawing.Point(225, 187);
            this.kirjauduBTN.Name = "kirjauduBTN";
            this.kirjauduBTN.Size = new System.Drawing.Size(194, 28);
            this.kirjauduBTN.TabIndex = 4;
            this.kirjauduBTN.Text = "Kirjaudu sisään";
            this.kirjauduBTN.UseVisualStyleBackColor = true;
            this.kirjauduBTN.Click += new System.EventHandler(this.kirjauduBTN_Click);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaTB.Location = new System.Drawing.Point(225, 59);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(194, 26);
            this.kayttajaTB.TabIndex = 1;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaTB.Location = new System.Drawing.Point(225, 122);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(194, 26);
            this.salasanaTB.TabIndex = 2;
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.ForeColor = System.Drawing.Color.White;
            this.salasanaLB.Location = new System.Drawing.Point(24, 125);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(89, 20);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaLB.ForeColor = System.Drawing.Color.White;
            this.KayttajaLB.Location = new System.Drawing.Point(24, 62);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(134, 20);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // logoPNL
            // 
            this.logoPNL.BackColor = System.Drawing.Color.White;
            this.logoPNL.Controls.Add(this.pictureBox1);
            this.logoPNL.Location = new System.Drawing.Point(12, 28);
            this.logoPNL.Name = "logoPNL";
            this.logoPNL.Size = new System.Drawing.Size(475, 159);
            this.logoPNL.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProHoleOy.Properties.Resources._7000108302;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Kirjautumisikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.logoPNL);
            this.Controls.Add(this.TunnuksetPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kirjautumisikkuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjautumisikkuna";
            this.TunnuksetPNL.ResumeLayout(false);
            this.TunnuksetPNL.PerformLayout();
            this.logoPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TunnuksetPNL;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.Panel logoPNL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kirjauduBTN;
    }
}