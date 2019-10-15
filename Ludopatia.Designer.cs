namespace App_Proyecto
{
    partial class Ludopatia
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
            this.btnConcepto = new System.Windows.Forms.Button();
            this.btnCausas = new System.Windows.Forms.Button();
            this.btnConsecuencias = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConcepto
            // 
            this.btnConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcepto.Location = new System.Drawing.Point(42, 46);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(133, 33);
            this.btnConcepto.TabIndex = 0;
            this.btnConcepto.Text = "Concepto";
            this.btnConcepto.UseVisualStyleBackColor = true;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // btnCausas
            // 
            this.btnCausas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCausas.Location = new System.Drawing.Point(42, 146);
            this.btnCausas.Name = "btnCausas";
            this.btnCausas.Size = new System.Drawing.Size(133, 33);
            this.btnCausas.TabIndex = 1;
            this.btnCausas.Text = "Causas";
            this.btnCausas.UseVisualStyleBackColor = true;
            this.btnCausas.Click += new System.EventHandler(this.btnCausas_Click);
            // 
            // btnConsecuencias
            // 
            this.btnConsecuencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsecuencias.Location = new System.Drawing.Point(42, 235);
            this.btnConsecuencias.Name = "btnConsecuencias";
            this.btnConsecuencias.Size = new System.Drawing.Size(133, 32);
            this.btnConsecuencias.TabIndex = 2;
            this.btnConsecuencias.Text = "Consecuencias";
            this.btnConsecuencias.UseVisualStyleBackColor = true;
            this.btnConsecuencias.Click += new System.EventHandler(this.btnConsecuencias_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamientos.Location = new System.Drawing.Point(42, 336);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(133, 35);
            this.btnTratamientos.TabIndex = 3;
            this.btnTratamientos.Text = "Tratamientos";
            this.btnTratamientos.UseVisualStyleBackColor = true;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(255, 46);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(385, 325);
            this.txtTexto.TabIndex = 5;
            // 
            // Ludopatia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 480);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnTratamientos);
            this.Controls.Add(this.btnConsecuencias);
            this.Controls.Add(this.btnCausas);
            this.Controls.Add(this.btnConcepto);
            this.Name = "Ludopatia";
            this.Text = "Ludopatia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcepto;
        private System.Windows.Forms.Button btnCausas;
        private System.Windows.Forms.Button btnConsecuencias;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.TextBox txtTexto;
    }
}