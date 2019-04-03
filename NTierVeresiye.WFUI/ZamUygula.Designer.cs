namespace NTierVeresiye.WFUI
{
    partial class ZamUygula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbZUrun = new System.Windows.Forms.ComboBox();
            this.nmrZOran = new System.Windows.Forms.NumericUpDown();
            this.btnZGuncelle = new System.Windows.Forms.Button();
            this.btnZIpta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrZOran)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Fiyatına Zam Uygulanacak Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zam Oranı(%):";
            // 
            // cmbZUrun
            // 
            this.cmbZUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbZUrun.DisplayMember = "Ad";
            this.cmbZUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbZUrun.FormattingEnabled = true;
            this.cmbZUrun.Location = new System.Drawing.Point(153, 52);
            this.cmbZUrun.Name = "cmbZUrun";
            this.cmbZUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbZUrun.TabIndex = 3;
            this.cmbZUrun.ValueMember = "ID";
            // 
            // nmrZOran
            // 
            this.nmrZOran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nmrZOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrZOran.Location = new System.Drawing.Point(154, 80);
            this.nmrZOran.Name = "nmrZOran";
            this.nmrZOran.Size = new System.Drawing.Size(120, 20);
            this.nmrZOran.TabIndex = 4;
            // 
            // btnZGuncelle
            // 
            this.btnZGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZGuncelle.Image = global::NTierVeresiye.WFUI.Properties.Resources.iconfinder_icons_update_1564533;
            this.btnZGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZGuncelle.Location = new System.Drawing.Point(50, 122);
            this.btnZGuncelle.Name = "btnZGuncelle";
            this.btnZGuncelle.Size = new System.Drawing.Size(75, 53);
            this.btnZGuncelle.TabIndex = 5;
            this.btnZGuncelle.Text = "Güncelle";
            this.btnZGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZGuncelle.UseVisualStyleBackColor = true;
            this.btnZGuncelle.Click += new System.EventHandler(this.btnZGuncelle_Click);
            // 
            // btnZIpta
            // 
            this.btnZIpta.Image = global::NTierVeresiye.WFUI.Properties.Resources.iconfinder_f_cross_256_282471;
            this.btnZIpta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZIpta.Location = new System.Drawing.Point(199, 122);
            this.btnZIpta.Name = "btnZIpta";
            this.btnZIpta.Size = new System.Drawing.Size(75, 53);
            this.btnZIpta.TabIndex = 6;
            this.btnZIpta.Text = "İptal";
            this.btnZIpta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZIpta.UseVisualStyleBackColor = true;
            this.btnZIpta.Click += new System.EventHandler(this.btnZIpta_Click);
            // 
            // ZamUygula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(329, 196);
            this.Controls.Add(this.btnZIpta);
            this.Controls.Add(this.btnZGuncelle);
            this.Controls.Add(this.nmrZOran);
            this.Controls.Add(this.cmbZUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "ZamUygula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZamUygula";
            this.Load += new System.EventHandler(this.ZamUygula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrZOran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbZUrun;
        private System.Windows.Forms.NumericUpDown nmrZOran;
        private System.Windows.Forms.Button btnZGuncelle;
        private System.Windows.Forms.Button btnZIpta;
    }
}