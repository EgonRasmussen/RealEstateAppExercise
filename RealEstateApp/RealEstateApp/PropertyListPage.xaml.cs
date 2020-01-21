using RealEstateApp.Models;
using RealEstateApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealEstateApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyListPage : ContentPage
    {
        public List<Property> Properties { get; set; }

        IRepository _mockRepository;
        public PropertyListPage(IRepository mockRepository)
        {
            InitializeComponent();

            _mockRepository = mockRepository;

            Properties = _mockRepository.GetProperties();
            this.BindingContext = this;
        }
    }
}