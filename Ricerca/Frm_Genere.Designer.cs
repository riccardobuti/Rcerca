namespace Ricerca
{
    partial class Frm_Genere
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGenere = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(478, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtGenere
            // 
            this.txtGenere.Location = new System.Drawing.Point(12, 389);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.Size = new System.Drawing.Size(227, 20);
            this.txtGenere.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(415, 421);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(75, 23);
            this.btnChiudi.TabIndex = 3;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nuovo genere:";
            // 
            // Frm_Genere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGenere);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Genere";
            this.Text = "Frm_Genere";
            this.Load += new System.EventHandler(this.Frm_Genere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGenere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Label label1;
    }
}