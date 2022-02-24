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
    public partial class Program_Studi : Form
    {
        public Program_Studi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btsubmit_Click(object sender, EventArgs e)
        {
            //perintah SQL untuk menyimpan data inputan user ke basisdata 
            string myCmd = "INSERT INTO ms_prodi VALUES('"
            + txtKode.Text + "','"
            + txtNama.Text + "','"
            + txtSingkatan.Text + "','"
            + txtBiaya.Text + "')";
        

            //memanggil method UpdateDB dengan set parameter myCmd UpdateDB (myCmd);
            UpdateDB(myCmd);
        }

        //membuat Method UpdateDB dengan Parameter cmd
        private void UpdateDB(string cmd)
        {
            try
            {
                // connection string digunakan untuk koneksi ke basisdata PRG2_XXXXXXX.
                //perhatikan data source berisi "." menunjukkan komputer localhost, 
                //pada kenyataannya Anda akan menggantinya dengan alamat IP komputer server basisdata
                //string connectionString = "Data Source=UAS_OOP_1204053;Initial Catalog=UAS_OOP_1204053;Integrated Security=True";

                //membuat object dengan nama myConnection, inisialisasi dengan connection string
                SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog =UAS; Integrated Security = True");

                //mmebuka koneksi, menggunakan object myConnection 
                myConnection.Open();

                //membuat object dengan nama my Command, inisialisasi dari class SqlCommand
                SqlCommand myCommand = new SqlCommand();

                //menetapkan koneksi basisdata yang digunakan, yaitu object myConnection
                myCommand.Connection = myConnection;

                //mengatur query yang digunakan, diambil dari parameter cmd 
                myCommand.CommandText = cmd;

                //eksekusi myCommand yang diambil dari parameter cmd 
                myCommand.ExecuteNonQuery();

                //menampilkan pesan jika eksekusi berhasil
                MessageBox.Show("Basisdata berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //penanganan apabila terjadi error pada saat try, exception diset dalam variabel ex 
            catch (Exception ex)
            {
                //menampilkan pesan kesalahan 
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtClear_Click(object sender, EventArgs e)
        {

            //mengosongkan isian dalam TextBox 
            txtKode.Text = "";
            txtNama.Text = "";
            txtSingkatan.Text = "";
            txtBiaya.Text = "";
        }

        private void txtBiaya_Leave(object sender, EventArgs e)
        {
            if (txtBiaya.Text == "")
            {
                epWrong.SetError(txtBiaya, "Biaya tidak boleh kosong !");
            }
            else
            {
                epWrong.SetError(txtBiaya, "");
            }
        }
    }
}
