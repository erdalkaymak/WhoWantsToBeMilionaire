namespace WhoWantsToBeMilionaire
{
    partial class FrmQuiz
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tblSpecPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rndBtnFifty = new WhoWantsToBeMilionaire.RoundButton();
            this.rndBtnSpec = new WhoWantsToBeMilionaire.RoundButton();
            this.rndBtnPhone = new WhoWantsToBeMilionaire.RoundButton();
            this.tblSpecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuestion.ForeColor = System.Drawing.Color.White;
            this.txtQuestion.Location = new System.Drawing.Point(86, 333);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(837, 80);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A.Location = new System.Drawing.Point(86, 479);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(329, 49);
            this.A.TabIndex = 1;
            this.A.Tag = "1";
            this.A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.D.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.D.Location = new System.Drawing.Point(594, 550);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(329, 49);
            this.D.TabIndex = 2;
            this.D.Tag = "4";
            this.D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.A_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C.Location = new System.Drawing.Point(86, 550);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(329, 49);
            this.C.TabIndex = 3;
            this.C.Tag = "3";
            this.C.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.A_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B.Location = new System.Drawing.Point(594, 479);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(329, 49);
            this.B.TabIndex = 4;
            this.B.Tag = "2";
            this.B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.A_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTime.Location = new System.Drawing.Point(724, 273);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(-2, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 61);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Oyundan Çık";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Black;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(782, 1);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(223, 61);
            this.btnNewGame.TabIndex = 17;
            this.btnNewGame.Text = "Yeni Oyun Başlat";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tblSpecPanel
            // 
            this.tblSpecPanel.BackColor = System.Drawing.Color.Navy;
            this.tblSpecPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblSpecPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tblSpecPanel.ColumnCount = 5;
            this.tblSpecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.47059F));
            this.tblSpecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.52941F));
            this.tblSpecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tblSpecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tblSpecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tblSpecPanel.Controls.Add(this.lblC1, 3, 0);
            this.tblSpecPanel.Controls.Add(this.lblB1, 2, 0);
            this.tblSpecPanel.Controls.Add(this.lblD1, 4, 0);
            this.tblSpecPanel.Controls.Add(this.lblA1, 1, 0);
            this.tblSpecPanel.Controls.Add(this.lblA, 1, 3);
            this.tblSpecPanel.Controls.Add(this.label2, 2, 3);
            this.tblSpecPanel.Controls.Add(this.label3, 3, 3);
            this.tblSpecPanel.Controls.Add(this.label4, 4, 3);
            this.tblSpecPanel.Location = new System.Drawing.Point(416, 112);
            this.tblSpecPanel.Name = "tblSpecPanel";
            this.tblSpecPanel.RowCount = 4;
            this.tblSpecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSpecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSpecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblSpecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSpecPanel.Size = new System.Drawing.Size(347, 190);
            this.tblSpecPanel.TabIndex = 30;
            this.tblSpecPanel.Visible = false;
            // 
            // lblC1
            // 
            this.lblC1.BackColor = System.Drawing.Color.Transparent;
            this.lblC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblC1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblC1.Location = new System.Drawing.Point(178, 3);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(71, 27);
            this.lblC1.TabIndex = 10;
            this.lblC1.Text = "%32";
            this.lblC1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblB1
            // 
            this.lblB1.BackColor = System.Drawing.Color.Transparent;
            this.lblB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblB1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblB1.Location = new System.Drawing.Point(88, 3);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(73, 27);
            this.lblB1.TabIndex = 9;
            this.lblB1.Text = "%23";
            this.lblB1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblD1
            // 
            this.lblD1.BackColor = System.Drawing.Color.Transparent;
            this.lblD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblD1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblD1.Location = new System.Drawing.Point(258, 3);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(72, 27);
            this.lblD1.TabIndex = 11;
            this.lblD1.Text = "%45";
            this.lblD1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblA1
            // 
            this.lblA1.BackColor = System.Drawing.Color.Navy;
            this.lblA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblA1.Location = new System.Drawing.Point(21, 3);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(58, 27);
            this.lblA1.TabIndex = 8;
            this.lblA1.Text = "%18";
            this.lblA1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA.ForeColor = System.Drawing.Color.Ivory;
            this.lblA.Location = new System.Drawing.Point(21, 167);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(56, 20);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(88, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(178, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(258, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rndBtnFifty
            // 
            this.rndBtnFifty.BackgroundImage = global::WhoWantsToBeMilionaire.Properties.Resources.classic5050;
            this.rndBtnFifty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rndBtnFifty.Location = new System.Drawing.Point(594, 35);
            this.rndBtnFifty.Name = "rndBtnFifty";
            this.rndBtnFifty.Size = new System.Drawing.Size(87, 50);
            this.rndBtnFifty.TabIndex = 25;
            this.rndBtnFifty.UseVisualStyleBackColor = true;
            // 
            // rndBtnSpec
            // 
            this.rndBtnSpec.BackgroundImage = global::WhoWantsToBeMilionaire.Properties.Resources.classicata1;
            this.rndBtnSpec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rndBtnSpec.Location = new System.Drawing.Point(330, 35);
            this.rndBtnSpec.Name = "rndBtnSpec";
            this.rndBtnSpec.Size = new System.Drawing.Size(85, 50);
            this.rndBtnSpec.TabIndex = 24;
            this.rndBtnSpec.UseVisualStyleBackColor = true;
            // 
            // rndBtnPhone
            // 
            this.rndBtnPhone.BackgroundImage = global::WhoWantsToBeMilionaire.Properties.Resources.classicpaf;
            this.rndBtnPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rndBtnPhone.Location = new System.Drawing.Point(460, 35);
            this.rndBtnPhone.Name = "rndBtnPhone";
            this.rndBtnPhone.Size = new System.Drawing.Size(78, 50);
            this.rndBtnPhone.TabIndex = 26;
            this.rndBtnPhone.UseVisualStyleBackColor = true;
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeMilionaire.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 691);
            this.Controls.Add(this.tblSpecPanel);
            this.Controls.Add(this.rndBtnFifty);
            this.Controls.Add(this.rndBtnSpec);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.D);
            this.Controls.Add(this.rndBtnPhone);
            this.Controls.Add(this.A);
            this.Controls.Add(this.txtQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuiz";
            this.tblSpecPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewGame;
        private RoundButton rndBtnSpec;
        private RoundButton rndBtnFifty;
        private RoundButton rndBtnPhone;
        private System.Windows.Forms.TableLayoutPanel tblSpecPanel;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}