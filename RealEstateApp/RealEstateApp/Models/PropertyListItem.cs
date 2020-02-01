using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealEstateApp.Models
{
    // Her kunne vi også have benyttet Fody og blot tilføjet følgende property: [AddINotifyPropertyChangedInterface]
    public class PropertyListItem : INotifyPropertyChanged
    {
        public PropertyListItem(Property property)
        {
            Property = property;
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
