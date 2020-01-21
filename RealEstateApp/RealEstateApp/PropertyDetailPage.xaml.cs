using RealEstateApp.Models;
using RealEstateApp.Services;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyDetailPage : ContentPage
    {
        public PropertyDetailPage(Property property)
        {
            InitializeComponent();
            Property = property;

            IRepository MockRepository = TinyIoCContainer.Current.Resolve<IRepository>();
            Agent = MockRepository.GetAgents().FirstOrDefault(x => x.Id == Property.AgentId);

            BindingContext = this;
        }

        private Agent _agent;

        public Agent Agent
        {
            get => _agent;
            set
            {
                _agent = value;
                RaisePropertyChanged();
            }
        }

        private Property _property;

        public Property Property
        {
            get => _property;
            set
            {
                _property = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}