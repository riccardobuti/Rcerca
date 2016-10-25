using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricerca
{
    public partial class Frm_Genere : Form
    {
        public Frm_Genere()
        {
            InitializeComponent();
        }


        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Genere_Load(object sender, EventArgs e)
        {

            RicercaDB();
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void RicercaDB()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();
            string cmd = "SELECT * FROM Genere";

            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd, con);

            using (DataTable dt = new DataTable())
            {
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserisciDB();
        }

       void InserisciDB()
        {
            if (txtGenere.Text != "")
            {


                SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/

                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO genere (Genere) VALUES (@Genere)", con);
                cmd.Parameters.AddWithValue("@Genere", txtGenere.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("AGGIUNTO");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Il nome del genere non può essere vuoto");
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
