namespace VarlamovPrr4;

public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string name = marka.Text.ToString();
        
        switch (name)
        {
            case "Пежо":
                DisplayAlert("Сообщение", "Марка - Пежо\nСтрана производителя - Франция", "Ок");
                break;

            case "Лада":
                DisplayAlert("Сообщение", "Марка - Лада\nСтрана производителя - Россия", "Ок");
                break;

            case "Рено":
                DisplayAlert("Сообщение", "Марка - Рено\nСтрана производителя - Франция", "Ок");
                break;

            case "Нива":
                DisplayAlert("Сообщение", "Марка - Нива\nСтрана производителя - СССР", "Ок");
                break;

            case "Форд":
                DisplayAlert("Сообщение", "Марка - Форд\nСтрана производителя - США", "Ок");
                break;

            case "Вольво":
                DisplayAlert("Сообщение", "Марка - Вольво\nСтрана производителя - Швеция", "Ок");
                break;

            case "БМВ":
                DisplayAlert("Сообщение", "Марка - БМВ\nСтрана производителя - Германия", "Ок");
                break;

            case "Мерседес":
                DisplayAlert("Сообщение", "Марка - Мерседес\nСтрана производителя - Германия", "Ок");
                break;

            default:
                DisplayAlert("Сообщение","Неизвестное имя","Ок");
                break;
        } 
    }
}