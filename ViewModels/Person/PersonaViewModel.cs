using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProyectoFinal.Views.Persona;

namespace ProyectoFinal.ViewModels.Persona
{
    public partial class PersonaViewModel : ObservableObject 
    {
        public IRelayCommand AddPersonaCommand { get; }

        public PersonaViewModel()
        {
            AddPersonaCommand = new RelayCommand(OnAddPersona);
        }


        private async void OnAddPersona()
        {
            await Shell.Current.GoToAsync(nameof(AddPersonsaPage));
        }
    }
}
