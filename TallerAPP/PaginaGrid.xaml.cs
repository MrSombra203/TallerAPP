namespace TallerAPP;

public partial class PaginaGrid : ContentPage
{
	public PaginaGrid()
	{
		InitializeComponent();
	}

    private void Botion1_Clicked2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaStack());
    }
    private void Botion1_Clicked3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaStack());
    }
    private void Botion1_Clicked4(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaStack());
    }
    private void Botion1_Clicked5(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaStack());
    }
}