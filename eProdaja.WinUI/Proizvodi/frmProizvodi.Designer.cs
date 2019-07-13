namespace eProdaja.WinUI.Korisnici
{
    partial class frmProizvodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbJedMjere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictutreBox = new System.Windows.Forms.PictureBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvProizvodiPoVrsti = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.Slika = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictutreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodiPoVrsti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta proizvoda";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(173, 72);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(322, 22);
            this.txtSifra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(173, 109);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(322, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cijena";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(173, 146);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 22);
            this.txtCijena.TabIndex = 7;
            // 
            // cmbJedMjere
            // 
            this.cmbJedMjere.FormattingEnabled = true;
            this.cmbJedMjere.Location = new System.Drawing.Point(374, 144);
            this.cmbJedMjere.Name = "cmbJedMjere";
            this.cmbJedMjere.Size = new System.Drawing.Size(121, 24);
            this.cmbJedMjere.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jed. mjere:";
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(173, 28);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(322, 24);
            this.cmbVrstaProizvoda.TabIndex = 10;
            this.cmbVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.CmbVrstaProizvoda_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(501, 182);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // pictutreBox
            // 
            this.pictutreBox.Location = new System.Drawing.Point(707, 35);
            this.pictutreBox.Name = "pictutreBox";
            this.pictutreBox.Size = new System.Drawing.Size(160, 147);
            this.pictutreBox.TabIndex = 12;
            this.pictutreBox.TabStop = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(707, 209);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(137, 55);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // dgvProizvodiPoVrsti
            // 
            this.dgvProizvodiPoVrsti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodiPoVrsti.Location = new System.Drawing.Point(7, 290);
            this.dgvProizvodiPoVrsti.Name = "dgvProizvodiPoVrsti";
            this.dgvProizvodiPoVrsti.RowTemplate.Height = 24;
            this.dgvProizvodiPoVrsti.Size = new System.Drawing.Size(961, 266);
            this.dgvProizvodiPoVrsti.TabIndex = 14;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(173, 183);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(322, 22);
            this.txtSlikaInput.TabIndex = 16;
            // 
            // Slika
            // 
            this.Slika.AutoSize = true;
            this.Slika.Location = new System.Drawing.Point(116, 183);
            this.Slika.Name = "Slika";
            this.Slika.Size = new System.Drawing.Size(38, 17);
            this.Slika.TabIndex = 15;
            this.Slika.Text = "Slika";
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 561);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.Slika);
            this.Controls.Add(this.dgvProizvodiPoVrsti);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.pictutreBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbVrstaProizvoda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbJedMjere);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.FrmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictutreBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodiPoVrsti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbJedMjere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVrstaProizvoda;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictutreBox;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvProizvodiPoVrsti;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label Slika;
    }
}