namespace UAS_OOP_1204053
{
    partial class Update_daftar_ulang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgDU = new System.Windows.Forms.DataGridView();
            this.btUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDU)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Data Daftar Ulang Mahasiswa";
            // 
            // dgDU
            // 
            this.dgDU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDU.Location = new System.Drawing.Point(138, 127);
            this.dgDU.Name = "dgDU";
            this.dgDU.RowTemplate.Height = 28;
            this.dgDU.Size = new System.Drawing.Size(514, 299);
            this.dgDU.TabIndex = 1;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btUpdate.Location = new System.Drawing.Point(180, 449);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(151, 50);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(407, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 80);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note : \r\n\r\nUntuk menghapus data anda dapat klik kolom \r\nsebelah kiri lalu tekan \"" +
    "delete\" di keyboard .";
            // 
            // Update_daftar_ulang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dgDU);
            this.Controls.Add(this.label1);
            this.Name = "Update_daftar_ulang";
            this.Text = "Update_daftar_ulang";
            ((System.ComponentModel.ISupportInitialize)(this.dgDU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDU;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}