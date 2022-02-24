namespace UAS_OOP_1204053
{
    partial class Daftar_ulang
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
            this.lbNpm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.lbBiaya = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbGrade = new System.Windows.Forms.Label();
            this.rbGradeA = new System.Windows.Forms.RadioButton();
            this.rbGradeB = new System.Windows.Forms.RadioButton();
            this.rbGradeC = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPotongan = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Daftar Ulang Mahasiswa";
            // 
            // lbNpm
            // 
            this.lbNpm.AutoSize = true;
            this.lbNpm.Location = new System.Drawing.Point(68, 152);
            this.lbNpm.Name = "lbNpm";
            this.lbNpm.Size = new System.Drawing.Size(195, 20);
            this.lbNpm.TabIndex = 1;
            this.lbNpm.Text = "NPM                                     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Mahasiswa              :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Program Studi                    :";
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(274, 149);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(237, 26);
            this.txtNPM.TabIndex = 4;
            this.txtNPM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(274, 186);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(235, 26);
            this.txtNama.TabIndex = 5;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(274, 226);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(235, 26);
            this.txtProdi.TabIndex = 6;
            // 
            // lbBiaya
            // 
            this.lbBiaya.AutoSize = true;
            this.lbBiaya.Location = new System.Drawing.Point(68, 268);
            this.lbBiaya.Name = "lbBiaya";
            this.lbBiaya.Size = new System.Drawing.Size(195, 20);
            this.lbBiaya.TabIndex = 7;
            this.lbBiaya.Text = "Biaya Kuliah                        :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 26);
            this.textBox1.TabIndex = 8;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Location = new System.Drawing.Point(68, 305);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(197, 20);
            this.lbGrade.TabIndex = 9;
            this.lbGrade.Text = "Grade Seleksi                     :";
            // 
            // rbGradeA
            // 
            this.rbGradeA.AutoSize = true;
            this.rbGradeA.Location = new System.Drawing.Point(285, 313);
            this.rbGradeA.Name = "rbGradeA";
            this.rbGradeA.Size = new System.Drawing.Size(45, 24);
            this.rbGradeA.TabIndex = 10;
            this.rbGradeA.TabStop = true;
            this.rbGradeA.Text = "A";
            this.rbGradeA.UseVisualStyleBackColor = true;
            this.rbGradeA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbGradeB
            // 
            this.rbGradeB.AutoSize = true;
            this.rbGradeB.Location = new System.Drawing.Point(285, 355);
            this.rbGradeB.Name = "rbGradeB";
            this.rbGradeB.Size = new System.Drawing.Size(45, 24);
            this.rbGradeB.TabIndex = 11;
            this.rbGradeB.TabStop = true;
            this.rbGradeB.Text = "B";
            this.rbGradeB.UseVisualStyleBackColor = true;
            // 
            // rbGradeC
            // 
            this.rbGradeC.AutoSize = true;
            this.rbGradeC.Location = new System.Drawing.Point(285, 399);
            this.rbGradeC.Name = "rbGradeC";
            this.rbGradeC.Size = new System.Drawing.Size(45, 24);
            this.rbGradeC.TabIndex = 12;
            this.rbGradeC.TabStop = true;
            this.rbGradeC.Text = "C";
            this.rbGradeC.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Potongan Biaya                   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOTAL BIAYA KULIAH      :";
            // 
            // txtPotongan
            // 
            this.txtPotongan.Location = new System.Drawing.Point(276, 451);
            this.txtPotongan.Name = "txtPotongan";
            this.txtPotongan.Size = new System.Drawing.Size(233, 26);
            this.txtPotongan.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(276, 495);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(229, 26);
            this.txtTotal.TabIndex = 16;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(157, 576);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(106, 39);
            this.btSubmit.TabIndex = 17;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(336, 573);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(103, 44);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // Daftar_ulang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 679);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPotongan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbGradeC);
            this.Controls.Add(this.rbGradeB);
            this.Controls.Add(this.rbGradeA);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbBiaya);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNpm);
            this.Controls.Add(this.label1);
            this.Name = "Daftar_ulang";
            this.Text = "Daftar_ulang_Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNpm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.Label lbBiaya;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.RadioButton rbGradeA;
        private System.Windows.Forms.RadioButton rbGradeB;
        private System.Windows.Forms.RadioButton rbGradeC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPotongan;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btClear;
    }
}