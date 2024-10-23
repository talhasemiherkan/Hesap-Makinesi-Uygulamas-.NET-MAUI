namespace HesapMakinesi;

public partial class NewPage1 : ContentPage // Sýnýf adý doðru tanýmlandý
{
    public NewPage1() // Constructor sýnýf adýyla ayný olmalý
    {
        InitializeComponent();
    }

    // Giriþ butonuna týklanýnca çalýþacak metot
    private void OnLoginClicked(object sender, EventArgs e)
    {
        // Giriþ iþlemleri
        // Burada basit bir kontrol yapabilirsiniz (örneðin kullanýcý adý ve þifre kontrolü)

        // Kullanýcý giriþi baþarýlýysa hesap makinesi ekranýna yönlendirin
        Navigation.PushAsync(new HesapMakinesi1());
    }

    // Kayýt butonuna týklanýnca çalýþacak metot
    private void Kaydolma_Clicked(object sender, EventArgs e)
    {
        // Kaydolma iþlemlerini buraya yazabilirsiniz
        Navigation.PushAsync(new RegisterPage());
    }
}
