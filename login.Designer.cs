﻿namespace DA_ENTREGA2
{
    partial class login
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
            this.LBL_erabiltzailea = new System.Windows.Forms.Label();
            this.LBL_pasahitza = new System.Windows.Forms.Label();
            this.TXT_erabiltzailea = new System.Windows.Forms.TextBox();
            this.TXT_pasahitza = new System.Windows.Forms.TextBox();
            this.BTN_sartu = new System.Windows.Forms.Button();
            this.atera_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_erabiltzailea
            // 
            this.LBL_erabiltzailea.AutoSize = true;
            this.LBL_erabiltzailea.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_erabiltzailea.Location = new System.Drawing.Point(83, 67);
            this.LBL_erabiltzailea.Name = "LBL_erabiltzailea";
            this.LBL_erabiltzailea.Size = new System.Drawing.Size(312, 58);
            this.LBL_erabiltzailea.TabIndex = 0;
            this.LBL_erabiltzailea.Text = "Erabiltzailea:";
            this.LBL_erabiltzailea.Click += new System.EventHandler(this.LBL_erabiltzailea_Click);
            // 
            // LBL_pasahitza
            // 
            this.LBL_pasahitza.AutoSize = true;
            this.LBL_pasahitza.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_pasahitza.Location = new System.Drawing.Point(83, 245);
            this.LBL_pasahitza.Name = "LBL_pasahitza";
            this.LBL_pasahitza.Size = new System.Drawing.Size(259, 58);
            this.LBL_pasahitza.TabIndex = 1;
            this.LBL_pasahitza.Text = "Pasahitza:";
            this.LBL_pasahitza.Click += new System.EventHandler(this.LBL_pasahitza_Click);
            // 
            // TXT_erabiltzailea
            // 
            this.TXT_erabiltzailea.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_erabiltzailea.Location = new System.Drawing.Point(80, 128);
            this.TXT_erabiltzailea.Name = "TXT_erabiltzailea";
            this.TXT_erabiltzailea.Size = new System.Drawing.Size(558, 64);
            this.TXT_erabiltzailea.TabIndex = 2;
            this.TXT_erabiltzailea.TextChanged += new System.EventHandler(this.TXT_erabiltzailea_TextChanged);
            // 
            // TXT_pasahitza
            // 
            this.TXT_pasahitza.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_pasahitza.Location = new System.Drawing.Point(80, 306);
            this.TXT_pasahitza.Name = "TXT_pasahitza";
            this.TXT_pasahitza.Size = new System.Drawing.Size(558, 64);
            this.TXT_pasahitza.TabIndex = 3;
            this.TXT_pasahitza.TextChanged += new System.EventHandler(this.TXT_pasahitza_TextChanged);
            // 
            // BTN_sartu
            // 
            this.BTN_sartu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sartu.Location = new System.Drawing.Point(93, 429);
            this.BTN_sartu.Name = "BTN_sartu";
            this.BTN_sartu.Size = new System.Drawing.Size(317, 66);
            this.BTN_sartu.TabIndex = 4;
            this.BTN_sartu.Text = "Sartu";
            this.BTN_sartu.UseVisualStyleBackColor = true;
            this.BTN_sartu.Click += new System.EventHandler(this.BTN_sartu_Click);
            // 
            // atera_BTN
            // 
            this.atera_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atera_BTN.Location = new System.Drawing.Point(1688, 870);
            this.atera_BTN.Name = "atera_BTN";
            this.atera_BTN.Size = new System.Drawing.Size(224, 116);
            this.atera_BTN.TabIndex = 5;
            this.atera_BTN.Text = "Atera";
            this.atera_BTN.UseVisualStyleBackColor = true;
            this.atera_BTN.Click += new System.EventHandler(this.atera_BTN_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.atera_BTN);
            this.Controls.Add(this.BTN_sartu);
            this.Controls.Add(this.TXT_pasahitza);
            this.Controls.Add(this.TXT_erabiltzailea);
            this.Controls.Add(this.LBL_pasahitza);
            this.Controls.Add(this.LBL_erabiltzailea);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_erabiltzailea;
        private System.Windows.Forms.Label LBL_pasahitza;
        private System.Windows.Forms.TextBox TXT_erabiltzailea;
        private System.Windows.Forms.TextBox TXT_pasahitza;
        private System.Windows.Forms.Button BTN_sartu;
        private System.Windows.Forms.Button atera_BTN;
    }
}