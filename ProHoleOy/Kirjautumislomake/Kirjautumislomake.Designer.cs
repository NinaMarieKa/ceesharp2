namespace Kirjautumislomake
{
    partial class Kirjautumislomake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirjautumislomake));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNKirjaudu = new System.Windows.Forms.Button();
            this.TBSalasana = new System.Windows.Forms.TextBox();
            this.TBKayttaja = new System.Windows.Forms.TextBox();
            this.Salasana = new System.Windows.Forms.Label();
            this.Kayttaja = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNKirjaudu);
            this.groupBox1.Controls.Add(this.TBSalasana);
            this.groupBox1.Controls.Add(this.TBKayttaja);
            this.groupBox1.Controls.Add(this.Salasana);
            this.groupBox1.Controls.Add(this.Kayttaja);
            this.groupBox1.Location = new System.Drawing.Point(65, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BTNKirjaudu
            // 
            this.BTNKirjaudu.BackColor = System.Drawing.Color.Black;
            this.BTNKirjaudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNKirjaudu.ForeColor = System.Drawing.Color.White;
            this.BTNKirjaudu.Location = new System.Drawing.Point(25, 189);
            this.BTNKirjaudu.Name = "BTNKirjaudu";
            this.BTNKirjaudu.Size = new System.Drawing.Size(524, 58);
            this.BTNKirjaudu.TabIndex = 2;
            this.BTNKirjaudu.Text = "Kirjaudu";
            this.BTNKirjaudu.UseVisualStyleBackColor = false;
            this.BTNKirjaudu.Click += new System.EventHandler(this.BTNKirjaudu_Click);
            // 
            // TBSalasana
            // 
            this.TBSalasana.BackColor = System.Drawing.SystemColors.InfoText;
            this.TBSalasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSalasana.ForeColor = System.Drawing.Color.White;
            this.TBSalasana.Location = new System.Drawing.Point(263, 119);
            this.TBSalasana.Name = "TBSalasana";
            this.TBSalasana.Size = new System.Drawing.Size(286, 39);
            this.TBSalasana.TabIndex = 5;
            // 
            // TBKayttaja
            // 
            this.TBKayttaja.BackColor = System.Drawing.SystemColors.InfoText;
            this.TBKayttaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKayttaja.ForeColor = System.Drawing.Color.White;
            this.TBKayttaja.Location = new System.Drawing.Point(263, 52);
            this.TBKayttaja.Name = "TBKayttaja";
            this.TBKayttaja.Size = new System.Drawing.Size(286, 39);
            this.TBKayttaja.TabIndex = 4;
            // 
            // Salasana
            // 
            this.Salasana.AutoSize = true;
            this.Salasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salasana.Location = new System.Drawing.Point(19, 122);
            this.Salasana.Name = "Salasana";
            this.Salasana.Size = new System.Drawing.Size(152, 32);
            this.Salasana.TabIndex = 3;
            this.Salasana.Text = "Salasana:";
            // 
            // Kayttaja
            // 
            this.Kayttaja.AutoSize = true;
            this.Kayttaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kayttaja.Location = new System.Drawing.Point(19, 55);
            this.Kayttaja.Name = "Kayttaja";
            this.Kayttaja.Size = new System.Drawing.Size(228, 32);
            this.Kayttaja.TabIndex = 2;
            this.Kayttaja.Text = "Käyttäjätunnus:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Kirjautumislomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kirjautumislomake";
            this.Text = "Kirjautumislomake";
      
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Kayttaja;
        private System.Windows.Forms.Button BTNKirjaudu;
        private System.Windows.Forms.TextBox TBSalasana;
        private System.Windows.Forms.TextBox TBKayttaja;
        private System.Windows.Forms.Label Salasana;
    }
}

