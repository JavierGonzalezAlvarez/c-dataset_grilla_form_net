namespace Menu
{
    partial class Form_DataSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DataSet));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idFamiliaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formularioAccesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionFormularioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet = new Menu.DataSet();
            this.tbFormularioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_FormularioTableAdapter = new Menu.DataSetTableAdapters.Tb_FormularioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFormularioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFamiliaDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.formularioAccesoDataGridViewTextBoxColumn,
            this.descripcionFormularioDataGridViewTextBoxColumn});
            this.dataGridView.DataMember = "Tb_Formulario";
            this.dataGridView.DataSource = this.dataSet;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(870, 391);
            this.dataGridView.TabIndex = 1;
            // 
            // idFamiliaDataGridViewTextBoxColumn
            // 
            this.idFamiliaDataGridViewTextBoxColumn.DataPropertyName = "IdFamilia";
            this.idFamiliaDataGridViewTextBoxColumn.HeaderText = "IdFamilia";
            this.idFamiliaDataGridViewTextBoxColumn.Name = "idFamiliaDataGridViewTextBoxColumn";
            this.idFamiliaDataGridViewTextBoxColumn.Width = 73;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 77;
            // 
            // formularioAccesoDataGridViewTextBoxColumn
            // 
            this.formularioAccesoDataGridViewTextBoxColumn.DataPropertyName = "FormularioAcceso";
            this.formularioAccesoDataGridViewTextBoxColumn.HeaderText = "FormularioAcceso";
            this.formularioAccesoDataGridViewTextBoxColumn.Name = "formularioAccesoDataGridViewTextBoxColumn";
            this.formularioAccesoDataGridViewTextBoxColumn.Width = 116;
            // 
            // descripcionFormularioDataGridViewTextBoxColumn
            // 
            this.descripcionFormularioDataGridViewTextBoxColumn.DataPropertyName = "DescripcionFormulario";
            this.descripcionFormularioDataGridViewTextBoxColumn.HeaderText = "Formulario";
            this.descripcionFormularioDataGridViewTextBoxColumn.Name = "descripcionFormularioDataGridViewTextBoxColumn";
            this.descripcionFormularioDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFormularioBindingSource
            // 
            this.tbFormularioBindingSource.DataMember = "Tb_Formulario";
            this.tbFormularioBindingSource.DataSource = this.dataSet;
            // 
            // tb_FormularioTableAdapter
            // 
            this.tb_FormularioTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 416);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DataSet";
            this.Text = "Formulario_Grilla_DataSet";
            this.Load += new System.EventHandler(this.Form_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFormularioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Data.DataSet DataSet_1;
        private DataSet dataSet;
        private DataSetTableAdapters.Tb_FormularioTableAdapter tb_FormularioTableAdapter;
        private System.Windows.Forms.BindingSource tbFormularioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamiliaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formularioAccesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionFormularioDataGridViewTextBoxColumn;
    }
}