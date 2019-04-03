namespace NTierVeresiye.WFUI
{
    partial class Tedarikciler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTYAdAra = new System.Windows.Forms.TextBox();
            this.txtTSektorAra = new System.Windows.Forms.TextBox();
            this.txtTAdAra = new System.Windows.Forms.TextBox();
            this.lblSecYAd = new System.Windows.Forms.Label();
            this.lblSecSektor = new System.Windows.Forms.Label();
            this.lblSecTedarikci = new System.Windows.Forms.Label();
            this.txtTYSoyadAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtTYAdAra
            // 
            this.txtTYAdAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTYAdAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTYAdAra.Location = new System.Drawing.Point(279, 44);
            this.txtTYAdAra.Name = "txtTYAdAra";
            this.txtTYAdAra.Size = new System.Drawing.Size(115, 20);
            this.txtTYAdAra.TabIndex = 12;
            this.txtTYAdAra.TextChanged += new System.EventHandler(this.Tedarikciler_TextChanged);
            // 
            // txtTSektorAra
            // 
            this.txtTSektorAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTSektorAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTSektorAra.Location = new System.Drawing.Point(147, 44);
            this.txtTSektorAra.Name = "txtTSektorAra";
            this.txtTSektorAra.Size = new System.Drawing.Size(115, 20);
            this.txtTSektorAra.TabIndex = 11;
            this.txtTSektorAra.TextChanged += new System.EventHandler(this.Tedarikciler_TextChanged);
            // 
            // txtTAdAra
            // 
            this.txtTAdAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTAdAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTAdAra.Location = new System.Drawing.Point(11, 44);
            this.txtTAdAra.Name = "txtTAdAra";
            this.txtTAdAra.Size = new System.Drawing.Size(115, 20);
            this.txtTAdAra.TabIndex = 10;
            this.txtTAdAra.TextChanged += new System.EventHandler(this.Tedarikciler_TextChanged);
            // 
            // lblSecYAd
            // 
            this.lblSecYAd.AutoSize = true;
            this.lblSecYAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSecYAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecYAd.Location = new System.Drawing.Point(285, 9);
            this.lblSecYAd.Name = "lblSecYAd";
            this.lblSecYAd.Size = new System.Drawing.Size(109, 13);
            this.lblSecYAd.TabIndex = 9;
            this.lblSecYAd.Text = "Yetkili Adına Göre";
            // 
            // lblSecSektor
            // 
            this.lblSecSektor.AutoSize = true;
            this.lblSecSektor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSecSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecSektor.Location = new System.Drawing.Point(162, 9);
            this.lblSecSektor.Name = "lblSecSektor";
            this.lblSecSektor.Size = new System.Drawing.Size(82, 13);
            this.lblSecSektor.TabIndex = 8;
            this.lblSecSektor.Text = "Sektöre Göre";
            // 
            // lblSecTedarikci
            // 
            this.lblSecTedarikci.AutoSize = true;
            this.lblSecTedarikci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSecTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecTedarikci.Location = new System.Drawing.Point(33, 9);
            this.lblSecTedarikci.Name = "lblSecTedarikci";
            this.lblSecTedarikci.Size = new System.Drawing.Size(70, 13);
            this.lblSecTedarikci.TabIndex = 7;
            this.lblSecTedarikci.Text = "Adına Göre";
            // 
            // txtTYSoyadAra
            // 
            this.txtTYSoyadAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTYSoyadAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTYSoyadAra.Location = new System.Drawing.Point(410, 44);
            this.txtTYSoyadAra.Name = "txtTYSoyadAra";
            this.txtTYSoyadAra.Size = new System.Drawing.Size(115, 20);
            this.txtTYSoyadAra.TabIndex = 14;
            this.txtTYSoyadAra.TextChanged += new System.EventHandler(this.Tedarikciler_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yetkili Soyadına Göre";
            // 
            // Tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 441);
            this.Controls.Add(this.txtTYSoyadAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTYAdAra);
            this.Controls.Add(this.txtTSektorAra);
            this.Controls.Add(this.txtTAdAra);
            this.Controls.Add(this.lblSecYAd);
            this.Controls.Add(this.lblSecSektor);
            this.Controls.Add(this.lblSecTedarikci);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "Tedarikciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikciler";
            this.Load += new System.EventHandler(this.Tedarikciler_Load);
            this.TextChanged += new System.EventHandler(this.Tedarikciler_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSecYAd;
        private System.Windows.Forms.Label lblSecSektor;
        private System.Windows.Forms.Label lblSecTedarikci;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTYAdAra;
        public System.Windows.Forms.TextBox txtTSektorAra;
        public System.Windows.Forms.TextBox txtTAdAra;
        public System.Windows.Forms.TextBox txtTYSoyadAra;
    }
}