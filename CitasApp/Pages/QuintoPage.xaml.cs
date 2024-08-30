namespace CitasApp.Pages;

public partial class QuintoPage : ContentPage
{
	public QuintoPage()
	{
		InitializeComponent();
	}

    private async void OnAcceptClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

}