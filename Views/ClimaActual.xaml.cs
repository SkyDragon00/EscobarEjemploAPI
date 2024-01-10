namespace EscobarEjemplo.Views;

public partial class ClimaActual : ContentPage
{
	public ClimaActual()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		string latitud = lat.Text;
        string longitud = lon.Text;

		if (Connectivity.NetworkAccess==NetworkAccess.Internet)
		{

		}
    }
}