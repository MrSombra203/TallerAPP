namespace TallerAPP;

public partial class PaginaGrid : ContentPage
{
	public PaginaGrid()
	{
		InitializeComponent();
	}

    private void Botion2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaStack());
    }
}