namespace HesapMakinesi;

public partial class HesapMakinesi1 : ContentPage
{
    private double _ilksayý;
    private string _operasyon;
    private bool _sýfýrla;

    public HesapMakinesi1()
    {
        InitializeComponent();
    }

   
    private void OnNumberClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            if (_sýfýrla)
            {
                inputEntry.Text = string.Empty;
                _sýfýrla = false;
            }
            inputEntry.Text += button.Text;
        }
    }

  
    private void OnOperationClicked(object sender, EventArgs e)
    {
        if (double.TryParse(inputEntry.Text, out _ilksayý))
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
                    result = _ilksayý + ikincisayi;
                    break;
                case "-":
                    result = _ilksayý - ikincisayi;
                    break;
                case "*":
                    result = _ilksayý * ikincisayi;
                    break;
                case "/":
                    if (ikincisayi != 0)
                        result = _ilksayý / ikincisayi;
                    else
                        resultLabel.Text = "Bir sayý sýfýra bölünemez.";
                    return;
            }

            resultLabel.Text = $"Sonuç: {result}";
            _sýfýrla = true; 
        }
        else
        {
            resultLabel.Text = "Lütfen geçerli bir sayý girin.";
        }
    }

   
    private void OnClearClicked(object sender, EventArgs e)
    {
        inputEntry.Text = string.Empty;
        resultLabel.Text = string.Empty;
        _ilksayý = 0;
        _operasyon = string.Empty;
    }
}
