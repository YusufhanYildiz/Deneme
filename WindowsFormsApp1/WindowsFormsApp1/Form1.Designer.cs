namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sirketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiDairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMalzemeAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otvOraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovizKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovizKuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlMatrahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlKdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlGenelToplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlOtvTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketGridDenemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketGridDenemeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(572, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sirketIdDataGridViewTextBoxColumn,
            this.faturaTuruDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn,
            this.fisTarihiDataGridViewTextBoxColumn,
            this.cariNoDataGridViewTextBoxColumn,
            this.cariAdiDataGridViewTextBoxColumn,
            this.vergiDairesiDataGridViewTextBoxColumn,
            this.vergiNoDataGridViewTextBoxColumn,
            this.stokKoduDataGridViewTextBoxColumn,
            this.stokMalzemeAciklamasiDataGridViewTextBoxColumn,
            this.gtipDataGridViewTextBoxColumn,
            this.otvOraniDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.dovizKoduDataGridViewTextBoxColumn,
            this.dovizKuruDataGridViewTextBoxColumn,
            this.tlMatrahDataGridViewTextBoxColumn,
            this.tlKdvDataGridViewTextBoxColumn,
            this.tlGenelToplamDataGridViewTextBoxColumn,
            this.tlOtvTutarDataGridViewTextBoxColumn,
            this.kdvKoduDataGridViewTextBoxColumn,
            this.hesapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sirketGridDenemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1841, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // sirketIdDataGridViewTextBoxColumn
            // 
            this.sirketIdDataGridViewTextBoxColumn.DataPropertyName = "SirketId";
            this.sirketIdDataGridViewTextBoxColumn.HeaderText = "SirketId";
            this.sirketIdDataGridViewTextBoxColumn.Name = "sirketIdDataGridViewTextBoxColumn";
            // 
            // faturaTuruDataGridViewTextBoxColumn
            // 
            this.faturaTuruDataGridViewTextBoxColumn.DataPropertyName = "FaturaTuru";
            this.faturaTuruDataGridViewTextBoxColumn.HeaderText = "FaturaTuru";
            this.faturaTuruDataGridViewTextBoxColumn.Name = "faturaTuruDataGridViewTextBoxColumn";
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            // 
            // fisTarihiDataGridViewTextBoxColumn
            // 
            this.fisTarihiDataGridViewTextBoxColumn.DataPropertyName = "FisTarihi";
            this.fisTarihiDataGridViewTextBoxColumn.HeaderText = "FisTarihi";
            this.fisTarihiDataGridViewTextBoxColumn.Name = "fisTarihiDataGridViewTextBoxColumn";
            // 
            // cariNoDataGridViewTextBoxColumn
            // 
            this.cariNoDataGridViewTextBoxColumn.DataPropertyName = "CariNo";
            this.cariNoDataGridViewTextBoxColumn.HeaderText = "CariNo";
            this.cariNoDataGridViewTextBoxColumn.Name = "cariNoDataGridViewTextBoxColumn";
            // 
            // cariAdiDataGridViewTextBoxColumn
            // 
            this.cariAdiDataGridViewTextBoxColumn.DataPropertyName = "CariAdi";
            this.cariAdiDataGridViewTextBoxColumn.HeaderText = "CariAdi";
            this.cariAdiDataGridViewTextBoxColumn.Name = "cariAdiDataGridViewTextBoxColumn";
            // 
            // vergiDairesiDataGridViewTextBoxColumn
            // 
            this.vergiDairesiDataGridViewTextBoxColumn.DataPropertyName = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.HeaderText = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.Name = "vergiDairesiDataGridViewTextBoxColumn";
            // 
            // vergiNoDataGridViewTextBoxColumn
            // 
            this.vergiNoDataGridViewTextBoxColumn.DataPropertyName = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.HeaderText = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.Name = "vergiNoDataGridViewTextBoxColumn";
            // 
            // stokKoduDataGridViewTextBoxColumn
            // 
            this.stokKoduDataGridViewTextBoxColumn.DataPropertyName = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.HeaderText = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.Name = "stokKoduDataGridViewTextBoxColumn";
            // 
            // stokMalzemeAciklamasiDataGridViewTextBoxColumn
            // 
            this.stokMalzemeAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "StokMalzemeAciklamasi";
            this.stokMalzemeAciklamasiDataGridViewTextBoxColumn.HeaderText = "StokMalzemeAciklamasi";
            this.stokMalzemeAciklamasiDataGridViewTextBoxColumn.Name = "stokMalzemeAciklamasiDataGridViewTextBoxColumn";
            // 
            // gtipDataGridViewTextBoxColumn
            // 
            this.gtipDataGridViewTextBoxColumn.DataPropertyName = "Gtip";
            this.gtipDataGridViewTextBoxColumn.HeaderText = "Gtip";
            this.gtipDataGridViewTextBoxColumn.Name = "gtipDataGridViewTextBoxColumn";
            // 
            // otvOraniDataGridViewTextBoxColumn
            // 
            this.otvOraniDataGridViewTextBoxColumn.DataPropertyName = "OtvOrani";
            this.otvOraniDataGridViewTextBoxColumn.HeaderText = "OtvOrani";
            this.otvOraniDataGridViewTextBoxColumn.Name = "otvOraniDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // dovizKoduDataGridViewTextBoxColumn
            // 
            this.dovizKoduDataGridViewTextBoxColumn.DataPropertyName = "DovizKodu";
            this.dovizKoduDataGridViewTextBoxColumn.HeaderText = "DovizKodu";
            this.dovizKoduDataGridViewTextBoxColumn.Name = "dovizKoduDataGridViewTextBoxColumn";
            // 
            // dovizKuruDataGridViewTextBoxColumn
            // 
            this.dovizKuruDataGridViewTextBoxColumn.DataPropertyName = "DovizKuru";
            this.dovizKuruDataGridViewTextBoxColumn.HeaderText = "DovizKuru";
            this.dovizKuruDataGridViewTextBoxColumn.Name = "dovizKuruDataGridViewTextBoxColumn";
            // 
            // tlMatrahDataGridViewTextBoxColumn
            // 
            this.tlMatrahDataGridViewTextBoxColumn.DataPropertyName = "TlMatrah";
            this.tlMatrahDataGridViewTextBoxColumn.HeaderText = "TlMatrah";
            this.tlMatrahDataGridViewTextBoxColumn.Name = "tlMatrahDataGridViewTextBoxColumn";
            // 
            // tlKdvDataGridViewTextBoxColumn
            // 
            this.tlKdvDataGridViewTextBoxColumn.DataPropertyName = "TlKdv";
            this.tlKdvDataGridViewTextBoxColumn.HeaderText = "TlKdv";
            this.tlKdvDataGridViewTextBoxColumn.Name = "tlKdvDataGridViewTextBoxColumn";
            // 
            // tlGenelToplamDataGridViewTextBoxColumn
            // 
            this.tlGenelToplamDataGridViewTextBoxColumn.DataPropertyName = "TlGenelToplam";
            this.tlGenelToplamDataGridViewTextBoxColumn.HeaderText = "TlGenelToplam";
            this.tlGenelToplamDataGridViewTextBoxColumn.Name = "tlGenelToplamDataGridViewTextBoxColumn";
            // 
            // tlOtvTutarDataGridViewTextBoxColumn
            // 
            this.tlOtvTutarDataGridViewTextBoxColumn.DataPropertyName = "TlOtvTutar";
            this.tlOtvTutarDataGridViewTextBoxColumn.HeaderText = "TlOtvTutar";
            this.tlOtvTutarDataGridViewTextBoxColumn.Name = "tlOtvTutarDataGridViewTextBoxColumn";
            // 
            // kdvKoduDataGridViewTextBoxColumn
            // 
            this.kdvKoduDataGridViewTextBoxColumn.DataPropertyName = "Kdv_Kodu";
            this.kdvKoduDataGridViewTextBoxColumn.HeaderText = "Kdv_Kodu";
            this.kdvKoduDataGridViewTextBoxColumn.Name = "kdvKoduDataGridViewTextBoxColumn";
            // 
            // hesapDataGridViewTextBoxColumn
            // 
            this.hesapDataGridViewTextBoxColumn.DataPropertyName = "Hesap";
            this.hesapDataGridViewTextBoxColumn.HeaderText = "Hesap";
            this.hesapDataGridViewTextBoxColumn.Name = "hesapDataGridViewTextBoxColumn";
            // 
            // sirketGridDenemeBindingSource
            // 
            this.sirketGridDenemeBindingSource.DataSource = typeof(WindowsFormsApp1.SirketGridDeneme);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya Yolu:";
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(91, 54);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(104, 21);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(91, 28);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(475, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sayfa:";
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(201, 54);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(75, 23);
            this.BtnImport.TabIndex = 6;
            this.BtnImport.Text = "Sql\'e Aktar";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.BtnImport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSheet);
            this.groupBox1.Location = new System.Drawing.Point(21, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(WindowsFormsApp1.Customer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(WindowsFormsApp1.Customer);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(831, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sql Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Excel Sql Aktarma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketGridDenemeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource sirketGridDenemeBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiDairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMalzemeAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otvOraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dovizKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dovizKuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlMatrahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlKdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlGenelToplamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlOtvTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

