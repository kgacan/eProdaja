using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class ProizvodiViewModel : BaseViewModel
    {
        APIService _proizvodiService = new APIService("Proizvod");
        APIService _vrstePorizvodaService = new APIService("VrstaProizvoda");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Proizvod> ProizvodiList { get; set; } = new ObservableCollection<Proizvod>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();

        VrsteProizvoda _selectedVrsteProizvoda = null;
        public VrsteProizvoda selectedVrsteProizvoda
        {
            get { return _selectedVrsteProizvoda; }
            set {
                    SetProperty(ref _selectedVrsteProizvoda, value);
                    InitCommand.Execute(null);
                }
        }

        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            if (VrsteProizvodaList.Count() == 0)
            {
                var vrsteProizvodaList = await _vrstePorizvodaService.Get<List<VrsteProizvoda>>(null);

                foreach (var vrsteProizvoda in vrsteProizvodaList)
                {
                    VrsteProizvodaList.Add(vrsteProizvoda);
                }
            }

            if (selectedVrsteProizvoda != null)
            {
                ProizvodiSearchRequest search = new ProizvodiSearchRequest();
                search.VrstaId = selectedVrsteProizvoda.VrstaId;


                var list = await _proizvodiService.Get<IEnumerable<Proizvod>>(search);

                ProizvodiList.Clear(); 
                foreach (var proizvod in list)
                {
                    ProizvodiList.Add(proizvod);
                }
            }

        }
    }
}
