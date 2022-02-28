using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_OOP_1204053
{
    public partial class Daftar_ulang : Form
    {
        public Daftar_ulang()
        {
            InitializeComponent();
        }

        private void txtNPM_Leave(object sender, EventArgs e)
        {
            string getLastIdSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
                "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + txtNPM.Text + "'";

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT\UAS;Initial Catalog=UAS;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    txtNama.Text = result["nama_mhs"].ToString();
                    txtProdi.Text = result["nama_prodi"].ToString();
                    tbBiaya.Text = result["biaya_kuliah"].ToString();
                }
            }
        }
        private void inputDB(string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT;Initial Catalog=UAS;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Data SUKSES !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (txtNPM.Text != "")
            {
                if (txtPotongan.Text != "")
                {
                    if (rbGradeA.Checked != false || rbGradeB.Checked != false || rbGradeC.Checked != false)
                    {
                        string grade = "";
                        if (rbGradeA.Checked)
                        {
                            grade = "A";
                        }
                        if (rbGradeB.Checked)
                        {
                            grade = "B";
                        }
                        if (rbGradeC.Checked)
                        {
                            grade = "C";
                        }
                        string sql = "INSERT INTO tr_daftar_ulang VALUES('"
                            + txtNPM.Text + "','"
                            + grade + "','"
                            + txtPotongan.Text + "')";

                        inputDB(sql);

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("SILAHKAN PILIH GRADE NYA!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Harap isi potongan biaya kuliah mahasiswa!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("NPM harus diisi, tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(tbBiaya.Text.ToString()) * 50) / 100;
            txtPotongan.Text = diskon.ToString();
            int total = Int32.Parse(tbBiaya.Text.ToString()) - diskon;
            txtPotongan.Text = total.ToString();
        }

        private void rbGradeB_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(tbBiaya.Text.ToString()) * 25) / 100;
            txtPotongan.Text = diskon.ToString();
            int total = Int32.Parse(tbBiaya.Text.ToString()) - diskon;
            txtPotongan.Text = total.ToString();
        }

        private void rbGradeC_MouseClick(object sender, MouseEventArgs e)
        {

            int diskon = (Int32.Parse(tbBiaya.Text.ToString()) * 10) / 100;
            txtPotongan.Text = diskon.ToString();
            int total = Int32.Parse(tbBiaya.Text.ToString()) - diskon;
            txtPotongan.Text = total.ToString();
        } 

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
