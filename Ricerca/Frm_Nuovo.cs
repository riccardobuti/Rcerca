using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Ricerca
{
    public partial class Frm_Nuovo : Form
    {
        public Frm_Nuovo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string anno;
            string mese;
            if (txtPathFile.Text == "")
            {
                MessageBox.Show("E' necessario selezionare un file per aggiungerlo all'archivio!");

            }
            else {

                anno = dateTimePicker1.Value.Date.Year.ToString();
                mese = dateTimePicker1.Value.Date.Month.ToString();

                if (anno == "")
            {
                MessageBox.Show("Il campo data non può rimanere vuoto");
            }
            else {
                    //Sposto il file nel catalogo

                    // src txtPathFile.Text
                    // dst Preferenze.pathSalvataggio + Anno + nome file
                    
            string filename = Path.GetFileNameWithoutExtension(txtPathFile.Text);
            string extension = Path.GetExtension(txtPathFile.Text);

                    //se la cartella con l'anno non esiste creala
                    System.IO.Directory.CreateDirectory(Preferenze.pathSalvataggio + "\\" + anno + "\\" + mese);
            string dst = "\\" + anno +"\\" + mese +"\\" + filename + DateTime.Now.Ticks.ToString() + extension;

                    //File.Copy(txtPathFile.Text, Preferenze.pathSalvataggio + dst);
                    FileSystem.CopyFile(txtPathFile.Text, Preferenze.pathSalvataggio + dst, UIOption.AllDialogs);

                    //Creo il record nel DB


                    SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/

            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Catalogo (Soggetto, Titolo, Tag, Autore, Genere, Durata, Anno, Mese, Note, File  ) VALUES (@Soggetto, @Titolo, @Tag, @Autore, @GenereId, @Durata, @Anno, @Mese,  @Note, @File)", con);
            cmd.Parameters.AddWithValue("@Soggetto", txtSoggetto.Text);
            cmd.Parameters.AddWithValue("@Titolo", txtTitolo.Text);
            cmd.Parameters.AddWithValue("@Tag", txtTag.Text);
            cmd.Parameters.AddWithValue("@Autore", txtAutore.Text);
            cmd.Parameters.AddWithValue("@GenereId", cbGenere.Text);
            cmd.Parameters.AddWithValue("@Durata", txtDurata.Text);
            cmd.Parameters.AddWithValue("@Anno", anno);
            cmd.Parameters.AddWithValue("@Mese", mese);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);
            cmd.Parameters.AddWithValue("@File", dst);


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.Close();
            //txtSoggetto.Text = "";
            //txtTitolo.Text = "";
            //txtTag.Text = "";
            MessageBox.Show("INSERITO");
            this.Close();

            }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathFile.Text = openFileDialog1.FileName;
            }
        }

        private void Frm_Nuovo_Load(object sender, EventArgs e)
        {
            txtDataInserimento.Text = DateTime.Now.ToShortDateString();
            CaricaGeneri();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
        }


            void CaricaGeneri()
        {
            

            SQLiteConnection con = new SQLiteConnection("Data Source=" + Preferenze.pathDb + "\\ricerca_db.sqlite" + ";Version=3;", true); /* New=False;Compress=True;");*/
            con.Open();
            string query = "SELECT * FROM genere";
            SQLiteCommand cmd =new SQLiteCommand(query, con);
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
