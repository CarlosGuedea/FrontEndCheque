namespace controlSistenCheck
{
    partial class AgregarCuenta
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
            this.btnCancelAddCuenta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.txtMontocuenta = new System.Windows.Forms.TextBox();
            this.btnAceptarCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelAddCuenta
            // 
            this.btnCancelAddCuenta.Location = new System.Drawing.Point(829, 566);
            this.btnCancelAddCuenta.Name = "btnCancelAddCuenta";
            this.btnCancelAddCuenta.Size = new System.Drawing.Size(190, 69);
            this.btnCancelAddCuenta.TabIndex = 0;
            this.btnCancelAddCuenta.Text = "Cancelar";
            this.btnCancelAddCuenta.UseVisualStyleBackColor = true;
            this.btnCancelAddCuenta.Click += new System.EventHandler(this.btnCancelAddCuenta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(388, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 45);
            this.label10.TabIndex = 22;
            this.label10.Text = "AGREGAR CUENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "No. Cuenta bancaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(263, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Monto";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(511, 256);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(255, 23);
            this.txtNoCuenta.TabIndex = 25;
            // 
            // txtMontocuenta
            // 
            this.txtMontocuenta.Location = new System.Drawing.Point(511, 309);
            this.txtMontocuenta.Name = "txtMontocuenta";
            this.txtMontocuenta.Size = new System.Drawing.Size(255, 23);
            this.txtMontocuenta.TabIndex = 26;
            // 
            // btnAceptarCuenta
            // 
            this.btnAceptarCuenta.Location = new System.Drawing.Point(583, 369);
            this.btnAceptarCuenta.Name = "btnAceptarCuenta";
            this.btnAceptarCuenta.Size = new System.Drawing.Size(122, 23);
            this.btnAceptarCuenta.TabIndex = 27;
            this.btnAceptarCuenta.Text = "Crear Cuenta";
            this.btnAceptarCuenta.UseVisualStyleBackColor = true;
            // 
            // AgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnAceptarCuenta);
            this.Controls.Add(this.txtMontocuenta);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelAddCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCuenta";
            this.Text = "AgregarCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelAddCuenta;
        private Label label10;
        private Label label1;
        private Label label2;
        private TextBox txtNoCuenta;
        private TextBox txtMontocuenta;
        private Button btnAceptarCuenta;
    }
}