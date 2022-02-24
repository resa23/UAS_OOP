namespace UAS_OOP_1204053
{
    partial class Bonus_Level
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
            this.label1 = new System.Windows.Forms.Label();
            this.Npm = new System.Windows.Forms.Label();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.NamaMhs = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lbProdi = new System.Windows.Forms.Label();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Mahasiswa";
            // 
            // Npm
            // 
            this.Npm.AutoSize = true;
            this.Npm.Location = new System.Drawing.Point(33, 125);
            this.Npm.Name = "Npm";
            this.Npm.Size = new System.Drawing.Size(191, 20);
            this.Npm.TabIndex = 1;
            this.Npm.Text = "NPM                                    :";
            this.Npm.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(230, 119);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(248, 26);
            this.txtNPM.TabIndex = 2;
            // 
            // NamaMhs
            // 
            this.NamaMhs.AutoSize = true;
            this.NamaMhs.Location = new System.Drawing.Point(33, 168);
            this.NamaMhs.Name = "NamaMhs";
            this.NamaMhs.Size = new System.Drawing.Size(190, 20);
            this.NamaMhs.TabIndex = 3;
            this.NamaMhs.Text = "Nama Mahasiswa             :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(229, 162);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(249, 26);
            this.txtNama.TabIndex = 4;
            // 
            // lbProdi
            // 
            this.lbProdi.AutoSize = true;
            this.lbProdi.Location = new System.Drawing.Point(33, 218);
            this.lbProdi.Name = "lbProdi";
            this.lbProdi.Size = new System.Drawing.Size(190, 20);
            this.lbProdi.TabIndex = 5;
            this.lbProdi.Text = "Program Studi                   :";
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "PRD01 ",
            "PRD02",
            "PRD03",
            "PRD04",
            "PRD05",
            "PRD06"});
            this.cbProdi.Location = new System.Drawing.Point(229, 215);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(249, 28);
            this.cbProdi.TabIndex = 6;
            this.cbProdi.Text = "---Pilih Kode program Studi---";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(124, 300);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 31);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(305, 298);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 35);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bonus_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 434);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.lbProdi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.NamaMhs);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.Npm);
            this.Controls.Add(this.label1);
            this.Name = "Bonus_Level";
            this.Text = "Bonus_Level";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Npm;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.Label NamaMhs;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lbProdi;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}