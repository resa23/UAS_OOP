namespace UAS_OOP_1204053
{
    partial class Program_Studi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program_Studi));
            this.label1 = new System.Windows.Forms.Label();
            this.KodeProdi = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.NamaProdi = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.Singkatan = new System.Windows.Forms.Label();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.Biaya = new System.Windows.Forms.Label();
            this.txtBiaya = new System.Windows.Forms.TextBox();
            this.Btsubmit = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Program Studi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KodeProdi
            // 
            this.KodeProdi.AutoSize = true;
            this.KodeProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeProdi.Location = new System.Drawing.Point(45, 144);
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.Size = new System.Drawing.Size(209, 22);
            this.KodeProdi.TabIndex = 1;
            this.KodeProdi.Text = "Kode Prodi                     :";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(256, 144);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(239, 26);
            this.txtKode.TabIndex = 2;
            // 
            // NamaProdi
            // 
            this.NamaProdi.AutoSize = true;
            this.NamaProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaProdi.Location = new System.Drawing.Point(45, 189);
            this.NamaProdi.Name = "NamaProdi";
            this.NamaProdi.Size = new System.Drawing.Size(209, 22);
            this.NamaProdi.TabIndex = 3;
            this.NamaProdi.Text = "Nama Prodi                    :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(256, 188);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(239, 26);
            this.txtNama.TabIndex = 4;
            // 
            // Singkatan
            // 
            this.Singkatan.AutoSize = true;
            this.Singkatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singkatan.Location = new System.Drawing.Point(45, 235);
            this.Singkatan.Name = "Singkatan";
            this.Singkatan.Size = new System.Drawing.Size(210, 22);
            this.Singkatan.TabIndex = 5;
            this.Singkatan.Text = "Singkatan                       :";
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(256, 235);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(238, 26);
            this.txtSingkatan.TabIndex = 6;
            // 
            // Biaya
            // 
            this.Biaya.AutoSize = true;
            this.Biaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biaya.Location = new System.Drawing.Point(49, 284);
            this.Biaya.Name = "Biaya";
            this.Biaya.Size = new System.Drawing.Size(205, 22);
            this.Biaya.TabIndex = 7;
            this.Biaya.Text = "Biaya Kuliah                  :";
            // 
            // txtBiaya
            // 
            this.txtBiaya.Location = new System.Drawing.Point(256, 286);
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(239, 26);
            this.txtBiaya.TabIndex = 8;
            this.txtBiaya.Leave += new System.EventHandler(this.txtBiaya_Leave);
            // 
            // Btsubmit
            // 
            this.Btsubmit.Location = new System.Drawing.Point(158, 368);
            this.Btsubmit.Name = "Btsubmit";
            this.Btsubmit.Size = new System.Drawing.Size(104, 34);
            this.Btsubmit.TabIndex = 9;
            this.Btsubmit.Text = "Submit";
            this.Btsubmit.UseVisualStyleBackColor = true;
            this.Btsubmit.Click += new System.EventHandler(this.Btsubmit_Click);
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(324, 370);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(108, 32);
            this.BtClear.TabIndex = 10;
            this.BtClear.Text = "Clear";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // Program_Studi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 434);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.Btsubmit);
            this.Controls.Add(this.txtBiaya);
            this.Controls.Add(this.Biaya);
            this.Controls.Add(this.txtSingkatan);
            this.Controls.Add(this.Singkatan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.NamaProdi);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.KodeProdi);
            this.Controls.Add(this.label1);
            this.Name = "Program_Studi";
            this.Text = "Program_Studi";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KodeProdi;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label NamaProdi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label Singkatan;
        private System.Windows.Forms.TextBox txtSingkatan;
        private System.Windows.Forms.Label Biaya;
        private System.Windows.Forms.TextBox txtBiaya;
        private System.Windows.Forms.Button Btsubmit;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}