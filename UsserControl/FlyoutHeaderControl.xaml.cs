namespace ProyectoFinal.UsserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if (App.fZT != null)
		{
			LblUserName.Text="Inicio Sesion in as: " + App.fZT;
			LblUserEmail.Text = App.fZT.user;
		}
	}
}