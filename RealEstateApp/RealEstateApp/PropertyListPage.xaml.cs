using RealEstateApp.Models;
using RealEstateApp.Services;
using System;
using System.Collections.ObjectModel;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyListPage : ContentPage
    {
        IRepository Repository;
        public ObservableCollection<PropertyListItem> PropertiesCollection { get; } = new ObservableCollection<PropertyListItem>(); 

        public PropertyListPage()
        {
            InitializeComponent();

            Repository = TinyIoCContainer.Current.Resolve<IRepository>();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


        }

        void OnRefresh(object sender, EventArgs e)
        {

        }

        void LoadProperties()
        {

        }

        private async void ItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private async void AddProperty_Clicked(object sender, EventArgs e)
        {

        }    
    }
}