namespace HesapMakinesi;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
    private void OnRegisterClicked(object sender, EventArgs e)
    {
        // Kay�t i�lemlerini buraya yazabilirsiniz
        Navigation.PushAsync(new NewPage1 ());

    }
}