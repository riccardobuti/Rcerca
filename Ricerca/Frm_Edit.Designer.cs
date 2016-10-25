namespace Ricerca
{
    partial class Frm_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDataInserimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.cbGenere = new System.Windows.Forms.ComboBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtSoggetto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(550, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "MODIFICA";
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(611, 403);
            this.btnAggiorna.Margin = new System.Windows.Forms.Padding(2);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(95, 22);
            this.btnAggiorna.TabIndex = 24;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(13, 403);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(95, 22);
            this.btnAnnulla.TabIndex = 26;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtPathFile);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtDataInserimento);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.txtDurata);
            this.panel2.Controls.Add(this.cbGenere);
            this.panel2.Controls.Add(this.txtAutore);
            this.panel2.Controls.Add(this.txtTag);
            this.panel2.Controls.Add(this.txtTitolo);
            this.panel2.Controls.Add(this.txtSoggetto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 357);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "mm/aaaa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(88, 10);
            this.txtPathFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.ReadOnly = true;
            this.txtPathFile.Size = new System.Drawing.Size(374, 20);
            this.txtPathFile.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "File";
            // 
            // txtDataInserimento
            // 
            this.txtDataInserimento.Location = new System.Drawing.Point(374, 209);
            this.txtDataInserimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataInserimento.Name = "txtDataInserimento";
            this.txtDataInserimento.ReadOnly = true;
            this.txtDataInserimento.Size = new System.Drawing.Size(86, 20);
            this.txtDataInserimento.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Data inserimento";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(88, 235);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(374, 83);
            this.txtNote.TabIndex = 8;
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(88, 176);
            this.txtDurata.Margin = new System.Windows.Forms.Padding(2);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(86, 20);
            this.txtDurata.TabIndex = 6;
            // 
            // cbGenere
            // 
            this.cbGenere.FormattingEnabled = true;
            this.cbGenere.Location = new System.Drawing.Point(88, 148);
            this.cbGenere.Margin = new System.Windows.Forms.Padding(2);
            this.cbGenere.Name = "cbGenere";
            this.cbGenere.Size = new System.Drawing.Size(374, 21);
            this.cbGenere.TabIndex = 5;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(88, 121);
            this.txtAutore.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(374, 20);
            this.txtAutore.TabIndex = 4;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(88, 92);
            this.txtTag.Margin = new System.Windows.Forms.Padding(2);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(374, 20);
            this.txtTag.TabIndex = 3;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(88, 62);
            this.txtTitolo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(374, 20);
            this.txtTitolo.TabIndex = 2;
            // 
            // txtSoggetto
            // 
            this.txtSoggetto.Location = new System.Drawing.Point(88, 34);
            this.txtSoggetto.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoggetto.Name = "txtSoggetto";
            this.txtSoggetto.Size = new System.Drawing.Size(374, 20);
            this.txtSoggetto.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Durata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soggetto";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Crimson;
            this.lblId.Location = new System.Drawing.Point(11, 9);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 31);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID";
            // 
            // Frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 442);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Edit";
            this.Text = "Frm_Edit";
            this.Load += new System.EventHandler(this.Frm_Edit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDataInserimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.ComboBox cbGenere;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtSoggetto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
    }
}