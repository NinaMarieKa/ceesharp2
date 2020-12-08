namespace HotelliProjekti
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuljeTastaLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalisKirjauduTB = new System.Windows.Forms.TextBox();
            this.KayttajaKirjauduTB = new System.Windows.Forms.TextBox();
            this.KirjauduTastaBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.SuljeTastaLB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 112);
            this.panel1.TabIndex = 0;
            // 
            // SuljeTastaLB
            // 
            this.SuljeTastaLB.AutoSize = true;
            this.SuljeTastaLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuljeTastaLB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuljeTastaLB.ForeColor = System.Drawing.Color.White;
            this.SuljeTastaLB.Location = new System.Drawing.Point(478, 0);
            this.SuljeTastaLB.Name = "SuljeTastaLB";
            this.SuljeTastaLB.Size = new System.Drawing.Size(32, 32);
            this.SuljeTastaLB.TabIndex = 2;
            this.SuljeTastaLB.Text = "X";
            this.SuljeTastaLB.Click += new System.EventHandler(this.SuljeTastaLB_Click);
            this.SuljeTastaLB.MouseEnter += new System.EventHandler(this.SuljeTastaLB_MouseEnter);
            this.SuljeTastaLB.MouseLeave += new System.EventHandler(this.SuljeTastaLB_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjaudu sisään";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalisKirjauduTB);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.KayttajaKirjauduTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // SalisKirjauduTB
            // 
            this.SalisKirjauduTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalisKirjauduTB.Location = new System.Drawing.Point(110, 129);
            this.SalisKirjauduTB.Name = "SalisKirjauduTB";
            this.SalisKirjauduTB.Size = new System.Drawing.Size(337, 39);
            this.SalisKirjauduTB.TabIndex = 4;
            this.SalisKirjauduTB.UseSystemPasswordChar = true;
            // 
            // KayttajaKirjauduTB
            // 
            this.KayttajaKirjauduTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaKirjauduTB.Location = new System.Drawing.Point(110, 49);
            this.KayttajaKirjauduTB.Name = "KayttajaKirjauduTB";
            this.KayttajaKirjauduTB.Size = new System.Drawing.Size(337, 39);
            this.KayttajaKirjauduTB.TabIndex = 1;
            // 
            // KirjauduTastaBTN
            // 
            this.KirjauduTastaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.KirjauduTastaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KirjauduTastaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduTastaBTN.ForeColor = System.Drawing.Color.White;
            this.KirjauduTastaBTN.Location = new System.Drawing.Point(122, 374);
            this.KirjauduTastaBTN.Name = "KirjauduTastaBTN";
            this.KirjauduTastaBTN.Size = new System.Drawing.Size(337, 47);
            this.KirjauduTastaBTN.TabIndex = 5;
            this.KirjauduTastaBTN.Text = "Kirjaudu";
            this.KirjauduTastaBTN.UseVisualStyleBackColor = false;
            this.KirjauduTastaBTN.Click += new System.EventHandler(this.KirjauduTastaBTN_Click);
            this.KirjauduTastaBTN.MouseEnter += new System.EventHandler(this.KirjauduTastaBTN_MouseEnter);
            this.KirjauduTastaBTN.MouseLeave += new System.EventHandler(this.KirjauduTastaBTN_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelliProjekti.Properties.Resources.lock_152879_640;
            this.pictureBox2.Location = new System.Drawing.Point(30, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelliProjekti.Properties.Resources.user_icon_2098873_640;
            this.pictureBox1.Location = new System.Drawing.Point(30, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.KirjauduTastaBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjaudu sisään";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox KayttajaKirjauduTB;
        private System.Windows.Forms.Label SuljeTastaLB;
        private System.Windows.Forms.TextBox SalisKirjauduTB;
        private System.Windows.Forms.Button KirjauduTastaBTN;
    }
}

