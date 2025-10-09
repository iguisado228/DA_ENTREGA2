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
            this.editatu_BTN = new System.Windows.Forms.Button();
            this.sortu_BTN = new System.Windows.Forms.Button();
            this.ezabatu_BTN = new System.Windows.Forms.Button();
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
            // editatu_BTN
            // 
            this.editatu_BTN.BackColor = System.Drawing.Color.Blue;
            this.editatu_BTN.Location = new System.Drawing.Point(973, 150);
            this.editatu_BTN.Name = "editatu_BTN";
            this.editatu_BTN.Size = new System.Drawing.Size(117, 64);
            this.editatu_BTN.TabIndex = 1;
            this.editatu_BTN.Text = "Editatu";
            this.editatu_BTN.UseVisualStyleBackColor = false;
            this.editatu_BTN.Click += new System.EventHandler(this.btnEditatu_Click);
            // 
            // sortu_BTN
            // 
            this.sortu_BTN.BackColor = System.Drawing.Color.Green;
            this.sortu_BTN.Location = new System.Drawing.Point(973, 58);
            this.sortu_BTN.Name = "sortu_BTN";
            this.sortu_BTN.Size = new System.Drawing.Size(117, 64);
            this.sortu_BTN.TabIndex = 2;
            this.sortu_BTN.Text = "Sortu";
            this.sortu_BTN.UseVisualStyleBackColor = false;
            this.sortu_BTN.Click += new System.EventHandler(this.sortu_BTN_Click);
            // 
            // ezabatu_BTN
            // 
            this.ezabatu_BTN.BackColor = System.Drawing.Color.Red;
            this.ezabatu_BTN.Location = new System.Drawing.Point(973, 240);
            this.ezabatu_BTN.Name = "ezabatu_BTN";
            this.ezabatu_BTN.Size = new System.Drawing.Size(117, 64);
            this.ezabatu_BTN.TabIndex = 3;
            this.ezabatu_BTN.Text = "Ezabatu";
            this.ezabatu_BTN.UseVisualStyleBackColor = false;
            this.ezabatu_BTN.Click += new System.EventHandler(this.ezabatu_BTN_Click);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(1342, 475);
            this.Controls.Add(this.ezabatu_BTN);
            this.Controls.Add(this.sortu_BTN);
            this.Controls.Add(this.editatu_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TXT_menuPrintzipala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editatu_BTN;
        private System.Windows.Forms.Button sortu_BTN;
        private System.Windows.Forms.Button ezabatu_BTN;
    }
}