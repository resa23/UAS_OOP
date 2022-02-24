namespace UAS_OOP_1204053
{
    partial class Update_Prodi
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
            this.dgProdi = new System.Windows.Forms.DataGridView();
            this.btUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Data Program Studi";
            // 
            // dgProdi
            // 
            this.dgProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdi.Location = new System.Drawing.Point(54, 96);
            this.dgProdi.Name = "dgProdi";
            this.dgProdi.RowTemplate.Height = 28;
            this.dgProdi.Size = new System.Drawing.Size(621, 349);
            this.dgProdi.TabIndex = 1;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(292, 482);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(153, 43);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // Update_Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 589);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dgProdi);
            this.Controls.Add(this.label1);
            this.Name = "Update_Prodi";
            this.Text = "Update_Prodi";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProdi;
        private System.Windows.Forms.Button btUpdate;
    }
}