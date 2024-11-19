namespace TallerAPP;

public partial class PaginaAbsolut : ContentPage
{
	public PaginaAbsolut()
	{
		InitializeComponent();
	}

    private void Botion4_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaGrid());
    }
}