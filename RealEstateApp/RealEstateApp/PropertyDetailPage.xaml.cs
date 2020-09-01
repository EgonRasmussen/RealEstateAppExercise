using RealEstateApp.Models;
using RealEstateApp.Services;
using System.Linq;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyDetailPage : ContentPage
    {
        public PropertyDetailPage(PropertyListItem propertyListItem)
        {
            InitializeComponent();


        }


        private async void EditProperty_Clicked(object sender, System.EventArgs e)
        {

    }
}