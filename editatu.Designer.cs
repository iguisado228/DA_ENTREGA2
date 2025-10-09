namespace DA_ENTREGA2
{
    partial class editatu
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
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtAbizena2 = new System.Windows.Forms.TextBox();
            this.txtJaiotzaData = new System.Windows.Forms.TextBox();
            this.txtAbizena1 = new System.Windows.Forms.TextBox();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtHelbidea = new System.Windows.Forms.TextBox();
            this.editatu_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIzena
            // 
            this.txtIzena.Location = new System.Drawing.Point(119, 129);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(169, 22);
            this.txtIzena.TabIndex = 0;
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(662, 175);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(169, 22);
            this.txtPosta.TabIndex = 1;
            // 
            // txtAbizena2
            // 
            this.txtAbizena2.Location = new System.Drawing.Point(662, 129);
            this.txtAbizena2.Name = "txtAbizena2";
            this.txtAbizena2.Size = new System.Drawing.Size(169, 22);
            this.txtAbizena2.TabIndex = 2;
            // 
            // txtJaiotzaData
            // 
            this.txtJaiotzaData.Location = new System.Drawing.Point(408, 175);
            this.txtJaiotzaData.Name = "txtJaiotzaData";
            this.txtJaiotzaData.Size = new System.Drawing.Size(169, 22);
            this.txtJaiotzaData.TabIndex = 3;
            this.txtJaiotzaData.TextChanged += new System.EventHandler(this.txtJaiotzaData_TextChanged);
            // 
            // txtAbizena1
            // 
            this.txtAbizena1.Location = new System.Drawing.Point(408, 129);
            this.txtAbizena1.Name = "txtAbizena1";
            this.txtAbizena1.Size = new System.Drawing.Size(169, 22);
            this.txtAbizena1.TabIndex = 4;
            // 
            // txtNan
            // 
            this.txtNan.Location = new System.Drawing.Point(119, 175);
            this.txtNan.Name = "txtNan";
            this.txtNan.Size = new System.Drawing.Size(169, 22);
            this.txtNan.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(119, 239);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtHelbidea
            // 
            this.txtHelbidea.Location = new System.Drawing.Point(408, 239);
            this.txtHelbidea.Name = "txtHelbidea";
            this.txtHelbidea.Size = new System.Drawing.Size(169, 22);
            this.txtHelbidea.TabIndex = 7;
            // 
            // editatu_BTN
            // 
            this.editatu_BTN.ForeColor = System.Drawing.Color.Black;
            this.editatu_BTN.Location = new System.Drawing.Point(674, 349);
            this.editatu_BTN.Name = "editatu_BTN";
            this.editatu_BTN.Size = new System.Drawing.Size(177, 61);
            this.editatu_BTN.TabIndex = 8;
            this.editatu_BTN.Text = "Gorde";
            this.editatu_BTN.UseVisualStyleBackColor = true;
            this.editatu_BTN.Click += new System.EventHandler(this.editatu_BTN_Click);
            // 
            // editatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 485);
            this.Controls.Add(this.editatu_BTN);
            this.Controls.Add(this.txtHelbidea);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.txtAbizena1);
            this.Controls.Add(this.txtJaiotzaData);
            this.Controls.Add(this.txtAbizena2);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.txtIzena);
            this.Name = "editatu";
            this.Text = "editatu";
            this.Load += new System.EventHandler(this.editatu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtAbizena2;
        private System.Windows.Forms.TextBox txtJaiotzaData;
        private System.Windows.Forms.TextBox txtAbizena1;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtHelbidea;
        private System.Windows.Forms.Button editatu_BTN;
    }
}