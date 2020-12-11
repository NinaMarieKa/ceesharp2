namespace HotelliProjekti
{
    partial class HallitseAsiakkaita
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
            this.AsiakasData = new System.Windows.Forms.DataGridView();
            this.AsiakasEtunimiLB = new System.Windows.Forms.Label();
            this.AsiakasSukunimiLB = new System.Windows.Forms.Label();
            this.AsiakasOsoiteLB = new System.Windows.Forms.Label();
            this.AsiakasPostinumeroLB = new System.Windows.Forms.Label();
            this.AsiakasToimipaikkaLB = new System.Windows.Forms.Label();
            this.AsiakasKayttajaLB = new System.Windows.Forms.Label();
            this.AsiakasSalasanaLB = new System.Windows.Forms.Label();
            this.AsiakasEtunimiTB = new System.Windows.Forms.TextBox();
            this.AsiakasSukunimiTB = new System.Windows.Forms.TextBox();
            this.AsiakasOsoiteTB = new System.Windows.Forms.TextBox();
            this.AsiakasPostinumeroTB = new System.Windows.Forms.TextBox();
            this.AsiakasToimipaikkaTB = new System.Windows.Forms.TextBox();
            this.AsiakasKayttajaTB = new System.Windows.Forms.TextBox();
            this.AsiakasSalasanaTB = new System.Windows.Forms.TextBox();
            this.AsiakasMuokkaaBTN = new System.Windows.Forms.Button();
            this.UusiAsiakasBTN = new System.Windows.Forms.Button();
            this.AsiakasPoistaBTN = new System.Windows.Forms.Button();
            this.AsiakasTyhjennaBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakasData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(392, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallitse asiakkaita";
            // 
            // AsiakasData
            // 
            this.AsiakasData.AllowUserToAddRows = false;
            this.AsiakasData.AllowUserToDeleteRows = false;
            this.AsiakasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsiakasData.Location = new System.Drawing.Point(599, 155);
            this.AsiakasData.Name = "AsiakasData";
            this.AsiakasData.ReadOnly = true;
            this.AsiakasData.RowHeadersWidth = 62;
            this.AsiakasData.RowTemplate.Height = 28;
            this.AsiakasData.Size = new System.Drawing.Size(559, 512);
            this.AsiakasData.TabIndex = 1;
            this.AsiakasData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsiakasData_CellClick);
            // 
            // AsiakasEtunimiLB
            // 
            this.AsiakasEtunimiLB.AutoSize = true;
            this.AsiakasEtunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasEtunimiLB.Location = new System.Drawing.Point(28, 203);
            this.AsiakasEtunimiLB.Name = "AsiakasEtunimiLB";
            this.AsiakasEtunimiLB.Size = new System.Drawing.Size(99, 29);
            this.AsiakasEtunimiLB.TabIndex = 2;
            this.AsiakasEtunimiLB.Text = "Etunimi:";
            // 
            // AsiakasSukunimiLB
            // 
            this.AsiakasSukunimiLB.AutoSize = true;
            this.AsiakasSukunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasSukunimiLB.Location = new System.Drawing.Point(28, 257);
            this.AsiakasSukunimiLB.Name = "AsiakasSukunimiLB";
            this.AsiakasSukunimiLB.Size = new System.Drawing.Size(118, 29);
            this.AsiakasSukunimiLB.TabIndex = 3;
            this.AsiakasSukunimiLB.Text = "Sukunimi:";
            // 
            // AsiakasOsoiteLB
            // 
            this.AsiakasOsoiteLB.AutoSize = true;
            this.AsiakasOsoiteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasOsoiteLB.Location = new System.Drawing.Point(28, 306);
            this.AsiakasOsoiteLB.Name = "AsiakasOsoiteLB";
            this.AsiakasOsoiteLB.Size = new System.Drawing.Size(130, 29);
            this.AsiakasOsoiteLB.TabIndex = 4;
            this.AsiakasOsoiteLB.Text = "Lähiosoite:";
            // 
            // AsiakasPostinumeroLB
            // 
            this.AsiakasPostinumeroLB.AutoSize = true;
            this.AsiakasPostinumeroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasPostinumeroLB.Location = new System.Drawing.Point(28, 356);
            this.AsiakasPostinumeroLB.Name = "AsiakasPostinumeroLB";
            this.AsiakasPostinumeroLB.Size = new System.Drawing.Size(155, 29);
            this.AsiakasPostinumeroLB.TabIndex = 5;
            this.AsiakasPostinumeroLB.Text = "Postinumero:";
            // 
            // AsiakasToimipaikkaLB
            // 
            this.AsiakasToimipaikkaLB.AutoSize = true;
            this.AsiakasToimipaikkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasToimipaikkaLB.Location = new System.Drawing.Point(28, 408);
            this.AsiakasToimipaikkaLB.Name = "AsiakasToimipaikkaLB";
            this.AsiakasToimipaikkaLB.Size = new System.Drawing.Size(195, 29);
            this.AsiakasToimipaikkaLB.TabIndex = 6;
            this.AsiakasToimipaikkaLB.Text = "Postitoimipaikka:";
            // 
            // AsiakasKayttajaLB
            // 
            this.AsiakasKayttajaLB.AutoSize = true;
            this.AsiakasKayttajaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasKayttajaLB.Location = new System.Drawing.Point(28, 459);
            this.AsiakasKayttajaLB.Name = "AsiakasKayttajaLB";
            this.AsiakasKayttajaLB.Size = new System.Drawing.Size(173, 29);
            this.AsiakasKayttajaLB.TabIndex = 7;
            this.AsiakasKayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // AsiakasSalasanaLB
            // 
            this.AsiakasSalasanaLB.AutoSize = true;
            this.AsiakasSalasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasSalasanaLB.Location = new System.Drawing.Point(28, 508);
            this.AsiakasSalasanaLB.Name = "AsiakasSalasanaLB";
            this.AsiakasSalasanaLB.Size = new System.Drawing.Size(118, 29);
            this.AsiakasSalasanaLB.TabIndex = 8;
            this.AsiakasSalasanaLB.Text = "Salasana:";
            // 
            // AsiakasEtunimiTB
            // 
            this.AsiakasEtunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasEtunimiTB.Location = new System.Drawing.Point(248, 200);
            this.AsiakasEtunimiTB.Name = "AsiakasEtunimiTB";
            this.AsiakasEtunimiTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasEtunimiTB.TabIndex = 9;
            // 
            // AsiakasSukunimiTB
            // 
            this.AsiakasSukunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasSukunimiTB.Location = new System.Drawing.Point(248, 254);
            this.AsiakasSukunimiTB.Name = "AsiakasSukunimiTB";
            this.AsiakasSukunimiTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasSukunimiTB.TabIndex = 10;
            // 
            // AsiakasOsoiteTB
            // 
            this.AsiakasOsoiteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasOsoiteTB.Location = new System.Drawing.Point(248, 303);
            this.AsiakasOsoiteTB.Name = "AsiakasOsoiteTB";
            this.AsiakasOsoiteTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasOsoiteTB.TabIndex = 11;
            // 
            // AsiakasPostinumeroTB
            // 
            this.AsiakasPostinumeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasPostinumeroTB.Location = new System.Drawing.Point(248, 353);
            this.AsiakasPostinumeroTB.Name = "AsiakasPostinumeroTB";
            this.AsiakasPostinumeroTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasPostinumeroTB.TabIndex = 12;
            
            // 
            // AsiakasToimipaikkaTB
            // 
            this.AsiakasToimipaikkaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasToimipaikkaTB.Location = new System.Drawing.Point(248, 405);
            this.AsiakasToimipaikkaTB.Name = "AsiakasToimipaikkaTB";
            this.AsiakasToimipaikkaTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasToimipaikkaTB.TabIndex = 13;
            // 
            // AsiakasKayttajaTB
            // 
            this.AsiakasKayttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasKayttajaTB.Location = new System.Drawing.Point(248, 456);
            this.AsiakasKayttajaTB.Name = "AsiakasKayttajaTB";
            this.AsiakasKayttajaTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasKayttajaTB.TabIndex = 14;
           
            // 
            // AsiakasSalasanaTB
            // 
            this.AsiakasSalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasSalasanaTB.Location = new System.Drawing.Point(248, 505);
            this.AsiakasSalasanaTB.Name = "AsiakasSalasanaTB";
            this.AsiakasSalasanaTB.Size = new System.Drawing.Size(331, 35);
            this.AsiakasSalasanaTB.TabIndex = 15;
            // 
            // AsiakasMuokkaaBTN
            // 
            this.AsiakasMuokkaaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.AsiakasMuokkaaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasMuokkaaBTN.ForeColor = System.Drawing.Color.White;
            this.AsiakasMuokkaaBTN.Location = new System.Drawing.Point(320, 556);
            this.AsiakasMuokkaaBTN.Name = "AsiakasMuokkaaBTN";
            this.AsiakasMuokkaaBTN.Size = new System.Drawing.Size(131, 44);
            this.AsiakasMuokkaaBTN.TabIndex = 16;
            this.AsiakasMuokkaaBTN.Text = "Muokkaa";
            this.AsiakasMuokkaaBTN.UseVisualStyleBackColor = false;
            this.AsiakasMuokkaaBTN.Click += new System.EventHandler(this.AsiakasMuokkaaBTN_Click);
            // 
            // UusiAsiakasBTN
            // 
            this.UusiAsiakasBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.UusiAsiakasBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiAsiakasBTN.ForeColor = System.Drawing.Color.White;
            this.UusiAsiakasBTN.Location = new System.Drawing.Point(92, 556);
            this.UusiAsiakasBTN.Name = "UusiAsiakasBTN";
            this.UusiAsiakasBTN.Size = new System.Drawing.Size(222, 44);
            this.UusiAsiakasBTN.TabIndex = 17;
            this.UusiAsiakasBTN.Text = "Lisää uusi asiakas";
            this.UusiAsiakasBTN.UseVisualStyleBackColor = false;
            this.UusiAsiakasBTN.Click += new System.EventHandler(this.UusiAsiakasBTN_Click);
            // 
            // AsiakasPoistaBTN
            // 
            this.AsiakasPoistaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.AsiakasPoistaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasPoistaBTN.ForeColor = System.Drawing.Color.White;
            this.AsiakasPoistaBTN.Location = new System.Drawing.Point(457, 556);
            this.AsiakasPoistaBTN.Name = "AsiakasPoistaBTN";
            this.AsiakasPoistaBTN.Size = new System.Drawing.Size(84, 44);
            this.AsiakasPoistaBTN.TabIndex = 18;
            this.AsiakasPoistaBTN.Text = "Poista";
            this.AsiakasPoistaBTN.UseVisualStyleBackColor = false;
            this.AsiakasPoistaBTN.Click += new System.EventHandler(this.AsiakasPoistaBTN_Click);
            // 
            // AsiakasTyhjennaBTN
            // 
            this.AsiakasTyhjennaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.AsiakasTyhjennaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasTyhjennaBTN.ForeColor = System.Drawing.Color.White;
            this.AsiakasTyhjennaBTN.Location = new System.Drawing.Point(92, 615);
            this.AsiakasTyhjennaBTN.Name = "AsiakasTyhjennaBTN";
            this.AsiakasTyhjennaBTN.Size = new System.Drawing.Size(449, 52);
            this.AsiakasTyhjennaBTN.TabIndex = 19;
            this.AsiakasTyhjennaBTN.Text = "Tyhjennä kentät";
            this.AsiakasTyhjennaBTN.UseVisualStyleBackColor = false;
            this.AsiakasTyhjennaBTN.Click += new System.EventHandler(this.AsiakasTyhjennaBTN_Click);
            // 
            // HallitseAsiakkaita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1179, 688);
            this.Controls.Add(this.AsiakasTyhjennaBTN);
            this.Controls.Add(this.AsiakasPoistaBTN);
            this.Controls.Add(this.UusiAsiakasBTN);
            this.Controls.Add(this.AsiakasMuokkaaBTN);
            this.Controls.Add(this.AsiakasSalasanaTB);
            this.Controls.Add(this.AsiakasKayttajaTB);
            this.Controls.Add(this.AsiakasToimipaikkaTB);
            this.Controls.Add(this.AsiakasPostinumeroTB);
            this.Controls.Add(this.AsiakasOsoiteTB);
            this.Controls.Add(this.AsiakasSukunimiTB);
            this.Controls.Add(this.AsiakasEtunimiTB);
            this.Controls.Add(this.AsiakasSalasanaLB);
            this.Controls.Add(this.AsiakasKayttajaLB);
            this.Controls.Add(this.AsiakasToimipaikkaLB);
            this.Controls.Add(this.AsiakasPostinumeroLB);
            this.Controls.Add(this.AsiakasOsoiteLB);
            this.Controls.Add(this.AsiakasSukunimiLB);
            this.Controls.Add(this.AsiakasEtunimiLB);
            this.Controls.Add(this.AsiakasData);
            this.Controls.Add(this.panel1);
            this.Name = "HallitseAsiakkaita";
            this.Text = "HallitseAsiakkaita";
            this.Load += new System.EventHandler(this.HallitseAsiakkaita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakasData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AsiakasData;
        private System.Windows.Forms.Label AsiakasEtunimiLB;
        private System.Windows.Forms.Label AsiakasSukunimiLB;
        private System.Windows.Forms.Label AsiakasOsoiteLB;
        private System.Windows.Forms.Label AsiakasPostinumeroLB;
        private System.Windows.Forms.Label AsiakasToimipaikkaLB;
        private System.Windows.Forms.Label AsiakasKayttajaLB;
        private System.Windows.Forms.Label AsiakasSalasanaLB;
        private System.Windows.Forms.TextBox AsiakasEtunimiTB;
        private System.Windows.Forms.TextBox AsiakasSukunimiTB;
        private System.Windows.Forms.TextBox AsiakasOsoiteTB;
        private System.Windows.Forms.TextBox AsiakasPostinumeroTB;
        private System.Windows.Forms.TextBox AsiakasToimipaikkaTB;
        private System.Windows.Forms.TextBox AsiakasKayttajaTB;
        private System.Windows.Forms.TextBox AsiakasSalasanaTB;
        private System.Windows.Forms.Button AsiakasMuokkaaBTN;
        private System.Windows.Forms.Button UusiAsiakasBTN;
        private System.Windows.Forms.Button AsiakasPoistaBTN;
        private System.Windows.Forms.Button AsiakasTyhjennaBTN;
    }
}