using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ricerca
{
    public partial class Frm_Preferenze : Form
    {
        public Frm_Preferenze()
        {
            InitializeComponent();
            //leggi i path
            //textBox1.Text = File.ReadAllText(Environment.CurrentDirectory + "\\settings\\pathSalvataggio.txt");
            //textBox2.Text = File.ReadAllText(Environment.CurrentDirectory + "\\settings\\pathDb.txt");
            textBox1.Text = Preferenze.pathSalvataggio;
            textBox2.Text = Preferenze.pathDb;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Chiamo il metodo update sul file di configurazione xml
            File.WriteAllText(Environment.CurrentDirectory + "\\settings\\pathSalvataggio.txt", textBox1.Text);
            File.WriteAllText(Environment.CurrentDirectory + "\\settings\\pathDb.txt", textBox2.Text);

            Preferenze.LoadPath();
            MessageBox.Show("Salvato");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Scelgo il percorso per archiviare i file dalla radice indicata
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //scelgo il percorso per accedere al database

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox2.Text = fbd.SelectedPath;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Copia nel percorso un nuovo database vuoto per inizializzare il sistema
            MessageBox.Show("Attenzione stai creando un nuovo archivio ?");


            string fileName = "ricerca_db.sqlite";
            string sourcePath = Environment.CurrentDirectory + "\\default\\";
            string targetPath = textBox2.Text;

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            try
            {
                System.IO.File.Copy(sourceFile, destFile, true);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_Preferenze_Load(object sender, EventArgs e)
        {

        }
    }
}
