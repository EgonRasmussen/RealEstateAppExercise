using RealEstateApp.Models;
using RealEstateApp.Services;
using System.Collections.ObjectModel;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyListPage : ContentPage
    {
        IRepository MockRepository;
        public ObservableCollection<Property> Properties { get; set; }  

        public PropertyListPage()
        {
            InitializeComponent();

            MockRepository = TinyIoCContainer.Current.Resolve<IRepository>();
            Properties = new ObservableCollection<Property>(MockRepository.GetProperties());
            BindingContext = this; 
        }

        private async void ItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new PropertyDetailPage(e.Item as Property));
        }

        private async void AddProperty_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddEditPropertyPage());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Properties = new ObservableCollection<Property>(MockRepository.GetProperties());       
        }
    }
}