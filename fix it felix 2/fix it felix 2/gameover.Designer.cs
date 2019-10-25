namespace fix_it_felix_2
{
    partial class gameover
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
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PBXFELIX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBXFELIX)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(534, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 69);
            this.button1.TabIndex = 54;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Lucida Calligraphy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DarkRed;
            this.Label1.Location = new System.Drawing.Point(488, 496);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(507, 83);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "GAME OVER";
            // 
            // PBXFELIX
            // 
            this.PBXFELIX.Image = global::fix_it_felix_2.Properties.Resources.giphy;
            this.PBXFELIX.Location = new System.Drawing.Point(12, 39);
            this.PBXFELIX.Name = "PBXFELIX";
            this.PBXFELIX.Size = new System.Drawing.Size(1354, 419);
            this.PBXFELIX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXFELIX.TabIndex = 52;
            this.PBXFELIX.TabStop = false;
            // 
            // gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PBXFELIX);
            this.Name = "gameover";
            this.Text = "gameover";
            this.Load += new System.EventHandler(this.gameover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBXFELIX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PBXFELIX;
    }
}