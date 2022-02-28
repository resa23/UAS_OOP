namespace UAS_OOP_1204053
{
    partial class View_Daftar_ulang_mhs
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
            this.dgdaftarUlang = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdaftarUlang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdaftarUlang
            // 
            this.dgdaftarUlang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdaftarUlang.Location = new System.Drawing.Point(129, 122);
            this.dgdaftarUlang.Name = "dgdaftarUlang";
            this.dgdaftarUlang.RowTemplate.Height = 28;
            this.dgdaftarUlang.Size = new System.Drawing.Size(620, 321);
            this.dgdaftarUlang.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(266, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(316, 26);
            this.label.TabIndex = 1;
            this.label.Text = "Data Daftar Ulang Mahasiwa";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btRefresh.Location = new System.Drawing.Point(360, 484);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(141, 45);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // View_Daftar_ulang_mhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dgdaftarUlang);
            this.Name = "View_Daftar_ulang_mhs";
            this.Text = "View Daftar Ulang mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dgdaftarUlang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdaftarUlang;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btRefresh;
    }
}