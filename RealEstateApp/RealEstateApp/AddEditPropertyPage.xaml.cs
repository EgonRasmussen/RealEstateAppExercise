using RealEstateApp.Services;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditPropertyPage : ContentPage
    {
        IRepository Repository;

        public AddEditPropertyPage()
        {
            InitializeComponent();

            Repository = TinyIoCContainer.Current.Resolve<IRepository>();
           
        }
    }
}