namespace RESTORANTTAKİP
{
    partial class Masa1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelhesap = new System.Windows.Forms.Label();
            this.Siparişler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnicecekler = new System.Windows.Forms.Button();
            this.btnyemekler = new System.Windows.Forms.Button();
            this.BtnNakit = new System.Windows.Forms.Button();
            this.btnhesapal = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.labelhesap);
            this.panel1.Controls.Add(this.Siparişler);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(616, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 542);
            this.panel1.TabIndex = 1;
            // 
            // labelhesap
            // 
            this.labelhesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelhesap.Location = new System.Drawing.Point(-3, 469);
            this.labelhesap.Name = "labelhesap";
            this.labelhesap.Size = new System.Drawing.Size(309, 73);
            this.labelhesap.TabIndex = 7;
            this.labelhesap.Click += new System.EventHandler(this.labelhesap_Click);
            // 
            // Siparişler
            // 
            this.Siparişler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Siparişler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siparişler.Location = new System.Drawing.Point(6, 27);
            this.Siparişler.Name = "Siparişler";
            this.Siparişler.Size = new System.Drawing.Size(306, 48);
            this.Siparişler.TabIndex = 6;
            this.Siparişler.Text = "Siparişler";
            this.Siparişler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Siparişler.Click += new System.EventHandler(this.Siparişler_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 357);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.btncikis);
            this.panel2.Controls.Add(this.btnsil);
            this.panel2.Controls.Add(this.btnicecekler);
            this.panel2.Controls.Add(this.btnyemekler);
            this.panel2.Controls.Add(this.BtnNakit);
            this.panel2.Controls.Add(this.btnhesapal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 88);
            this.panel2.TabIndex = 2;
            // 
            // btncikis
            // 
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Location = new System.Drawing.Point(408, 17);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 50);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnsil
            // 
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Location = new System.Drawing.Point(327, 17);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 50);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Siparişleri Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnicecekler
            // 
            this.btnicecekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnicecekler.Location = new System.Drawing.Point(84, 17);
            this.btnicecekler.Name = "btnicecekler";
            this.btnicecekler.Size = new System.Drawing.Size(75, 50);
            this.btnicecekler.TabIndex = 1;
            this.btnicecekler.Text = "İçecekler";
            this.btnicecekler.UseVisualStyleBackColor = true;
            this.btnicecekler.Click += new System.EventHandler(this.btnicecekler_Click);
            // 
            // btnyemekler
            // 
            this.btnyemekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyemekler.Location = new System.Drawing.Point(3, 17);
            this.btnyemekler.Name = "btnyemekler";
            this.btnyemekler.Size = new System.Drawing.Size(75, 50);
            this.btnyemekler.TabIndex = 0;
            this.btnyemekler.Text = "Yemekler";
            this.btnyemekler.UseVisualStyleBackColor = true;
            this.btnyemekler.Click += new System.EventHandler(this.btnyemekler_Click);
            // 
            // BtnNakit
            // 
            this.BtnNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNakit.Location = new System.Drawing.Point(165, 17);
            this.BtnNakit.Name = "BtnNakit";
            this.BtnNakit.Size = new System.Drawing.Size(75, 50);
            this.BtnNakit.TabIndex = 5;
            this.BtnNakit.Text = "Tutar Hesapla";
            this.BtnNakit.UseVisualStyleBackColor = true;
            this.BtnNakit.Click += new System.EventHandler(this.BtnNakit_Click);
            // 
            // btnhesapal
            // 
            this.btnhesapal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhesapal.Location = new System.Drawing.Point(246, 17);
            this.btnhesapal.Name = "btnhesapal";
            this.btnhesapal.Size = new System.Drawing.Size(75, 50);
            this.btnhesapal.TabIndex = 2;
            this.btnhesapal.Text = "Hesap Kapat";
            this.btnhesapal.UseVisualStyleBackColor = true;
            this.btnhesapal.Click += new System.EventHandler(this.btnhesapal_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Masa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Masa1";
            this.Load += new System.EventHandler(this.Masa1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnNakit;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnicecekler;
        private System.Windows.Forms.Button btnyemekler;
        private System.Windows.Forms.Label Siparişler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelhesap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnhesapal;
    }
}