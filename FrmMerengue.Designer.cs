namespace App_Proyecto
{
    partial class FrmMerengue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMerengue));
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnver = new System.Windows.Forms.Button();
            this.btnreturn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(1, 0);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(662, 378);
            this.wmp1.TabIndex = 0;
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(713, 35);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(75, 23);
            this.btnver.TabIndex = 3;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // btnreturn2
            // 
            this.btnreturn2.Location = new System.Drawing.Point(713, 137);
            this.btnreturn2.Name = "btnreturn2";
            this.btnreturn2.Size = new System.Drawing.Size(75, 23);
            this.btnreturn2.TabIndex = 4;
            this.btnreturn2.Text = "return";
            this.btnreturn2.UseVisualStyleBackColor = true;
            this.btnreturn2.Click += new System.EventHandler(this.btnreturn2_Click);
            // 
            // FrmMerengue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreturn2);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.wmp1);
            this.Name = "FrmMerengue";
            this.Text = "FrmMerengue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Button btnreturn2;
    }
}