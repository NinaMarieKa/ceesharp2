namespace HotelliProjekti
{
    partial class HallitseHuoneita
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
            this.HuoneMuokkaaBTN = new System.Windows.Forms.Button();
            this.UusiHuoneBTN = new System.Windows.Forms.Button();
            this.HuonePoistaBTN = new System.Windows.Forms.Button();
            this.HuoneTyhjennaBTN = new System.Windows.Forms.Button();
            this.dGVHuoneet = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HuoneenNumeroTB = new System.Windows.Forms.TextBox();
            this.HuonePuhelinTB = new System.Windows.Forms.TextBox();
            this.HuoneenTyyppiCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonEi = new System.Windows.Forms.RadioButton();
            this.radioButtonKylla = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHuoneet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hallitse huoneita";
            // 
            // HuoneMuokkaaBTN
            // 
            this.HuoneMuokkaaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.HuoneMuokkaaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneMuokkaaBTN.ForeColor = System.Drawing.Color.White;
            this.HuoneMuokkaaBTN.Location = new System.Drawing.Point(234, 486);
            this.HuoneMuokkaaBTN.Name = "HuoneMuokkaaBTN";
            this.HuoneMuokkaaBTN.Size = new System.Drawing.Size(145, 49);
            this.HuoneMuokkaaBTN.TabIndex = 18;
            this.HuoneMuokkaaBTN.Text = "Muokkaa";
            this.HuoneMuokkaaBTN.UseVisualStyleBackColor = false;
            this.HuoneMuokkaaBTN.Click += new System.EventHandler(this.HuoneMuokkaaBTN_Click);
            // 
            // UusiHuoneBTN
            // 
            this.UusiHuoneBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.UusiHuoneBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiHuoneBTN.ForeColor = System.Drawing.Color.White;
            this.UusiHuoneBTN.Location = new System.Drawing.Point(27, 486);
            this.UusiHuoneBTN.Name = "UusiHuoneBTN";
            this.UusiHuoneBTN.Size = new System.Drawing.Size(204, 49);
            this.UusiHuoneBTN.TabIndex = 19;
            this.UusiHuoneBTN.Text = "Lisää uusi huone";
            this.UusiHuoneBTN.UseVisualStyleBackColor = false;
            this.UusiHuoneBTN.Click += new System.EventHandler(this.UusiHuoneBTN_Click);
            // 
            // HuonePoistaBTN
            // 
            this.HuonePoistaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.HuonePoistaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonePoistaBTN.ForeColor = System.Drawing.Color.White;
            this.HuonePoistaBTN.Location = new System.Drawing.Point(388, 486);
            this.HuonePoistaBTN.Name = "HuonePoistaBTN";
            this.HuonePoistaBTN.Size = new System.Drawing.Size(132, 49);
            this.HuonePoistaBTN.TabIndex = 20;
            this.HuonePoistaBTN.Text = "Poista";
            this.HuonePoistaBTN.UseVisualStyleBackColor = false;
            this.HuonePoistaBTN.Click += new System.EventHandler(this.HuonePoistaBTN_Click);
            // 
            // HuoneTyhjennaBTN
            // 
            this.HuoneTyhjennaBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.HuoneTyhjennaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneTyhjennaBTN.ForeColor = System.Drawing.Color.White;
            this.HuoneTyhjennaBTN.Location = new System.Drawing.Point(27, 541);
            this.HuoneTyhjennaBTN.Name = "HuoneTyhjennaBTN";
            this.HuoneTyhjennaBTN.Size = new System.Drawing.Size(493, 55);
            this.HuoneTyhjennaBTN.TabIndex = 21;
            this.HuoneTyhjennaBTN.Text = "Tyhjennä kentät";
            this.HuoneTyhjennaBTN.UseVisualStyleBackColor = false;
            this.HuoneTyhjennaBTN.Click += new System.EventHandler(this.HuoneTyhjennaBTN_Click);
            // 
            // dGVHuoneet
            // 
            this.dGVHuoneet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVHuoneet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHuoneet.Location = new System.Drawing.Point(545, 89);
            this.dGVHuoneet.Name = "dGVHuoneet";
            this.dGVHuoneet.RowHeadersWidth = 62;
            this.dGVHuoneet.RowTemplate.Height = 28;
            this.dGVHuoneet.Size = new System.Drawing.Size(586, 523);
            this.dGVHuoneet.TabIndex = 22;
            this.dGVHuoneet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHuoneet_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Huoneen numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Huoneen tyyppi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Puhelin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Vapaa";
            // 
            // HuoneenNumeroTB
            // 
            this.HuoneenNumeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneenNumeroTB.Location = new System.Drawing.Point(222, 144);
            this.HuoneenNumeroTB.Name = "HuoneenNumeroTB";
            this.HuoneenNumeroTB.Size = new System.Drawing.Size(298, 35);
            this.HuoneenNumeroTB.TabIndex = 29;
            // 
            // HuonePuhelinTB
            // 
            this.HuonePuhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonePuhelinTB.Location = new System.Drawing.Point(222, 282);
            this.HuonePuhelinTB.Name = "HuonePuhelinTB";
            this.HuonePuhelinTB.Size = new System.Drawing.Size(298, 35);
            this.HuonePuhelinTB.TabIndex = 31;
            // 
            // HuoneenTyyppiCB
            // 
            this.HuoneenTyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoneenTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneenTyyppiCB.FormattingEnabled = true;
            this.HuoneenTyyppiCB.Location = new System.Drawing.Point(222, 217);
            this.HuoneenTyyppiCB.Name = "HuoneenTyyppiCB";
            this.HuoneenTyyppiCB.Size = new System.Drawing.Size(298, 37);
            this.HuoneenTyyppiCB.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.radioButtonEi);
            this.panel2.Controls.Add(this.radioButtonKylla);
            this.panel2.Location = new System.Drawing.Point(222, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 60);
            this.panel2.TabIndex = 34;
            // 
            // radioButtonEi
            // 
            this.radioButtonEi.AutoSize = true;
            this.radioButtonEi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEi.ForeColor = System.Drawing.Color.Red;
            this.radioButtonEi.Location = new System.Drawing.Point(149, 14);
            this.radioButtonEi.Name = "radioButtonEi";
            this.radioButtonEi.Size = new System.Drawing.Size(62, 33);
            this.radioButtonEi.TabIndex = 1;
            this.radioButtonEi.TabStop = true;
            this.radioButtonEi.Text = "EI";
            this.radioButtonEi.UseVisualStyleBackColor = true;
            // 
            // radioButtonKylla
            // 
            this.radioButtonKylla.AutoSize = true;
            this.radioButtonKylla.Checked = true;
            this.radioButtonKylla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKylla.ForeColor = System.Drawing.Color.Green;
            this.radioButtonKylla.Location = new System.Drawing.Point(12, 14);
            this.radioButtonKylla.Name = "radioButtonKylla";
            this.radioButtonKylla.Size = new System.Drawing.Size(116, 33);
            this.radioButtonKylla.TabIndex = 0;
            this.radioButtonKylla.TabStop = true;
            this.radioButtonKylla.Text = "KYLLÄ";
            this.radioButtonKylla.UseVisualStyleBackColor = true;
            // 
            // HallitseHuoneita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1142, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HuoneenTyyppiCB);
            this.Controls.Add(this.HuonePuhelinTB);
            this.Controls.Add(this.HuoneenNumeroTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVHuoneet);
            this.Controls.Add(this.HuoneTyhjennaBTN);
            this.Controls.Add(this.HuonePoistaBTN);
            this.Controls.Add(this.UusiHuoneBTN);
            this.Controls.Add(this.HuoneMuokkaaBTN);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HallitseHuoneita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hallitse huoneita";
            this.Load += new System.EventHandler(this.HallitseHuoneita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHuoneet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HuoneMuokkaaBTN;
        private System.Windows.Forms.Button UusiHuoneBTN;
        private System.Windows.Forms.Button HuonePoistaBTN;
        private System.Windows.Forms.Button HuoneTyhjennaBTN;
        private System.Windows.Forms.DataGridView dGVHuoneet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HuoneenNumeroTB;
        private System.Windows.Forms.TextBox HuonePuhelinTB;
        private System.Windows.Forms.ComboBox HuoneenTyyppiCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonEi;
        private System.Windows.Forms.RadioButton radioButtonKylla;
    }
}