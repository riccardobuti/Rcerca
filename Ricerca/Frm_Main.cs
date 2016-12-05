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
            CaricaGeneri();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            RicercaDB();
        }

        void RicercaDB()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();
            string cmd = "SELECT * FROM Catalogo Where Titolo like '%" + txtTitolo.Text + "%' and Soggetto like'%" + txtSoggetto.Text + "%' and Tag like'%" + txtTag.Text + "%' and Anno like'%" + txtAnno.Text + "%'" +
                         "and Mese like'%" + txtMese.Text + "%' and Luogo like'%" + txtLuogo.Text + "%' and Genere like'%" + cbGenere.Text + "%' and Note like'%" + txtNote.Text + "%'";

            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd, con);

            using (DataTable dt = new DataTable())
            {
               
                sda.Fill(dt);
                dgvRicerca.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("LA RICERCA NON HA PRODOTTO RISULTATI");
                }
            }
            


            con.Close();
            dgvRicerca.Columns["Id"].Visible = false;
        }

        private void dgvRicerca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
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
            else if (e.ColumnIndex == 1)
            {
                //prendi l'id e mettilo nella classe statica
                if (e.RowIndex >= 0)
                {
                    Preferenze.IdElemento = Convert.ToInt32(dgvRicerca.Rows[e.RowIndex].Cells["Id"].Value);
                }

                    //Apri il form
                    Frm_Edit fe = new Frm_Edit();
                fe.Show();
               

            }
            else if (e.ColumnIndex == 2)
            //ELIMINA
            {
                DialogResult elimina1 = MessageBox.Show("Hai richiesto l'eliminazione dell'elemento: " + dgvRicerca.Rows[e.RowIndex].Cells["Titolo"].Value.ToString() + " soggetto: " + dgvRicerca.Rows[e.RowIndex].Cells["Soggetto"].Value.ToString(), "ATTENZIONE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


                if (elimina1 == DialogResult.Yes)
                {
                    DialogResult elimina2 = MessageBox.Show("Hai confermato di procedere con l'eliminazione...PROCEDO CON L'ELIMINAZIONE TITOLO: " + dgvRicerca.Rows[e.RowIndex].Cells["Titolo"].Value.ToString() + " SOGGETTO: " + dgvRicerca.Rows[e.RowIndex].Cells["Soggetto"].Value.ToString(), "ELIMINO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                    if (elimina2 == DialogResult.Yes)
                    {
                        //Esegui eliminazione
                        if (e.RowIndex >= 0)
                        {
                            if (dgvRicerca.Rows[e.RowIndex].Cells["File"].Value.ToString() != null)
                            {


                                string percorso = Preferenze.pathSalvataggio + dgvRicerca.Rows[e.RowIndex].Cells["File"].Value.ToString();
                                if (File.Exists(percorso))
                                {
                                    //Elimina il file
                                    File.Delete(percorso);
                                    //Elimina il record nella tabella
                                    SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
                                    con.Open();
                                    SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Catalogo WHERE Id=@Id", con);
                                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRicerca.Rows[e.RowIndex].Cells["Id"].Value));
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception err)
                                    {
                                        MessageBox.Show(err.Message);
                                    }
                                    con.Close();
                                    dgvRicerca.Columns["Id"].Visible = false;
                                    MessageBox.Show("ELIMINATO");
                                    RicercaDB();
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("non c'è niente da eliminare");
                            }
                        }



                    }




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
            txtLuogo.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Genere fg = new Frm_Genere();
            fg.Show();
        }

        void CaricaGeneri()
        {
            try { 

            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();
            string query = "SELECT * FROM genere ORDER BY Genere ASC";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbGenere.Items.Add(dr["Genere"].ToString());

                }
            }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbGenere_DropDown(object sender, EventArgs e)
        {
            this.cbGenere.Items.Clear();
            CaricaGeneri();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
