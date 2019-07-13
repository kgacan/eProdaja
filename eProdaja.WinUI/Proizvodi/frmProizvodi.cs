using eProdaja.Model.Requests;
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

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmProizvodi : Form
    {

        APIService _jediniceMjere = new APIService("JediniceMjere");
        APIService _vrstaProizvoda = new APIService("VrstaProizvoda");
        APIService _proizvodi = new APIService("Proizvod");
        public frmProizvodi()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private async void FrmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadJediniceMjere();
            await LoadVrsteProizvoda();
        }

        private async Task LoadVrsteProizvoda()
        {
            var result = await _vrstaProizvoda.Get<List<Model.Requests.VrsteProizvoda>>(null);
            result.Insert(0, new Model.Requests.VrsteProizvoda());
            cmbVrstaProizvoda.DisplayMember = "Naziv";
            cmbVrstaProizvoda.ValueMember = "VrstaId";
            cmbVrstaProizvoda.DataSource = result;

        }
        private async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjere.Get<List<Model.Requests.JediniceMjere>>(null);
            result.Insert(0, new Model.Requests.JediniceMjere());
            cmbJedMjere.DisplayMember = "Naziv";
            cmbJedMjere.ValueMember = "JedinicaMjereId";
            cmbJedMjere.DataSource = result;
        }

        private async void CmbVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaProizvoda.SelectedValue;

            if(int .TryParse(idObj.ToString(),out int id))
            {
                await LoadProizvodi(id);
            }
        }

        public async Task LoadProizvodi(int VrstaId)
        {
            var result = await _proizvodi.Get<List<Model.Proizvod>>(new ProizvodiSearchRequest { VrstaId = VrstaId });

            dgvProizvodiPoVrsti.DataSource = result;
        }

        ProizvodUpsertRequest request = new ProizvodUpsertRequest();

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {

            var idObj = cmbVrstaProizvoda.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int vrstaId))
            {
                request.VrstaId = vrstaId;
            }

            var jedMjereidObj = cmbJedMjere.SelectedValue;

            if (int.TryParse(jedMjereidObj.ToString(), out int jedinicaMjereId))
            {
                request.JedinicaMjereId = jedinicaMjereId;
            }

            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;
            request.Cijena = int.Parse(txtCijena.Text.ToString());

            await _proizvodi.Insert<Model.Proizvod>(request);

        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;

                txtSlikaInput.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictutreBox.Image = image;

            }
        }
    }
}
