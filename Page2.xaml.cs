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
            case "����":
                DisplayAlert("���������", "����� - ����\n������ ������������� - �������", "��");
                break;

            case "����":
                DisplayAlert("���������", "����� - ����\n������ ������������� - ������", "��");
                break;

            case "����":
                DisplayAlert("���������", "����� - ����\n������ ������������� - �������", "��");
                break;

            case "����":
                DisplayAlert("���������", "����� - ����\n������ ������������� - ����", "��");
                break;

            case "����":
                DisplayAlert("���������", "����� - ����\n������ ������������� - ���", "��");
                break;

            case "������":
                DisplayAlert("���������", "����� - ������\n������ ������������� - ������", "��");
                break;

            case "���":
                DisplayAlert("���������", "����� - ���\n������ ������������� - ��������", "��");
                break;

            case "��������":
                DisplayAlert("���������", "����� - ��������\n������ ������������� - ��������", "��");
                break;

            default:
                DisplayAlert("���������","����������� ���","��");
                break;
        } 
    }
}