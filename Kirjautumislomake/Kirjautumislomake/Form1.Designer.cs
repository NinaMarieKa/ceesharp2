namespace Kirjautumislomake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KirjauduPainike = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KirjauduSisaanLB = new System.Windows.Forms.Label();
            this.SuljeIkkuna = new System.Windows.Forms.Label();
            this.SiirryRek = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaLB.Location = new System.Drawing.Point(-5, 240);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(173, 29);
            this.KayttajaLB.TabIndex = 1;
            this.KayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTB.Location = new System.Drawing.Point(174, 237);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(300, 35);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(174, 311);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(300, 35);
            this.SalasanaTB.TabIndex = 4;
            this.SalasanaTB.UseSystemPasswordChar = true;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.Location = new System.Drawing.Point(50, 314);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(118, 29);
            this.SalasanaLB.TabIndex = 3;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KirjauduPainike
            // 
            this.KirjauduPainike.BackColor = System.Drawing.Color.DimGray;
            this.KirjauduPainike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KirjauduPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduPainike.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KirjauduPainike.Location = new System.Drawing.Point(174, 375);
            this.KirjauduPainike.Name = "KirjauduPainike";
            this.KirjauduPainike.Size = new System.Drawing.Size(144, 44);
            this.KirjauduPainike.TabIndex = 6;
            this.KirjauduPainike.Text = "Kirjaudu";
            this.KirjauduPainike.UseVisualStyleBackColor = false;
            this.KirjauduPainike.Click += new System.EventHandler(this.KirjauduPainike_Click);
            this.KirjauduPainike.MouseEnter += new System.EventHandler(this.KirjauduPainike_MouseEnter);
            this.KirjauduPainike.MouseLeave += new System.EventHandler(this.KirjauduPainike_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.SuljeIkkuna);
            this.panel1.Controls.Add(this.KirjauduSisaanLB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 100);
            this.panel1.TabIndex = 7;
            // 
            // KirjauduSisaanLB
            // 
            this.KirjauduSisaanLB.AutoSize = true;
            this.KirjauduSisaanLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduSisaanLB.Location = new System.Drawing.Point(81, 27);
            this.KirjauduSisaanLB.Name = "KirjauduSisaanLB";
            this.KirjauduSisaanLB.Size = new System.Drawing.Size(307, 46);
            this.KirjauduSisaanLB.TabIndex = 0;
            this.KirjauduSisaanLB.Text = "Kirjaudu sisään";
            this.KirjauduSisaanLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuljeIkkuna
            // 
            this.SuljeIkkuna.AutoSize = true;
            this.SuljeIkkuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuljeIkkuna.Location = new System.Drawing.Point(448, 0);
            this.SuljeIkkuna.Name = "SuljeIkkuna";
            this.SuljeIkkuna.Size = new System.Drawing.Size(34, 32);
            this.SuljeIkkuna.TabIndex = 1;
            this.SuljeIkkuna.Text = "X";
            this.SuljeIkkuna.Click += new System.EventHandler(this.SuljeIkkuna_Click);
            this.SuljeIkkuna.MouseEnter += new System.EventHandler(this.SuljeIkkuna_MouseEnter);
            this.SuljeIkkuna.MouseLeave += new System.EventHandler(this.SuljeIkkuna_MouseLeave);
            // 
            // SiirryRek
            // 
            this.SiirryRek.AutoSize = true;
            this.SiirryRek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiirryRek.Location = new System.Drawing.Point(72, 442);
            this.SiirryRek.Name = "SiirryRek";
            this.SiirryRek.Size = new System.Drawing.Size(344, 29);
            this.SiirryRek.TabIndex = 8;
            this.SiirryRek.Text = "Ei tunnusta? Rekisteröidy tästä!";
            this.SiirryRek.Click += new System.EventHandler(this.SiirryRek_Click);
            this.SiirryRek.MouseEnter += new System.EventHandler(this.SiirryRek_MouseEnter);
            this.SiirryRek.MouseLeave += new System.EventHandler(this.SiirryRek_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kirjautumislomake.Properties.Resources.lock_152879_640;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kirjautumislomake.Properties.Resources.user_icon_2098873_640;
            this.pictureBox1.Location = new System.Drawing.Point(197, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(478, 516);
            this.Controls.Add(this.SiirryRek);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KirjauduPainike);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.SalasanaLB);
            this.Controls.Add(this.KayttajaTB);
            this.Controls.Add(this.KayttajaLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjautumisikkuna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button KirjauduPainike;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KirjauduSisaanLB;
        private System.Windows.Forms.Label SuljeIkkuna;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SiirryRek;
    }
}

