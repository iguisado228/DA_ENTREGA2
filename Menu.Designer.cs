namespace DA_ENTREGA2
{
    partial class Menu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditatu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEditatu
            // 
            this.btnEditatu.BackColor = System.Drawing.Color.Blue;
            this.btnEditatu.Location = new System.Drawing.Point(973, 44);
            this.btnEditatu.Name = "btnEditatu";
            this.btnEditatu.Size = new System.Drawing.Size(117, 64);
            this.btnEditatu.TabIndex = 1;
            this.btnEditatu.Text = "Editatu";
            this.btnEditatu.UseVisualStyleBackColor = false;
            this.btnEditatu.Click += new System.EventHandler(this.btnEditatu_Click);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(1342, 475);
            this.Controls.Add(this.btnEditatu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TXT_menuPrintzipala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditatu;
    }
}