namespace Sistema_Evaluacion_Desempeno
{
    partial class FrmPosiciones
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
            this.txtNombrePosicion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.idposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.posicionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionDesempenoDataSet = new Sistema_Evaluacion_Desempeno.EvaluacionDesempenoDataSet();
            this.posicionesTableAdapter = new Sistema_Evaluacion_Desempeno.EvaluacionDesempenoDataSetTableAdapters.posicionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionDesempenoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePosicion
            // 
            this.txtNombrePosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePosicion.Location = new System.Drawing.Point(183, 25);
            this.txtNombrePosicion.Name = "txtNombrePosicion";
            this.txtNombrePosicion.Size = new System.Drawing.Size(274, 26);
            this.txtNombrePosicion.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la posicion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(482, 20);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(574, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.AllowUserToAddRows = false;
            this.dgvPosiciones.AllowUserToDeleteRows = false;
            this.dgvPosiciones.AutoGenerateColumns = false;
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idposicionDataGridViewTextBoxColumn,
            this.nombreposicionDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dgvPosiciones.DataSource = this.posicionesBindingSource;
            this.dgvPosiciones.Location = new System.Drawing.Point(19, 96);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.Size = new System.Drawing.Size(644, 148);
            this.dgvPosiciones.TabIndex = 5;
            this.dgvPosiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosiciones_CellClick);
            // 
            // idposicionDataGridViewTextBoxColumn
            // 
            this.idposicionDataGridViewTextBoxColumn.DataPropertyName = "id_posicion";
            this.idposicionDataGridViewTextBoxColumn.HeaderText = "id_posicion";
            this.idposicionDataGridViewTextBoxColumn.Name = "idposicionDataGridViewTextBoxColumn";
            this.idposicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreposicionDataGridViewTextBoxColumn
            // 
            this.nombreposicionDataGridViewTextBoxColumn.DataPropertyName = "nombre_posicion";
            this.nombreposicionDataGridViewTextBoxColumn.HeaderText = "nombre_posicion";
            this.nombreposicionDataGridViewTextBoxColumn.Name = "nombreposicionDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            // 
            // posicionesBindingSource
            // 
            this.posicionesBindingSource.DataMember = "posiciones";
            this.posicionesBindingSource.DataSource = this.evaluacionDesempenoDataSet;
            // 
            // evaluacionDesempenoDataSet
            // 
            this.evaluacionDesempenoDataSet.DataSetName = "EvaluacionDesempenoDataSet";
            this.evaluacionDesempenoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posicionesTableAdapter
            // 
            this.posicionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 265);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombrePosicion);
            this.Name = "FrmPosiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSICIONES";
            this.Load += new System.EventHandler(this.FrmPosiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionDesempenoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePosicion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private EvaluacionDesempenoDataSet evaluacionDesempenoDataSet;
        private System.Windows.Forms.BindingSource posicionesBindingSource;
        private EvaluacionDesempenoDataSetTableAdapters.posicionesTableAdapter posicionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}