﻿namespace HotelliProjekti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HuoneenNumeroTB = new System.Windows.Forms.TextBox();
            this.HuonePuhelinTB = new System.Windows.Forms.TextBox();
            this.HuoneenTyyppiCB = new System.Windows.Forms.ComboBox();
            this.VapaaLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, 26);
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
            this.HuoneMuokkaaBTN.Location = new System.Drawing.Point(30, 534);
            this.HuoneMuokkaaBTN.Name = "HuoneMuokkaaBTN";
            this.HuoneMuokkaaBTN.Size = new System.Drawing.Size(161, 49);
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
            this.UusiHuoneBTN.Location = new System.Drawing.Point(197, 534);
            this.UusiHuoneBTN.Name = "UusiHuoneBTN";
            this.UusiHuoneBTN.Size = new System.Drawing.Size(222, 49);
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
            this.HuonePoistaBTN.Location = new System.Drawing.Point(425, 534);
            this.HuonePoistaBTN.Name = "HuonePoistaBTN";
            this.HuonePoistaBTN.Size = new System.Drawing.Size(147, 49);
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
            this.HuoneTyhjennaBTN.Location = new System.Drawing.Point(30, 606);
            this.HuoneTyhjennaBTN.Name = "HuoneTyhjennaBTN";
            this.HuoneTyhjennaBTN.Size = new System.Drawing.Size(542, 55);
            this.HuoneTyhjennaBTN.TabIndex = 21;
            this.HuoneTyhjennaBTN.Text = "Tyhjennä kentät";
            this.HuoneTyhjennaBTN.UseVisualStyleBackColor = false;
            this.HuoneTyhjennaBTN.Click += new System.EventHandler(this.HuoneTyhjennaBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(607, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(542, 523);
            this.dataGridView1.TabIndex = 22;
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
            this.HuoneenNumeroTB.Size = new System.Drawing.Size(246, 35);
            this.HuoneenNumeroTB.TabIndex = 29;
            // 
            // HuonePuhelinTB
            // 
            this.HuonePuhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonePuhelinTB.Location = new System.Drawing.Point(222, 282);
            this.HuonePuhelinTB.Name = "HuonePuhelinTB";
            this.HuonePuhelinTB.Size = new System.Drawing.Size(246, 35);
            this.HuonePuhelinTB.TabIndex = 31;
            // 
            // HuoneenTyyppiCB
            // 
            this.HuoneenTyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoneenTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneenTyyppiCB.FormattingEnabled = true;
            this.HuoneenTyyppiCB.Location = new System.Drawing.Point(222, 217);
            this.HuoneenTyyppiCB.Name = "HuoneenTyyppiCB";
            this.HuoneenTyyppiCB.Size = new System.Drawing.Size(246, 37);
            this.HuoneenTyyppiCB.TabIndex = 32;
            // 
            // VapaaLB
            // 
            this.VapaaLB.AutoSize = true;
            this.VapaaLB.BackColor = System.Drawing.Color.White;
            this.VapaaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VapaaLB.ForeColor = System.Drawing.Color.Green;
            this.VapaaLB.Location = new System.Drawing.Point(226, 348);
            this.VapaaLB.Name = "VapaaLB";
            this.VapaaLB.Size = new System.Drawing.Size(87, 26);
            this.VapaaLB.TabIndex = 33;
            this.VapaaLB.Text = "KYLLÄ";
            // 
            // HallitseHuoneita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1178, 706);
            this.Controls.Add(this.VapaaLB);
            this.Controls.Add(this.HuoneenTyyppiCB);
            this.Controls.Add(this.HuonePuhelinTB);
            this.Controls.Add(this.HuoneenNumeroTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HuoneTyhjennaBTN);
            this.Controls.Add(this.HuonePoistaBTN);
            this.Controls.Add(this.UusiHuoneBTN);
            this.Controls.Add(this.HuoneMuokkaaBTN);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "HallitseHuoneita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hallitse huoneita";
            this.Load += new System.EventHandler(this.HallitseHuoneita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HuoneenNumeroTB;
        private System.Windows.Forms.TextBox HuonePuhelinTB;
        private System.Windows.Forms.ComboBox HuoneenTyyppiCB;
        private System.Windows.Forms.Label VapaaLB;
    }
}