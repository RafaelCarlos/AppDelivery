using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDelivery.Pages.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaMaster : MasterDetailPage
    {
        public PaginaMaster()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            /*
             *Esse comando serve para trocar o Fragment atual 
             Detail = Página desejada;
             *
             * Esse comando serve para fechar o NavigationDrawer, ao selecionar algum item do menu lateral
             *IsPresented = false;
             * 
             */
            var item = e.SelectedItem as PaginaMasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}