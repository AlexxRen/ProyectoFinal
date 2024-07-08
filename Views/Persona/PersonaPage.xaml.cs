using ProyectoFinal.ViewModels;
using ProyectoFinal.ViewModels.Persona;

namespace ProyectoFinal.Views.Persona;

public partial class PersonaPage : ContentPage
{
	PersonaViewModel PersonaViewModel;
	public PersonaPage()
	{
		InitializeComponent();
		this.BindingContext = PersonaViewModel = new PersonaViewModel();
	}

}