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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program_Studi newChild = new Program_Studi();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mahasiswa newChild = new Mahasiswa();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Mhs newChild = new View_Mhs();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Prodi newChild = new View_Prodi();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void mahasiswaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Update_Mhs newChild = new Update_Mhs();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void prodiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Update_Prodi newChild = new Update_Prodi();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void daftarUlangMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daftar_ulang newChild = new Daftar_ulang();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void daftarUlangMahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Daftar_ulang_mhs newChild = new View_Daftar_ulang_mhs();
            newChild.MdiParent = this;
            newChild.Show();
        }
    }
}
