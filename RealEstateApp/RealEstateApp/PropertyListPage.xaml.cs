using RealEstateApp.Models;
using RealEstateApp.Services;
using System.Collections.Generic;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyListPage : ContentPage
    {
        public List<Property> Properties { get; set; }  

        public PropertyListPage()
        {
            InitializeComponent();

            IRepository MockRepository = TinyIoCContainer.Current.Resolve<IRepository>();
            Properties = MockRepository.GetProperties();
            BindingContext = this;
        }

        private async void ItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new PropertyDetailPage(e.Item as Property));
        }
    }
}