
namespace giris_form
{
    partial class ilac_ekle_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ilac_ekle_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.richEtken = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.dgwIlac = new System.Windows.Forms.DataGridView();
            this.txtGuncelleTarih = new System.Windows.Forms.TextBox();
            this.richGuncelleEtken = new System.Windows.Forms.RichTextBox();
            this.txtGuncelleTur = new System.Windows.Forms.TextBox();
            this.txtGuncelleAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIlac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLAÇ ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(148, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "İLAÇ TÜRÜ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "İÇERDİĞİ ETKENLER :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(295, 293);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(295, 354);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(170, 20);
            this.txtTur.TabIndex = 5;
            // 
            // richEtken
            // 
            this.richEtken.Location = new System.Drawing.Point(295, 466);
            this.richEtken.Name = "richEtken";
            this.richEtken.Size = new System.Drawing.Size(170, 96);
            this.richEtken.TabIndex = 7;
            this.richEtken.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(304, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "İLACI EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(295, 417);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(170, 20);
            this.txtTarih.TabIndex = 9;
            // 
            // dgwIlac
            // 
            this.dgwIlac.BackgroundColor = System.Drawing.Color.Snow;
            this.dgwIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIlac.Location = new System.Drawing.Point(343, 12);
            this.dgwIlac.Name = "dgwIlac";
            this.dgwIlac.Size = new System.Drawing.Size(609, 150);
            this.dgwIlac.TabIndex = 10;
            this.dgwIlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIlac_CellClick);
            // 
            // txtGuncelleTarih
            // 
            this.txtGuncelleTarih.Location = new System.Drawing.Point(1097, 422);
            this.txtGuncelleTarih.Name = "txtGuncelleTarih";
            this.txtGuncelleTarih.Size = new System.Drawing.Size(170, 20);
            this.txtGuncelleTarih.TabIndex = 17;
            // 
            // richGuncelleEtken
            // 
            this.richGuncelleEtken.Location = new System.Drawing.Point(1097, 471);
            this.richGuncelleEtken.Name = "richGuncelleEtken";
            this.richGuncelleEtken.Size = new System.Drawing.Size(170, 96);
            this.richGuncelleEtken.TabIndex = 16;
            this.richGuncelleEtken.Text = "";
            // 
            // txtGuncelleTur
            // 
            this.txtGuncelleTur.Location = new System.Drawing.Point(1097, 359);
            this.txtGuncelleTur.Name = "txtGuncelleTur";
            this.txtGuncelleTur.Size = new System.Drawing.Size(170, 20);
            this.txtGuncelleTur.TabIndex = 15;
            // 
            // txtGuncelleAd
            // 
            this.txtGuncelleAd.Location = new System.Drawing.Point(1097, 298);
            this.txtGuncelleAd.Name = "txtGuncelleAd";
            this.txtGuncelleAd.Size = new System.Drawing.Size(170, 20);
            this.txtGuncelleAd.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(846, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "İÇERDİĞİ ETKENLER :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(950, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "İLAÇ TÜRÜ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(967, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "İLAÇ ADI :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1097, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "İLACI GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(995, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 62);
            this.button3.TabIndex = 19;
            this.button3.Text = "İLACI SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "SON KULLANMA TARİHİ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(809, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "SON KULLANMA TARİHİ :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 190);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ilac_ekle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1579, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGuncelleTarih);
            this.Controls.Add(this.richGuncelleEtken);
            this.Controls.Add(this.txtGuncelleTur);
            this.Controls.Add(this.txtGuncelleAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwIlac);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richEtken);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "ilac_ekle_form";
            this.Text = "ilac_ekle_form";
            ((System.ComponentModel.ISupportInitialize)(this.dgwIlac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.RichTextBox richEtken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.DataGridView dgwIlac;
        private System.Windows.Forms.TextBox txtGuncelleTarih;
        private System.Windows.Forms.RichTextBox richGuncelleEtken;
        private System.Windows.Forms.TextBox txtGuncelleTur;
        private System.Windows.Forms.TextBox txtGuncelleAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}