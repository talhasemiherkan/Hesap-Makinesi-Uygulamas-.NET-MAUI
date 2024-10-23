namespace HesapMakinesi;

public partial class HesapMakinesi1 : ContentPage
{
    private double _ilksay�;
    private string _operasyon;
    private bool _s�f�rla;

    public HesapMakinesi1()
    {
        InitializeComponent();
    }

   
    private void OnNumberClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            if (_s�f�rla)
            {
                inputEntry.Text = string.Empty;
                _s�f�rla = false;
            }
            inputEntry.Text += button.Text;
        }
    }

  
    private void OnOperationClicked(object sender, EventArgs e)
    {
        if (double.TryParse(inputEntry.Text, out _ilksay�))
        {
            _operasyon = (sender as Button).Text; 
            inputEntry.Text = string.Empty; 
        }
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (double.TryParse(inputEntry.Text, out double ikincisayi))
        {
            double result = 0;

            
            switch (_operasyon)
            {
                case "+":
                    result = _ilksay� + ikincisayi;
                    break;
                case "-":
                    result = _ilksay� - ikincisayi;
                    break;
                case "*":
                    result = _ilksay� * ikincisayi;
                    break;
                case "/":
                    if (ikincisayi != 0)
                        result = _ilksay� / ikincisayi;
                    else
                        resultLabel.Text = "Bir say� s�f�ra b�l�nemez.";
                    return;
            }

            resultLabel.Text = $"Sonu�: {result}";
            _s�f�rla = true; 
        }
        else
        {
            resultLabel.Text = "L�tfen ge�erli bir say� girin.";
        }
    }

   
    private void OnClearClicked(object sender, EventArgs e)
    {
        inputEntry.Text = string.Empty;
        resultLabel.Text = string.Empty;
        _ilksay� = 0;
        _operasyon = string.Empty;
    }
}
