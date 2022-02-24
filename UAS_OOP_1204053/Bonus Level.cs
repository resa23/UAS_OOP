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
    public partial class Bonus_Level : Form
    {
        public Bonus_Level()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNPM.Text = null;
            txtNama.Text = null;
            cbProdi.SelectedIndex = 0;

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (txtNPM.Text != "" )
            {
                if (txtNama.Text != "")
                {
                       if (cbProdi.Text != "--Pilih Program Studi--")
                                    {
                                        string npm = txtNPM.Text;
                                        string nama = txtNama.Text;
                                        string prodi = cbProdi.Text;

                                        SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog=UAS;Integrated Security=True");
                                        string sql = "INSERT INTO ms_mhs ([npm],[nama_mhs],[kode_prodi]) VALUES (@npm,@nama,@kodeprodi)";

                                        using (SqlConnection Connection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog=UAS;Integrated Security=True"))
                                        {
                                            try
                                            {
                                                Connection.Open();

                                                using (SqlCommand command = new SqlCommand(sql, Connection))
                                                {
                                                    command.Parameters.Add("@npm", SqlDbType.VarChar).Value = npm;
                                                    command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama;
                                                    command.Parameters.Add("@kodeprodi", SqlDbType.VarChar).Value = prodi;

                                                    int rowsAdded = command.ExecuteNonQuery();
                                                    if (rowsAdded > 0)
                                                        MessageBox.Show("Data berhasil disimpan");
                                                    else
                                                        MessageBox.Show("Data tidak disimpan");

                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("ERROR:" + ex.Message);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Silahkan Pilih Program Studi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nama harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nama harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

        //membuat Method UpdateDB dengan Parameter cmd
        private void UpdateDB(string cmd)
        {
            try
            {
                // connection string digunakan untuk koneksi ke basisdata PRG2_XXXXXXX.
                //perhatikan data source berisi "." menunjukkan komputer localhost, 
                //pada kenyataannya Anda akan menggantinya dengan alamat IP komputer server basisdata
                //string connectionString = "Data Source=UAS;Initial Catalog=UAS;Integrated Security=True";

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
    }
}

