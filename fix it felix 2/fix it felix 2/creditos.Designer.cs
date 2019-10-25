namespace fix_it_felix_2
{
    partial class creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creditos));
            this.CreditosM = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerCreditos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CreditosM)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditosM
            // 
            this.CreditosM.Enabled = true;
            this.CreditosM.Location = new System.Drawing.Point(-1, -4);
            this.CreditosM.Name = "CreditosM";
            this.CreditosM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CreditosM.OcxState")));
            this.CreditosM.Size = new System.Drawing.Size(1376, 801);
            this.CreditosM.TabIndex = 0;
            // 
            // timerCreditos
            // 
            this.timerCreditos.Tick += new System.EventHandler(this.timerCreditos_Tick);
            // 
            // creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.CreditosM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "creditos";
            this.Text = "creditos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.creditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditosM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer CreditosM;
        private System.Windows.Forms.Timer timerCreditos;
    }
}