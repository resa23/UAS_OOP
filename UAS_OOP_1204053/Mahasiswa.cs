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
    public partial class Mahasiswa : Form
    {
        public Mahasiswa()
        {
            InitializeComponent();

            SqlConnection connectDB = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT;Initial Catalog=UAS;Integrated Security=True");
            connectDB.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM ms_prodi", connectDB);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable tabel = new DataTable();
            tabel.Columns.Add("kode_prodi", typeof(string));
            tabel.Columns.Add("singkatan", typeof(string));
            tabel.Load(reader);

            cbProdi.ValueMember = "kode_prodi";
            cbProdi.DisplayMember = "singkatan";
            cbProdi.DataSource = tabel;

            connectDB.Close();
        }

        //membuat Method UpdateDB dengan Parameter cmd
        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT;Initial Catalog=UAS;Integrated Security=True");

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();

                myCommand.Connection = myConnection;

                myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();

                MessageBox.Show("SUKSES ! Data berhasil diinput!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int valid = 0;
            if (txtNPM.Text != "" && int.TryParse(txtNPM.Text.ToString(), out valid))
            {
                if (txtNama.Text != "" && !txtNama.Text.ToString().Any(char.IsDigit))
                {
                    //perintah SQL untuk menyimpan data inputan user ke basisdata 
                    string myCmd = "INSERT INTO ms_mhs VALUES('"
                    + txtNPM.Text + "','"
                    + txtNama.Text + "','"
                    + cbProdi.SelectedValue.ToString() + "')";

                    UpdateDB(myCmd);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Dimohon untuk mengisi nama dengan benar ! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Masukan NPM dengan angka , bukan huruf !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int valid = 0;
            txtNPM.Text = null;
            txtNama.Text = null;
            cbProdi.Text = "";

        }

    }
}

