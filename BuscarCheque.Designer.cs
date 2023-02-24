namespace controlSistenCheck
{
    partial class BuscarCheque
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
            this.btnCancelBuscarCheque = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarDetalle = new System.Windows.Forms.TextBox();
            this.txtBuscarFolio = new System.Windows.Forms.TextBox();
            this.txtBuscarMonto = new System.Windows.Forms.TextBox();
            this.txtBuscarFecha = new System.Windows.Forms.TextBox();
            this.btnBuscarDetalle = new System.Windows.Forms.Button();
            this.btnBuscarFolio = new System.Windows.Forms.Button();
            this.btnBuscarMonto = new System.Windows.Forms.Button();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Folio_cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio_beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar_Emicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doimicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelBuscarCheque
            // 
            this.btnCancelBuscarCheque.Location = new System.Drawing.Point(980, 178);
            this.btnCancelBuscarCheque.Name = "btnCancelBuscarCheque";
            this.btnCancelBuscarCheque.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBuscarCheque.TabIndex = 0;
            this.btnCancelBuscarCheque.Text = "Cancelar";
            this.btnCancelBuscarCheque.UseVisualStyleBackColor = true;
            this.btnCancelBuscarCheque.Click += new System.EventHandler(this.btnCancelBuscarCheque_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(388, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Buscar Cheque";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(190, 55);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(606, 23);
            this.txtBuscarNombre.TabIndex = 25;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(845, 58);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNombre.TabIndex = 26;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Folio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha";
            // 
            // txtBuscarDetalle
            // 
            this.txtBuscarDetalle.Location = new System.Drawing.Point(190, 84);
            this.txtBuscarDetalle.Name = "txtBuscarDetalle";
            this.txtBuscarDetalle.Size = new System.Drawing.Size(606, 23);
            this.txtBuscarDetalle.TabIndex = 31;
            // 
            // txtBuscarFolio
            // 
            this.txtBuscarFolio.Location = new System.Drawing.Point(190, 113);
            this.txtBuscarFolio.Name = "txtBuscarFolio";
            this.txtBuscarFolio.Size = new System.Drawing.Size(606, 23);
            this.txtBuscarFolio.TabIndex = 32;
            // 
            // txtBuscarMonto
            // 
            this.txtBuscarMonto.Location = new System.Drawing.Point(190, 142);
            this.txtBuscarMonto.Name = "txtBuscarMonto";
            this.txtBuscarMonto.Size = new System.Drawing.Size(606, 23);
            this.txtBuscarMonto.TabIndex = 33;
            // 
            // txtBuscarFecha
            // 
            this.txtBuscarFecha.Location = new System.Drawing.Point(190, 171);
            this.txtBuscarFecha.Name = "txtBuscarFecha";
            this.txtBuscarFecha.Size = new System.Drawing.Size(606, 23);
            this.txtBuscarFecha.TabIndex = 34;
            // 
            // btnBuscarDetalle
            // 
            this.btnBuscarDetalle.Location = new System.Drawing.Point(845, 87);
            this.btnBuscarDetalle.Name = "btnBuscarDetalle";
            this.btnBuscarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDetalle.TabIndex = 35;
            this.btnBuscarDetalle.Text = "Buscar";
            this.btnBuscarDetalle.UseVisualStyleBackColor = true;
            this.btnBuscarDetalle.Click += new System.EventHandler(this.btnBuscarDetalle_Click_1);
            // 
            // btnBuscarFolio
            // 
            this.btnBuscarFolio.Location = new System.Drawing.Point(845, 116);
            this.btnBuscarFolio.Name = "btnBuscarFolio";
            this.btnBuscarFolio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFolio.TabIndex = 36;
            this.btnBuscarFolio.Text = "Buscar";
            this.btnBuscarFolio.UseVisualStyleBackColor = true;
            this.btnBuscarFolio.Click += new System.EventHandler(this.btnBuscarFolio_Click_1);
            // 
            // btnBuscarMonto
            // 
            this.btnBuscarMonto.Location = new System.Drawing.Point(845, 146);
            this.btnBuscarMonto.Name = "btnBuscarMonto";
            this.btnBuscarMonto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMonto.TabIndex = 37;
            this.btnBuscarMonto.Text = "Buscar";
            this.btnBuscarMonto.UseVisualStyleBackColor = true;
            this.btnBuscarMonto.Click += new System.EventHandler(this.btnBuscarMonto_Click_1);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Location = new System.Drawing.Point(845, 174);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFecha.TabIndex = 38;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio_cheque,
            this.Folio_beneficiario,
            this.Suma,
            this.Banco,
            this.Lugar_Pago,
            this.Fecha_Emision,
            this.Lugar_Emicion,
            this.Estado,
            this.Nombre,
            this.Telefono,
            this.Doimicilio,
            this.No_Detalle,
            this.Detalle,
            this.Actualizar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 436);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Folio_cheque
            // 
            this.Folio_cheque.HeaderText = "Folio_cheque";
            this.Folio_cheque.Name = "Folio_cheque";
            // 
            // Folio_beneficiario
            // 
            this.Folio_beneficiario.HeaderText = "Folio_beneficiario";
            this.Folio_beneficiario.Name = "Folio_beneficiario";
            // 
            // Suma
            // 
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            // 
            // Lugar_Pago
            // 
            this.Lugar_Pago.HeaderText = "Lugar_Pago";
            this.Lugar_Pago.Name = "Lugar_Pago";
            // 
            // Fecha_Emision
            // 
            this.Fecha_Emision.HeaderText = "Fecha_Emision";
            this.Fecha_Emision.Name = "Fecha_Emision";
            // 
            // Lugar_Emicion
            // 
            this.Lugar_Emicion.HeaderText = "Lugar_Emicion";
            this.Lugar_Emicion.Name = "Lugar_Emicion";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Doimicilio
            // 
            this.Doimicilio.HeaderText = "Domicilio";
            this.Doimicilio.Name = "Doimicilio";
            // 
            // No_Detalle
            // 
            this.No_Detalle.HeaderText = "No_Detalle";
            this.No_Detalle.Name = "No_Detalle";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "Actualizar";
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Actualizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BuscarCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.btnBuscarMonto);
            this.Controls.Add(this.btnBuscarFolio);
            this.Controls.Add(this.btnBuscarDetalle);
            this.Controls.Add(this.txtBuscarFecha);
            this.Controls.Add(this.txtBuscarMonto);
            this.Controls.Add(this.txtBuscarFolio);
            this.Controls.Add(this.txtBuscarDetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelBuscarCheque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarCheque";
            this.Text = "BuscarCheque";
            this.Load += new System.EventHandler(this.BuscarCheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelBuscarCheque;
        private Label label10;
        private Label label1;
        private TextBox txtBuscarNombre;
        private Button btnBuscarNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBuscarDetalle;
        private TextBox txtBuscarFolio;
        private TextBox txtBuscarMonto;
        private TextBox txtBuscarFecha;
        private Button btnBuscarDetalle;
        private Button btnBuscarFolio;
        private Button btnBuscarMonto;
        private Button btnBuscarFecha;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Folio_cheque;
        private DataGridViewTextBoxColumn Folio_beneficiario;
        private DataGridViewTextBoxColumn Suma;
        private DataGridViewTextBoxColumn Banco;
        private DataGridViewTextBoxColumn Lugar_Pago;
        private DataGridViewTextBoxColumn Fecha_Emision;
        private DataGridViewTextBoxColumn Lugar_Emicion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Doimicilio;
        private DataGridViewTextBoxColumn No_Detalle;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewButtonColumn Actualizar;
        private DataGridViewButtonColumn Eliminar;
    }
}