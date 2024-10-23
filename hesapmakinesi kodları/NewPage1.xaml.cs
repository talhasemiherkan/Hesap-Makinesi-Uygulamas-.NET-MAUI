namespace HesapMakinesi;

public partial class NewPage1 : ContentPage // S�n�f ad� do�ru tan�mland�
{
    public NewPage1() // Constructor s�n�f ad�yla ayn� olmal�
    {
        InitializeComponent();
    }

    // Giri� butonuna t�klan�nca �al��acak metot
    private void OnLoginClicked(object sender, EventArgs e)
    {
        // Giri� i�lemleri
        // Burada basit bir kontrol yapabilirsiniz (�rne�in kullan�c� ad� ve �ifre kontrol�)

        // Kullan�c� giri�i ba�ar�l�ysa hesap makinesi ekran�na y�nlendirin
        Navigation.PushAsync(new HesapMakinesi1());
    }

    // Kay�t butonuna t�klan�nca �al��acak metot
    private void Kaydolma_Clicked(object sender, EventArgs e)
    {
        // Kaydolma i�lemlerini buraya yazabilirsiniz
        Navigation.PushAsync(new RegisterPage());
    }
}
