namespace RESTORANTTAKİP
{
    partial class Login
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
            this.txtloginid = new System.Windows.Forms.TextBox();
            this.txtloginkadi = new System.Windows.Forms.TextBox();
            this.txtloginsifre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnyenigun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Seviyesi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Sifresi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtloginid
            // 
            this.txtloginid.Location = new System.Drawing.Point(146, 62);
            this.txtloginid.Name = "txtloginid";
            this.txtloginid.Size = new System.Drawing.Size(143, 20);
            this.txtloginid.TabIndex = 3;
            this.txtloginid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtloginkadi
            // 
            this.txtloginkadi.Location = new System.Drawing.Point(146, 98);
            this.txtloginkadi.Name = "txtloginkadi";
            this.txtloginkadi.Size = new System.Drawing.Size(143, 20);
            this.txtloginkadi.TabIndex = 4;
            // 
            // txtloginsifre
            // 
            this.txtloginsifre.Location = new System.Drawing.Point(146, 131);
            this.txtloginsifre.Name = "txtloginsifre";
            this.txtloginsifre.Size = new System.Drawing.Size(143, 20);
            this.txtloginsifre.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(63, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Giriş Yap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnyenigun
            // 
            this.btnyenigun.BackColor = System.Drawing.Color.Tomato;
            this.btnyenigun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenigun.Location = new System.Drawing.Point(63, 222);
            this.btnyenigun.Name = "btnyenigun";
            this.btnyenigun.Size = new System.Drawing.Size(226, 47);
            this.btnyenigun.TabIndex = 8;
            this.btnyenigun.Text = "Yeni Gün Aç";
            this.btnyenigun.UseVisualStyleBackColor = false;
            this.btnyenigun.Click += new System.EventHandler(this.btnyenigun_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(345, 281);
            this.Controls.Add(this.btnyenigun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtloginsifre);
            this.Controls.Add(this.txtloginkadi);
            this.Controls.Add(this.txtloginid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtloginid;
        private System.Windows.Forms.TextBox txtloginkadi;
        private System.Windows.Forms.TextBox txtloginsifre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnyenigun;
    }
}