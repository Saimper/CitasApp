namespace CitasApp.Pages;

public partial class SecoundPage : ContentPage
{
	public SecoundPage()
	{
		InitializeComponent();

	}

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
    private async void OnReserveClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TercerPage());
    }
 

    private void OnCancelClicked(object sender, EventArgs e)
    {
      
       
    }

  
}