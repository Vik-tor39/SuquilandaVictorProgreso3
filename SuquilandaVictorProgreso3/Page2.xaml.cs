namespace SuquilandaVictorProgreso3;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
		BindingContext = new AeropuertoViewModel(DependencyService.Get<IAeropuertoRepository>());
    }
}