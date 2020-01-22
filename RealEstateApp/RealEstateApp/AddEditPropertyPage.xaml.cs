using RealEstateApp.Models;
using RealEstateApp.Services;
using RealEstateApp.Utils;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using TinyIoC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditPropertyPage : ContentPage
    {
        public ObservableCollection<Agent> Agents { get; }

        private IRepository MockRepository;

        #region CHANGE NOTIFICATION
        private Property _property;
        public Property Property
        {
            get => _property;
            set
            {
                _property = value;
                if (_property.AgentId != null)
                {
                    SelectedAgent = Agents.FirstOrDefault(x => x.Id == _property?.AgentId);
                }
               
                RaisePropertyChanged();
            }
        }
    
        private Agent _selectedAgent;

        public Agent SelectedAgent
        {
            get => _selectedAgent;
            set
            {
                if (_selectedAgent == value) return;
                if (Property != null)
                {
                    _selectedAgent = value;
                    Property.AgentId = _selectedAgent?.Id;
                }
                    
            }
        }

        private string _statusMessage;

        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                RaisePropertyChanged();
            }
        }

        private Color _statusColor = Color.White;

        public Color StatusColor
        {
            get => _statusColor;
            set
            {
                _statusColor = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChangedEvent;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public AddEditPropertyPage(Property property = null)
        {
            InitializeComponent();

            MockRepository = TinyIoCContainer.Current.Resolve<IRepository>();

            if (property == null)
            {
                Title = "Add Property";
                Property = new Property();
            }
            else
            {
                Title = "Edit Property";

            }

            Agents = new ObservableCollection<Agent>(MockRepository.GetAgents());
            BindingContext = this;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Property.Address)
                || Property.Beds == null
                || Property.Price == null
                || Property.AgentId == null)
                return false;

            return true;
        }

        private async void SaveProperty_Clicked(object sender, System.EventArgs e)
        {
            if (IsValid() == false)
            {
                StatusMessage = "Please fill in all required fields";
                StatusColor = Color.Red;
            }

            MockRepository.SaveProperty(Property);

            await Navigation.PopToRootAsync();
        }
    }
}