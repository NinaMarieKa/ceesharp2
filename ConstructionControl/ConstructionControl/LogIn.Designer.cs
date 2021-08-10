namespace ConstructionControl
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInPNL = new System.Windows.Forms.Panel();
            this.kirjauduBTN = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.kayttajaLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logInPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logInPNL
            // 
            this.logInPNL.BackColor = System.Drawing.Color.DarkGray;
            this.logInPNL.Controls.Add(this.kirjauduBTN);
            this.logInPNL.Controls.Add(this.salasanaTB);
            this.logInPNL.Controls.Add(this.kayttajaTB);
            this.logInPNL.Controls.Add(this.salasanaLB);
            this.logInPNL.Controls.Add(this.kayttajaLB);
            this.logInPNL.Location = new System.Drawing.Point(0, 240);
            this.logInPNL.Name = "logInPNL";
            this.logInPNL.Size = new System.Drawing.Size(583, 359);
            this.logInPNL.TabIndex = 1;
            // 
            // kirjauduBTN
            // 
            this.kirjauduBTN.BackColor = System.Drawing.Color.Black;
            this.kirjauduBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduBTN.ForeColor = System.Drawing.Color.White;
            this.kirjauduBTN.Location = new System.Drawing.Point(81, 243);
            this.kirjauduBTN.Name = "kirjauduBTN";
            this.kirjauduBTN.Size = new System.Drawing.Size(440, 64);
            this.kirjauduBTN.TabIndex = 4;
            this.kirjauduBTN.Text = "Kirjaudu sisään";
            this.kirjauduBTN.UseVisualStyleBackColor = false;
            this.kirjauduBTN.Click += new System.EventHandler(this.kirjauduBTN_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaTB.Location = new System.Drawing.Point(292, 158);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(229, 35);
            this.salasanaTB.TabIndex = 3;
            this.salasanaTB.Text = "proholeoy";
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaTB.Location = new System.Drawing.Point(292, 77);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(229, 35);
            this.kayttajaTB.TabIndex = 2;
            this.kayttajaTB.Text = "markokon";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.ForeColor = System.Drawing.Color.White;
            this.salasanaLB.Location = new System.Drawing.Point(86, 161);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(127, 29);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaLB.ForeColor = System.Drawing.Color.White;
            this.kayttajaLB.Location = new System.Drawing.Point(86, 80);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(188, 29);
            this.kayttajaLB.TabIndex = 0;
            this.kayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 596);
            this.Controls.Add(this.logInPNL);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjaudu sisään";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logInPNL.ResumeLayout(false);
            this.logInPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel logInPNL;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label kayttajaLB;
        private System.Windows.Forms.Button kirjauduBTN;
    }
}

