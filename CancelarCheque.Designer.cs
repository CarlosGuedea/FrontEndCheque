namespace controlSistenCheck
{
    partial class CancelarCheque
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
            this.btnCancelCancelarCheque = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelCancelarCheque
            // 
            this.btnCancelCancelarCheque.Location = new System.Drawing.Point(695, 388);
            this.btnCancelCancelarCheque.Name = "btnCancelCancelarCheque";
            this.btnCancelCancelarCheque.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCancelarCheque.TabIndex = 0;
            this.btnCancelCancelarCheque.Text = "Cancelar";
            this.btnCancelCancelarCheque.UseVisualStyleBackColor = true;
            this.btnCancelCancelarCheque.Click += new System.EventHandler(this.btnCancelCancelarCheque_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(283, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "CANCELACION CHEQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Folio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 23);
            this.textBox1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar Cheque";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CancelarCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelCancelarCheque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelarCheque";
            this.Text = "CancelarCheque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelCancelarCheque;
        private Label label10;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}