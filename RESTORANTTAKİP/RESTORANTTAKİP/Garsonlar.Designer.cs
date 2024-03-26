namespace RESTORANTTAKİP
{
    partial class Garsonlar
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
            this.restorantTakipDataSet = new RESTORANTTAKİP.RestorantTakipDataSet();
            this.restorantTakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.garsonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garsonAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garsonSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garsonTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garsonMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garsonCalismaSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLGARSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_GARSONTableAdapter = new RESTORANTTAKİP.RestorantTakipDataSetTableAdapters.TBL_GARSONTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgarsonid = new System.Windows.Forms.TextBox();
            this.txtgarsonadi = new System.Windows.Forms.TextBox();
            this.txtgarsoncs = new System.Windows.Forms.TextBox();
            this.txtgarsonmaasi = new System.Windows.Forms.TextBox();
            this.garsonsoyadi = new System.Windows.Forms.TextBox();
            this.txtgarsontelefonu = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restorantTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorantTakipDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGARSONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restorantTakipDataSet
            // 
            this.restorantTakipDataSet.DataSetName = "RestorantTakipDataSet";
            this.restorantTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restorantTakipDataSetBindingSource
            // 
            this.restorantTakipDataSetBindingSource.DataSource = this.restorantTakipDataSet;
            this.restorantTakipDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.garsonIdDataGridViewTextBoxColumn,
            this.garsonAdıDataGridViewTextBoxColumn,
            this.garsonSoyadıDataGridViewTextBoxColumn,
            this.garsonTelefonDataGridViewTextBoxColumn,
            this.garsonMaasDataGridViewTextBoxColumn,
            this.garsonCalismaSaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLGARSONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // garsonIdDataGridViewTextBoxColumn
            // 
            this.garsonIdDataGridViewTextBoxColumn.DataPropertyName = "GarsonId";
            this.garsonIdDataGridViewTextBoxColumn.HeaderText = "GarsonId";
            this.garsonIdDataGridViewTextBoxColumn.Name = "garsonIdDataGridViewTextBoxColumn";
            this.garsonIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garsonAdıDataGridViewTextBoxColumn
            // 
            this.garsonAdıDataGridViewTextBoxColumn.DataPropertyName = "GarsonAdı";
            this.garsonAdıDataGridViewTextBoxColumn.HeaderText = "GarsonAdı";
            this.garsonAdıDataGridViewTextBoxColumn.Name = "garsonAdıDataGridViewTextBoxColumn";
            this.garsonAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garsonSoyadıDataGridViewTextBoxColumn
            // 
            this.garsonSoyadıDataGridViewTextBoxColumn.DataPropertyName = "GarsonSoyadı";
            this.garsonSoyadıDataGridViewTextBoxColumn.HeaderText = "GarsonSoyadı";
            this.garsonSoyadıDataGridViewTextBoxColumn.Name = "garsonSoyadıDataGridViewTextBoxColumn";
            this.garsonSoyadıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garsonTelefonDataGridViewTextBoxColumn
            // 
            this.garsonTelefonDataGridViewTextBoxColumn.DataPropertyName = "GarsonTelefon";
            this.garsonTelefonDataGridViewTextBoxColumn.HeaderText = "GarsonTelefon";
            this.garsonTelefonDataGridViewTextBoxColumn.Name = "garsonTelefonDataGridViewTextBoxColumn";
            this.garsonTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garsonMaasDataGridViewTextBoxColumn
            // 
            this.garsonMaasDataGridViewTextBoxColumn.DataPropertyName = "GarsonMaas";
            this.garsonMaasDataGridViewTextBoxColumn.HeaderText = "GarsonMaas";
            this.garsonMaasDataGridViewTextBoxColumn.Name = "garsonMaasDataGridViewTextBoxColumn";
            this.garsonMaasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garsonCalismaSaatiDataGridViewTextBoxColumn
            // 
            this.garsonCalismaSaatiDataGridViewTextBoxColumn.DataPropertyName = "GarsonCalismaSaati";
            this.garsonCalismaSaatiDataGridViewTextBoxColumn.HeaderText = "GarsonCalismaSaati";
            this.garsonCalismaSaatiDataGridViewTextBoxColumn.Name = "garsonCalismaSaatiDataGridViewTextBoxColumn";
            this.garsonCalismaSaatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBLGARSONBindingSource
            // 
            this.tBLGARSONBindingSource.DataMember = "TBL_GARSON";
            this.tBLGARSONBindingSource.DataSource = this.restorantTakipDataSetBindingSource;
            // 
            // tBL_GARSONTableAdapter
            // 
            this.tBL_GARSONTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GARSON ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GARSON ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "GARSON SOYADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "GARSON TELEFONU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "GARSON MAAŞ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "GARSON ÇS.";
            // 
            // txtgarsonid
            // 
            this.txtgarsonid.Location = new System.Drawing.Point(192, 24);
            this.txtgarsonid.Name = "txtgarsonid";
            this.txtgarsonid.Size = new System.Drawing.Size(119, 20);
            this.txtgarsonid.TabIndex = 7;
            // 
            // txtgarsonadi
            // 
            this.txtgarsonadi.Location = new System.Drawing.Point(192, 50);
            this.txtgarsonadi.Name = "txtgarsonadi";
            this.txtgarsonadi.Size = new System.Drawing.Size(119, 20);
            this.txtgarsonadi.TabIndex = 8;
            // 
            // txtgarsoncs
            // 
            this.txtgarsoncs.Location = new System.Drawing.Point(192, 154);
            this.txtgarsoncs.Name = "txtgarsoncs";
            this.txtgarsoncs.Size = new System.Drawing.Size(119, 20);
            this.txtgarsoncs.TabIndex = 9;
            // 
            // txtgarsonmaasi
            // 
            this.txtgarsonmaasi.Location = new System.Drawing.Point(192, 128);
            this.txtgarsonmaasi.Name = "txtgarsonmaasi";
            this.txtgarsonmaasi.Size = new System.Drawing.Size(119, 20);
            this.txtgarsonmaasi.TabIndex = 10;
            // 
            // garsonsoyadi
            // 
            this.garsonsoyadi.Location = new System.Drawing.Point(192, 76);
            this.garsonsoyadi.Name = "garsonsoyadi";
            this.garsonsoyadi.Size = new System.Drawing.Size(119, 20);
            this.garsonsoyadi.TabIndex = 11;
            // 
            // txtgarsontelefonu
            // 
            this.txtgarsontelefonu.Location = new System.Drawing.Point(192, 102);
            this.txtgarsontelefonu.Name = "txtgarsontelefonu";
            this.txtgarsontelefonu.Size = new System.Drawing.Size(119, 20);
            this.txtgarsontelefonu.TabIndex = 12;
            // 
            // btnlistele
            // 
            this.btnlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistele.Location = new System.Drawing.Point(389, 44);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(87, 52);
            this.btnlistele.TabIndex = 16;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Location = new System.Drawing.Point(482, 102);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(87, 52);
            this.btnguncelle.TabIndex = 17;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Location = new System.Drawing.Point(389, 102);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 52);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Location = new System.Drawing.Point(482, 44);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(87, 52);
            this.btnkaydet.TabIndex = 19;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // Garsonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(643, 368);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtgarsontelefonu);
            this.Controls.Add(this.garsonsoyadi);
            this.Controls.Add(this.txtgarsonmaasi);
            this.Controls.Add(this.txtgarsoncs);
            this.Controls.Add(this.txtgarsonadi);
            this.Controls.Add(this.txtgarsonid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Garsonlar";
            this.Text = "Garsonlar";
            this.Load += new System.EventHandler(this.Garsonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restorantTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorantTakipDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGARSONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource restorantTakipDataSetBindingSource;
        private RestorantTakipDataSet restorantTakipDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBLGARSONBindingSource;
        private RestorantTakipDataSetTableAdapters.TBL_GARSONTableAdapter tBL_GARSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn garsonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garsonAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garsonSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garsonTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garsonMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garsonCalismaSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgarsonid;
        private System.Windows.Forms.TextBox txtgarsonadi;
        private System.Windows.Forms.TextBox txtgarsoncs;
        private System.Windows.Forms.TextBox txtgarsonmaasi;
        private System.Windows.Forms.TextBox garsonsoyadi;
        private System.Windows.Forms.TextBox txtgarsontelefonu;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
    }
}