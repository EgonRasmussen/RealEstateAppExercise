using RealEstateApp.Services;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyListPage : ContentPage
    {
        IRepository Repository;

        public PropertyListPage()
        {
            InitializeComponent();

            Repository = TinyIoCContainer.Current.Resolve<IRepository>();
        }
    }
}