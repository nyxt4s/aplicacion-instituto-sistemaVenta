namespace prueba
{
    partial class Finanzas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Ganancia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Gastos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCLIENTESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPEDIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAROSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBASTIDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDACCESORIOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdElCofreDelBordadoDataSet12 = new prueba.BdElCofreDelBordadoDataSet12();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDMATERIALESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdElCofreDelBordadoDataSet13 = new prueba.BdElCofreDelBordadoDataSet13();
            this.pEDIDOSTableAdapter = new prueba.BdElCofreDelBordadoDataSet12TableAdapters.PEDIDOSTableAdapter();
            this.mATERIALESTableAdapter = new prueba.BdElCofreDelBordadoDataSet13TableAdapters.MATERIALESTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdElCofreDelBordadoDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdElCofreDelBordadoDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Ganancia);
            this.panel1.Location = new System.Drawing.Point(1033, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 195);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ganancias a la fecha según lo registrado";
            // 
            // Ganancia
            // 
            this.Ganancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Ganancia.AutoSize = true;
            this.Ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganancia.ForeColor = System.Drawing.Color.White;
            this.Ganancia.Location = new System.Drawing.Point(152, 93);
            this.Ganancia.Name = "Ganancia";
            this.Ganancia.Size = new System.Drawing.Size(43, 24);
            this.Ganancia.TabIndex = 0;
            this.Ganancia.Text = "___";
            this.Ganancia.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1156, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GANANCIAS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1177, 403);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "GASTOS";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Gastos);
            this.panel2.Location = new System.Drawing.Point(1033, 436);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 195);
            this.panel2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gastos a la fecha según lo registrado";
            // 
            // Gastos
            // 
            this.Gastos.AutoSize = true;
            this.Gastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gastos.ForeColor = System.Drawing.Color.White;
            this.Gastos.Location = new System.Drawing.Point(164, 100);
            this.Gastos.Name = "Gastos";
            this.Gastos.Size = new System.Drawing.Size(43, 24);
            this.Gastos.TabIndex = 0;
            this.Gastos.Text = "___";
            this.Gastos.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTESDataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.iDPEDIDOSDataGridViewTextBoxColumn,
            this.iDAROSDataGridViewTextBoxColumn,
            this.iDBASTIDORDataGridViewTextBoxColumn,
            this.iDACCESORIOSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pEDIDOSBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(40, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(920, 197);
            this.dataGridView1.TabIndex = 27;
            // 
            // iDCLIENTESDataGridViewTextBoxColumn
            // 
            this.iDCLIENTESDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTES";
            this.iDCLIENTESDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTES";
            this.iDCLIENTESDataGridViewTextBoxColumn.Name = "iDCLIENTESDataGridViewTextBoxColumn";
            this.iDCLIENTESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            this.pRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPEDIDOSDataGridViewTextBoxColumn
            // 
            this.iDPEDIDOSDataGridViewTextBoxColumn.DataPropertyName = "ID_PEDIDOS";
            this.iDPEDIDOSDataGridViewTextBoxColumn.HeaderText = "ID_PEDIDOS";
            this.iDPEDIDOSDataGridViewTextBoxColumn.Name = "iDPEDIDOSDataGridViewTextBoxColumn";
            this.iDPEDIDOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDAROSDataGridViewTextBoxColumn
            // 
            this.iDAROSDataGridViewTextBoxColumn.DataPropertyName = "ID_AROS";
            this.iDAROSDataGridViewTextBoxColumn.HeaderText = "ID_AROS";
            this.iDAROSDataGridViewTextBoxColumn.Name = "iDAROSDataGridViewTextBoxColumn";
            this.iDAROSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDBASTIDORDataGridViewTextBoxColumn
            // 
            this.iDBASTIDORDataGridViewTextBoxColumn.DataPropertyName = "ID_BASTIDOR";
            this.iDBASTIDORDataGridViewTextBoxColumn.HeaderText = "ID_BASTIDOR";
            this.iDBASTIDORDataGridViewTextBoxColumn.Name = "iDBASTIDORDataGridViewTextBoxColumn";
            this.iDBASTIDORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDACCESORIOSDataGridViewTextBoxColumn
            // 
            this.iDACCESORIOSDataGridViewTextBoxColumn.DataPropertyName = "ID_ACCESORIOS";
            this.iDACCESORIOSDataGridViewTextBoxColumn.HeaderText = "ID_ACCESORIOS";
            this.iDACCESORIOSDataGridViewTextBoxColumn.Name = "iDACCESORIOSDataGridViewTextBoxColumn";
            this.iDACCESORIOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDIDOSBindingSource
            // 
            this.pEDIDOSBindingSource.DataMember = "PEDIDOS";
            this.pEDIDOSBindingSource.DataSource = this.bdElCofreDelBordadoDataSet12;
            // 
            // bdElCofreDelBordadoDataSet12
            // 
            this.bdElCofreDelBordadoDataSet12.DataSetName = "BdElCofreDelBordadoDataSet12";
            this.bdElCofreDelBordadoDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeight = 25;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMATERIALESDataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.cOSTODataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mATERIALESBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.Location = new System.Drawing.Point(40, 434);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(920, 202);
            this.dataGridView2.TabIndex = 28;
            // 
            // iDMATERIALESDataGridViewTextBoxColumn
            // 
            this.iDMATERIALESDataGridViewTextBoxColumn.DataPropertyName = "ID_MATERIALES";
            this.iDMATERIALESDataGridViewTextBoxColumn.HeaderText = "ID_MATERIALES";
            this.iDMATERIALESDataGridViewTextBoxColumn.Name = "iDMATERIALESDataGridViewTextBoxColumn";
            this.iDMATERIALESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOSTODataGridViewTextBoxColumn
            // 
            this.cOSTODataGridViewTextBoxColumn.DataPropertyName = "COSTO";
            this.cOSTODataGridViewTextBoxColumn.HeaderText = "COSTO";
            this.cOSTODataGridViewTextBoxColumn.Name = "cOSTODataGridViewTextBoxColumn";
            this.cOSTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mATERIALESBindingSource
            // 
            this.mATERIALESBindingSource.DataMember = "MATERIALES";
            this.mATERIALESBindingSource.DataSource = this.bdElCofreDelBordadoDataSet13;
            // 
            // bdElCofreDelBordadoDataSet13
            // 
            this.bdElCofreDelBordadoDataSet13.DataSetName = "BdElCofreDelBordadoDataSet13";
            this.bdElCofreDelBordadoDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pEDIDOSTableAdapter
            // 
            this.pEDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // mATERIALESTableAdapter
            // 
            this.mATERIALESTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "GANANCIAS";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "GASTOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "FINANZAS";
            // 
            // Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1480, 715);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Finanzas";
            this.Text = "Finanzas";
            this.Load += new System.EventHandler(this.Finanzas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdElCofreDelBordadoDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdElCofreDelBordadoDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ganancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Gastos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BdElCofreDelBordadoDataSet12 bdElCofreDelBordadoDataSet12;
        private System.Windows.Forms.BindingSource pEDIDOSBindingSource;
        private BdElCofreDelBordadoDataSet12TableAdapters.PEDIDOSTableAdapter pEDIDOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPEDIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAROSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBASTIDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDACCESORIOSDataGridViewTextBoxColumn;
        private BdElCofreDelBordadoDataSet13 bdElCofreDelBordadoDataSet13;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource;
        private BdElCofreDelBordadoDataSet13TableAdapters.MATERIALESTableAdapter mATERIALESTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMATERIALESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTODataGridViewTextBoxColumn;
    }
}