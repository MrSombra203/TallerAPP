namespace TallerAPP;

public partial class PaginaFlex : ContentPage
{
    public PaginaFlex()
    {
        InitializeComponent();
    }

    private void Imagen_Click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaAbsolut());
    }
}