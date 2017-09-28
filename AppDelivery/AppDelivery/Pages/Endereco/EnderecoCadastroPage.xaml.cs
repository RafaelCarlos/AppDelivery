using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppDelivery.Pages;
using AppDelivery.Pages.Menu;

namespace AppDelivery.Pages.Endereco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnderecoCadastroPage : ContentPage
    {
        public EnderecoCadastroPage()
        {
            InitializeComponent();
        }

        private void selecionarUFIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = ufCadastro.Items[ufCadastro.SelectedIndex];
            DisplayAlert(itemSelecionado, "Foi o item Selecionado", "OK");
        }

        private async void btCadastrarEndereco_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaMaster());
            //Navigation.InsertPageBefore(new HomePage(), this);
            //await Navigation.PushAsync();
        }
    }
}