namespace WhoWantsToBeMilionaire
{
    partial class FrmNewGame
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
            this.txtOdulYeni = new System.Windows.Forms.TextBox();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOdulYeni
            // 
            this.txtOdulYeni.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtOdulYeni.Enabled = false;
            this.txtOdulYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdulYeni.ForeColor = System.Drawing.Color.White;
            this.txtOdulYeni.Location = new System.Drawing.Point(164, 309);
            this.txtOdulYeni.Multiline = true;
            this.txtOdulYeni.Name = "txtOdulYeni";
            this.txtOdulYeni.ReadOnly = true;
            this.txtOdulYeni.Size = new System.Drawing.Size(643, 45);
            this.txtOdulYeni.TabIndex = 15;
            this.txtOdulYeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.Black;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.Color.White;
            this.btnYeniOyun.Location = new System.Drawing.Point(596, 393);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(211, 61);
            this.btnYeniOyun.TabIndex = 16;
            this.btnYeniOyun.Text = "Yeni Oyuna Başla";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Black;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(164, 393);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(201, 61);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "Oyundan Çık";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeMilionaire.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 691);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.txtOdulYeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOdulYeni;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Button btnCikis;
    }
}