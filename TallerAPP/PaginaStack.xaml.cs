namespace TallerAPP;

public partial class PaginaStack : ContentPage
{
	public PaginaStack()
	{
		InitializeComponent();
	}

    private async void Botion3_Clicked(object sender, EventArgs e)
    {
        // Navega a la p�gina con FlexLayout
        await Navigation.PushAsync(new PaginaFlex());
    }
}