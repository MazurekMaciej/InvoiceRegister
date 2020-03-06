namespace InvoiceRegister
{
    partial class ListInvoicesPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoicesListData = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawystawieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasprzedazyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sposobplatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wplaconoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprzedawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozycjefakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesListData
            // 
            this.invoicesListData.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.invoicesListData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invoicesListData.AutoGenerateColumns = false;
            this.invoicesListData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicesListData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoicesListData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.invoicesListData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoicesListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invoicesListData.ColumnHeadersHeight = 40;
            this.invoicesListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numerDataGridViewTextBoxColumn,
            this.datawystawieniaDataGridViewTextBoxColumn,
            this.datasprzedazyDataGridViewTextBoxColumn,
            this.sposobplatnosciDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.wplaconoDataGridViewTextBoxColumn,
            this.uwagiDataGridViewTextBoxColumn,
            this.uzytkownikDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.sprzedawcaDataGridViewTextBoxColumn,
            this.pozycjefakturyDataGridViewTextBoxColumn});
            this.invoicesListData.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.invoicesListData.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.invoicesListData.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.invoicesListData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.invoicesListData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.invoicesListData.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.invoicesListData.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.invoicesListData.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.invoicesListData.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.invoicesListData.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.invoicesListData.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.invoicesListData.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.invoicesListData.CurrentTheme.Name = null;
            this.invoicesListData.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.invoicesListData.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.invoicesListData.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.invoicesListData.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.invoicesListData.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.invoicesListData.DataSource = this.fakturaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoicesListData.DefaultCellStyle = dataGridViewCellStyle3;
            this.invoicesListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicesListData.EnableHeadersVisualStyles = false;
            this.invoicesListData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.invoicesListData.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.invoicesListData.HeaderBgColor = System.Drawing.Color.Empty;
            this.invoicesListData.HeaderForeColor = System.Drawing.Color.White;
            this.invoicesListData.Location = new System.Drawing.Point(0, 0);
            this.invoicesListData.Name = "invoicesListData";
            this.invoicesListData.RowHeadersVisible = false;
            this.invoicesListData.RowTemplate.Height = 40;
            this.invoicesListData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicesListData.Size = new System.Drawing.Size(825, 512);
            this.invoicesListData.TabIndex = 0;
            this.invoicesListData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.invoicesListData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // fakturaBindingSource
            // 
            this.fakturaBindingSource.DataSource = typeof(InvoiceRegister.Common.DomainModel.Faktura);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numerDataGridViewTextBoxColumn
            // 
            this.numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            this.numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            // 
            // datawystawieniaDataGridViewTextBoxColumn
            // 
            this.datawystawieniaDataGridViewTextBoxColumn.DataPropertyName = "Data_wystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.HeaderText = "Data_wystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.Name = "datawystawieniaDataGridViewTextBoxColumn";
            // 
            // datasprzedazyDataGridViewTextBoxColumn
            // 
            this.datasprzedazyDataGridViewTextBoxColumn.DataPropertyName = "Data_sprzedazy";
            this.datasprzedazyDataGridViewTextBoxColumn.HeaderText = "Data_sprzedazy";
            this.datasprzedazyDataGridViewTextBoxColumn.Name = "datasprzedazyDataGridViewTextBoxColumn";
            // 
            // sposobplatnosciDataGridViewTextBoxColumn
            // 
            this.sposobplatnosciDataGridViewTextBoxColumn.DataPropertyName = "Sposob_platnosci";
            this.sposobplatnosciDataGridViewTextBoxColumn.HeaderText = "Sposob_platnosci";
            this.sposobplatnosciDataGridViewTextBoxColumn.Name = "sposobplatnosciDataGridViewTextBoxColumn";
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            // 
            // wplaconoDataGridViewTextBoxColumn
            // 
            this.wplaconoDataGridViewTextBoxColumn.DataPropertyName = "Wplacono";
            this.wplaconoDataGridViewTextBoxColumn.HeaderText = "Wplacono";
            this.wplaconoDataGridViewTextBoxColumn.Name = "wplaconoDataGridViewTextBoxColumn";
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            this.uwagiDataGridViewTextBoxColumn.DataPropertyName = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
            // 
            // uzytkownikDataGridViewTextBoxColumn
            // 
            this.uzytkownikDataGridViewTextBoxColumn.DataPropertyName = "Uzytkownik";
            this.uzytkownikDataGridViewTextBoxColumn.HeaderText = "Uzytkownik";
            this.uzytkownikDataGridViewTextBoxColumn.Name = "uzytkownikDataGridViewTextBoxColumn";
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            // 
            // sprzedawcaDataGridViewTextBoxColumn
            // 
            this.sprzedawcaDataGridViewTextBoxColumn.DataPropertyName = "Sprzedawca";
            this.sprzedawcaDataGridViewTextBoxColumn.HeaderText = "Sprzedawca";
            this.sprzedawcaDataGridViewTextBoxColumn.Name = "sprzedawcaDataGridViewTextBoxColumn";
            // 
            // pozycjefakturyDataGridViewTextBoxColumn
            // 
            this.pozycjefakturyDataGridViewTextBoxColumn.DataPropertyName = "Pozycje_faktury";
            this.pozycjefakturyDataGridViewTextBoxColumn.HeaderText = "Pozycje_faktury";
            this.pozycjefakturyDataGridViewTextBoxColumn.Name = "pozycjefakturyDataGridViewTextBoxColumn";
            // 
            // ListInvoicesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invoicesListData);
            this.Name = "ListInvoicesPanel";
            this.Size = new System.Drawing.Size(825, 512);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView invoicesListData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawystawieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasprzedazyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sposobplatnosciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wplaconoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzytkownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprzedawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozycjefakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
    }
}
