namespace VarlamovPrr4;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
        
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (x1.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Пежо\nСтрана производителя - Франция", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        if (x2.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Лада\nСтрана производителя - Россия", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
    {
        if (x3.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Рено\nСтрана производителя - Франция", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
    {
        if (x4.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Нива\nСтрана производителя - СССР", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_4(object sender, CheckedChangedEventArgs e)
    {
        if (x5.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Форд\nСтрана производителя - США", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_5(object sender, CheckedChangedEventArgs e)
    {
        if (x6.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Вольво\nСтрана производителя - Швеция", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_6(object sender, CheckedChangedEventArgs e)
    {
        if (x7.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - БМВ\nСтрана производителя - Германия", "Ок");
        }
    }

    private void RadioButton_CheckedChanged_7(object sender, CheckedChangedEventArgs e)
    {
        if (x8.IsChecked)
        {
            DisplayAlert("Сообщение", "Марка - Мерседес\nСтрана производителя - Германия", "Ок");
        }
    }
}