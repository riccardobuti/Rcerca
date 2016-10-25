using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricerca
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Preferenze fp = new Frm_Preferenze();
            fp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Nuovo fn = new Frm_Nuovo();
            fn.Show();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Preferenze.LoadPath();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();
            string cmd = "SELECT * FROM Catalogo Where Titolo like '%" + txtTitolo.Text + "%' and Soggetto like'%" + txtSoggetto.Text + "%' and Tag like'%" + txtTag.Text + "%' and Anno like'%"+ txtAnno.Text +"%'";

            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd, con);

            using (DataTable dt = new DataTable())
            {
                sda.Fill(dt);
                dgvRicerca.DataSource = dt;
            }


            con.Close();
            dgvRicerca.Columns["Id"].Visible = false;

        }

        private void dgvRicerca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            if (dgvRicerca.Rows[e.RowIndex].Cells["File"].Value.ToString() != null)
            {


                string percorso = Preferenze.pathSalvataggio + dgvRicerca.Rows[e.RowIndex].Cells["File"].Value.ToString();
                if (File.Exists(percorso))
                {
                    Process.Start("explorer.exe", "/select, " + percorso);
                }
            }
            else
            {
                MessageBox.Show("non c'è niente da aprire");
            }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAnno.Text = "";
            txtMese.Text = "";
            txtAutore.Text = "";
            txtDurata.Text = "";
            txtNote.Text = "";
            txtSoggetto.Text = "";
            txtTag.Text = "";
            txtTitolo.Text = "";
            cbGenere.Text = "";
        }
    }
}
