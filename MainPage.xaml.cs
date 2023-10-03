namespace VarlamovPrr4;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
        
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		DisplayAlert("О программе", "ФИО - Варламов Артём Александрович.\nНомер работы - 11.\nВведите номер марки и определите марку и страну-производителя.", "Ок");
	}
}

