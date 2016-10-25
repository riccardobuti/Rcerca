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
    public partial class Frm_Edit : Form
    {
        public Frm_Edit()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Edit_Load(object sender, EventArgs e)
        {
            CaricaGeneri();
            lblId.Text = Preferenze.IdElemento.ToString();
            RicercaDB();
        }

        void RicercaDB()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Catalogo Where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Preferenze.IdElemento);

            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read()) { 
                txtPathFile.Text = dr["File"].ToString();
                txtAutore.Text = dr["Autore"].ToString();
                txtSoggetto.Text = dr["Soggetto"].ToString();
                txtTitolo.Text = dr["Titolo"].ToString();
                txtTag.Text = dr["Tag"].ToString();
                txtAutore.Text=dr["Autore"].ToString();
                cbGenere.Text = dr["Genere"].ToString();
                txtDurata.Text = dr["Durata"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["Mese"].ToString() + "/" + dr["Anno"].ToString());
                txtNote.Text = dr["Note"].ToString();

                }
            }


            con.Close();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            AggiornaDB();
            MessageBox.Show("AGGIORNATO!");
            this.Close();
        }

        void AggiornaDB()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("Update Catalogo SET Soggetto=@Soggetto, Titolo=@Titolo, Tag=@Tag, Autore=@Autore, Genere=@Genere, Durata=@Durata, Note=@Note Where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Preferenze.IdElemento);
            cmd.Parameters.AddWithValue("@Soggetto", txtSoggetto.Text);
            cmd.Parameters.AddWithValue("@Titolo", txtTitolo.Text);
            cmd.Parameters.AddWithValue("@Tag", txtTag.Text);
            cmd.Parameters.AddWithValue("@Autore", txtAutore.Text);
            cmd.Parameters.AddWithValue("@Genere", cbGenere.Text);
            cmd.Parameters.AddWithValue("@Durata", txtDurata.Text);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);
            cmd.ExecuteNonQuery();
            
        }
        void CaricaGeneri()
        {


            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();
            string query = "SELECT * FROM genere";
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
    }
}
