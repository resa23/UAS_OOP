﻿namespace UAS_OOP_1204053
{
    partial class Update_Mhs
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
            this.dgMhs = new System.Windows.Forms.DataGridView();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Data Mahasiswa";
            // 
            // dgMhs
            // 
            this.dgMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMhs.Location = new System.Drawing.Point(93, 109);
            this.dgMhs.Name = "dgMhs";
            this.dgMhs.RowTemplate.Height = 28;
            this.dgMhs.Size = new System.Drawing.Size(532, 307);
            this.dgMhs.TabIndex = 1;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btUpdate.Location = new System.Drawing.Point(152, 434);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(139, 48);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btRefresh.Location = new System.Drawing.Point(406, 439);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(153, 43);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 80);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note : \r\n\r\nUntuk menghapus data anda dapat klik kolom \r\nsebelah kiri lalu tekan \"" +
    "delete\" di keyboard .";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Update_Mhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dgMhs);
            this.Controls.Add(this.label1);
            this.Name = "Update_Mhs";
            this.Text = "Update_Mhs";
            ((System.ComponentModel.ISupportInitialize)(this.dgMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMhs;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label2;
    }
}