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
using System.Text.RegularExpressions;

namespace UAS_OOP_1204053
{
    public partial class Program_Studi : Form
    {
        public Program_Studi()
        {
            InitializeComponent();

            string getLastIdSql = "SELECT kode_prodi FROM ms_prodi ORDER BY kode_prodi DESC";

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT;Initial Catalog=UAS;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();

            string newProdi = "";
            if (result.HasRows)
            {
                int newKodeProdi = 0;
                while (result.Read())
                {
                    newProdi = result["kode_prodi"].ToString();
                    string angkaKode = Regex.Match(newProdi, @"\d+").Value;
                    newKodeProdi = Int16.Parse(angkaKode) + 1;
                    if (newKodeProdi >= 10)
                    {
                        newProdi = "PRD" + newKodeProdi;
                    }
                    else
                    {
                        newProdi = "PRD0" + newKodeProdi;
                    }
                    break;
                }
            }
            else
            {
                newProdi = "PRD01";
            }
            txtKode.Text = newProdi;
        }

        private void Btsubmit_Click(object sender, EventArgs e)
        {
      
            string myCmd = "INSERT INTO ms_prodi VALUES('"
            + txtKode.Text + "','"
            + txtNama.Text + "','"
            + txtSingkatan.Text + "','"
            + txtBiaya.Text + "')";

            UpdateDB(myCmd);
        }


        private void UpdateDB(string cmd)
        {
            try
            {
            
                SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog =UAS; Integrated Security = True");
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Data Prodi berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtSingkatan.Text = "";
            txtBiaya.Text = "";
        }

        private void txtBiaya_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtBiaya_Leave(object sender, EventArgs e)
        {

        }
    }
} 
