using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDelivery.Pages.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaMasterMaster : ContentPage
    {
        public ListView ListView;

        public PaginaMasterMaster()
        {
            InitializeComponent();

            BindingContext = new PaginaMasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        class PaginaMasterMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PaginaMasterMenuItem> MenuItems { get; set; }

            public PaginaMasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<PaginaMasterMenuItem>(new[]
                {
                    new PaginaMasterMenuItem { Id = 0, Title = "Page 1" },
                    new PaginaMasterMenuItem { Id = 1, Title = "Page 2" },
                    new PaginaMasterMenuItem { Id = 2, Title = "Page 3" },
                    new PaginaMasterMenuItem { Id = 3, Title = "Page 4" },
                    new PaginaMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}