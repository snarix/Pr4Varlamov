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
            DisplayAlert("���������", "����� - ����\n������ ������������� - �������", "��");
        }
    }

    private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        if (x2.IsChecked)
        {
            DisplayAlert("���������", "����� - ����\n������ ������������� - ������", "��");
        }
    }

    private void RadioButton_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
    {
        if (x3.IsChecked)
        {
            DisplayAlert("���������", "����� - ����\n������ ������������� - �������", "��");
        }
    }

    private void RadioButton_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
    {
        if (x4.IsChecked)
        {
            DisplayAlert("���������", "����� - ����\n������ ������������� - ����", "��");
        }
    }

    private void RadioButton_CheckedChanged_4(object sender, CheckedChangedEventArgs e)
    {
        if (x5.IsChecked)
        {
            DisplayAlert("���������", "����� - ����\n������ ������������� - ���", "��");
        }
    }

    private void RadioButton_CheckedChanged_5(object sender, CheckedChangedEventArgs e)
    {
        if (x6.IsChecked)
        {
            DisplayAlert("���������", "����� - ������\n������ ������������� - ������", "��");
        }
    }

    private void RadioButton_CheckedChanged_6(object sender, CheckedChangedEventArgs e)
    {
        if (x7.IsChecked)
        {
            DisplayAlert("���������", "����� - ���\n������ ������������� - ��������", "��");
        }
    }

    private void RadioButton_CheckedChanged_7(object sender, CheckedChangedEventArgs e)
    {
        if (x8.IsChecked)
        {
            DisplayAlert("���������", "����� - ��������\n������ ������������� - ��������", "��");
        }
    }
}