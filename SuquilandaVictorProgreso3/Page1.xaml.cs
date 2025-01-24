namespace SuquilandaVictorProgreso3;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
		BindingContext = new BuscarAeropuertoViewModel(DependencyService.Get<IAeropuertoRepository>());
    }
}