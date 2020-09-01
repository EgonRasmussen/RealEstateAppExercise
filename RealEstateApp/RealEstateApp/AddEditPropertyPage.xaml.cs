using RealEstateApp.Models;
using RealEstateApp.Services;
using System.Collections.ObjectModel;
using System.Linq;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditPropertyPage : ContentPage
    {
        private IRepository Repository;

        #region PROPERTIES

        #endregion

        public AddEditPropertyPage(Property property = null)
        {
            InitializeComponent();

           
        }

        private async void SaveProperty_Clicked(object sender, System.EventArgs e)
        {
            
        }

        public bool IsValid()
        {
           
            return true;
        }

        private async void CancelSave_Clicked(object sender, System.EventArgs e)
        {
           
        }
    }
}