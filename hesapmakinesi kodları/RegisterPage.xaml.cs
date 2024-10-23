namespace HesapMakinesi;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
    private void OnRegisterClicked(object sender, EventArgs e)
    {
        // Kayýt iþlemlerini buraya yazabilirsiniz
        Navigation.PushAsync(new NewPage1 ());

    }
}