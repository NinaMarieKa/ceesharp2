namespace HotelliProjekti
{
    partial class HallitseVarauksia
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
            this.dataVaraukset = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VarausMuokkaaBTN = new System.Windows.Forms.Button();
            this.UusiVarausBTN = new System.Windows.Forms.Button();
            this.VarausPoistaBTN = new System.Windows.Forms.Button();
            this.VarausTyhjennaBTN = new System.Windows.Forms.Button();
            this.VarausAsNumeroTB = new System.Windows.Forms.TextBox();
            this.VarausNumeroTB = new System.Windows.Forms.TextBox();
            this.dateTimeSisaan = new System.Windows.Forms.DateTimePicker();
            this.dateTimeUlos = new System.Windows.Forms.DateTimePicker();
            this.VarausHuoneenTyyppiCB = new System.Windows.Forms.ComboBox();
            this.VarausHuoneenNumeroCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hallitse varauksia";
            // 
            // dataVaraukset
            // 
            this.dataVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVaraukset.Location = new System.Drawing.Point(596, 112);
            this.dataVaraukset.Name = "dataVaraukset";
            this.dataVaraukset.RowHeadersWidth = 62;
            this.dataVaraukset.RowTemplate.Height = 28;
            this.dataVaraukset.Size = new System.Drawing.Size(539, 536);
            this.dataVaraukset.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varausnumero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asiakasnumero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Huone tyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Huoneen numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sisään kirjautuminen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ulos kirjautuminen:";
            // 
            // VarausMuokkaaBTN
            // 
            this.VarausMuokkaaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.VarausMuokkaaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausMuokkaaBTN.ForeColor = System.Drawing.Color.White;
            this.VarausMuokkaaBTN.Location = new System.Drawing.Point(284, 501);
            this.VarausMuokkaaBTN.Name = "VarausMuokkaaBTN";
            this.VarausMuokkaaBTN.Size = new System.Drawing.Size(159, 49);
            this.VarausMuokkaaBTN.TabIndex = 17;
            this.VarausMuokkaaBTN.Text = "Muokkaa";
            this.VarausMuokkaaBTN.UseVisualStyleBackColor = false;
            // 
            // UusiVarausBTN
            // 
            this.UusiVarausBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.UusiVarausBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiVarausBTN.ForeColor = System.Drawing.Color.White;
            this.UusiVarausBTN.Location = new System.Drawing.Point(59, 501);
            this.UusiVarausBTN.Name = "UusiVarausBTN";
            this.UusiVarausBTN.Size = new System.Drawing.Size(222, 49);
            this.UusiVarausBTN.TabIndex = 18;
            this.UusiVarausBTN.Text = "Lisää uusi varaus";
            this.UusiVarausBTN.UseVisualStyleBackColor = false;
            // 
            // VarausPoistaBTN
            // 
            this.VarausPoistaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.VarausPoistaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausPoistaBTN.ForeColor = System.Drawing.Color.White;
            this.VarausPoistaBTN.Location = new System.Drawing.Point(449, 501);
            this.VarausPoistaBTN.Name = "VarausPoistaBTN";
            this.VarausPoistaBTN.Size = new System.Drawing.Size(107, 49);
            this.VarausPoistaBTN.TabIndex = 19;
            this.VarausPoistaBTN.Text = "Poista";
            this.VarausPoistaBTN.UseVisualStyleBackColor = false;
            // 
            // VarausTyhjennaBTN
            // 
            this.VarausTyhjennaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.VarausTyhjennaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausTyhjennaBTN.ForeColor = System.Drawing.Color.White;
            this.VarausTyhjennaBTN.Location = new System.Drawing.Point(59, 566);
            this.VarausTyhjennaBTN.Name = "VarausTyhjennaBTN";
            this.VarausTyhjennaBTN.Size = new System.Drawing.Size(497, 49);
            this.VarausTyhjennaBTN.TabIndex = 20;
            this.VarausTyhjennaBTN.Text = "Tyhjennä kentät";
            this.VarausTyhjennaBTN.UseVisualStyleBackColor = false;
            // 
            // VarausAsNumeroTB
            // 
            this.VarausAsNumeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausAsNumeroTB.Location = new System.Drawing.Point(256, 125);
            this.VarausAsNumeroTB.Name = "VarausAsNumeroTB";
            this.VarausAsNumeroTB.Size = new System.Drawing.Size(331, 35);
            this.VarausAsNumeroTB.TabIndex = 21;
            // 
            // VarausNumeroTB
            // 
            this.VarausNumeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausNumeroTB.Location = new System.Drawing.Point(256, 171);
            this.VarausNumeroTB.Name = "VarausNumeroTB";
            this.VarausNumeroTB.Size = new System.Drawing.Size(331, 35);
            this.VarausNumeroTB.TabIndex = 22;
            // 
            // dateTimeSisaan
            // 
            this.dateTimeSisaan.CustomFormat = "dd/MM/yyyy";
            this.dateTimeSisaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSisaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSisaan.Location = new System.Drawing.Point(259, 352);
            this.dateTimeSisaan.Name = "dateTimeSisaan";
            this.dateTimeSisaan.Size = new System.Drawing.Size(324, 35);
            this.dateTimeSisaan.TabIndex = 25;
            // 
            // dateTimeUlos
            // 
            this.dateTimeUlos.CustomFormat = "dd/MM/yyyy";
            this.dateTimeUlos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeUlos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeUlos.Location = new System.Drawing.Point(259, 416);
            this.dateTimeUlos.Name = "dateTimeUlos";
            this.dateTimeUlos.Size = new System.Drawing.Size(328, 35);
            this.dateTimeUlos.TabIndex = 26;
            // 
            // VarausHuoneenTyyppiCB
            // 
            this.VarausHuoneenTyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarausHuoneenTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausHuoneenTyyppiCB.FormattingEnabled = true;
            this.VarausHuoneenTyyppiCB.Location = new System.Drawing.Point(256, 225);
            this.VarausHuoneenTyyppiCB.Name = "VarausHuoneenTyyppiCB";
            this.VarausHuoneenTyyppiCB.Size = new System.Drawing.Size(327, 37);
            this.VarausHuoneenTyyppiCB.TabIndex = 33;
            // 
            // VarausHuoneenNumeroCB
            // 
            this.VarausHuoneenNumeroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarausHuoneenNumeroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausHuoneenNumeroCB.FormattingEnabled = true;
            this.VarausHuoneenNumeroCB.Location = new System.Drawing.Point(256, 280);
            this.VarausHuoneenNumeroCB.Name = "VarausHuoneenNumeroCB";
            this.VarausHuoneenNumeroCB.Size = new System.Drawing.Size(327, 37);
            this.VarausHuoneenNumeroCB.TabIndex = 34;
            // 
            // HallitseVarauksia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1147, 660);
            this.Controls.Add(this.VarausHuoneenNumeroCB);
            this.Controls.Add(this.VarausHuoneenTyyppiCB);
            this.Controls.Add(this.dateTimeUlos);
            this.Controls.Add(this.dateTimeSisaan);
            this.Controls.Add(this.VarausNumeroTB);
            this.Controls.Add(this.VarausAsNumeroTB);
            this.Controls.Add(this.VarausTyhjennaBTN);
            this.Controls.Add(this.VarausPoistaBTN);
            this.Controls.Add(this.UusiVarausBTN);
            this.Controls.Add(this.VarausMuokkaaBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataVaraukset);
            this.Controls.Add(this.panel1);
            this.Name = "HallitseVarauksia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallitseVarauksia";
            this.Load += new System.EventHandler(this.HallitseVarauksia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaraukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataVaraukset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button VarausMuokkaaBTN;
        private System.Windows.Forms.Button UusiVarausBTN;
        private System.Windows.Forms.Button VarausPoistaBTN;
        private System.Windows.Forms.Button VarausTyhjennaBTN;
        private System.Windows.Forms.TextBox VarausAsNumeroTB;
        private System.Windows.Forms.TextBox VarausNumeroTB;
        private System.Windows.Forms.DateTimePicker dateTimeSisaan;
        private System.Windows.Forms.DateTimePicker dateTimeUlos;
        private System.Windows.Forms.ComboBox VarausHuoneenTyyppiCB;
        private System.Windows.Forms.ComboBox VarausHuoneenNumeroCB;
    }
}