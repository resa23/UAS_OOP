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
    public partial class View_Mhs : Form
    {
        public View_Mhs()
        {
            InitializeComponent();
        }

        // deklarasi variabel dsMhs dengan tipe dataset
        private DataSet dsMhs;
        public DataSet CreateMhsDataSet()
        {
            DataSet myDataSet = new DataSet();

            try
            {
                //string myConnectionString = "integrated security=true;data source=.;initial catalog=LAPTOP-PH1JF1U0\BELAJARIT\UAS";

                SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog=UAS;Integrated Security=True");

                SqlCommand myCommand = new SqlCommand();

                myCommand.Connection = myConnection;

                myCommand.CommandText = "SELECT * FROM ms_mhs";
                myCommand.CommandType = CommandType.Text;

                SqlDataAdapter myDataAdapter = new SqlDataAdapter();

                myDataAdapter.SelectCommand = myCommand;
                myDataAdapter.TableMappings.Add("Table", "Mahasiswa");

                myDataAdapter.Fill(myDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return myDataSet;
        }

        private void RefreshDataset()
        {
            dsMhs = CreateMhsDataSet();

            dgMhs.DataSource = dsMhs.Tables["Mahasiswa"];
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }
    }
}
