namespace CitasApp.Pages;

public partial class TercerPage : ContentPage
{
    public TercerPage()
    {
        InitializeComponent();
    }
    private async void OnReserveClicked(object sender, EventArgs e)
    {
        // Obtener los datos de los controles
        string fechaIngresada = dateEntry.Text;
        string especialidadSeleccionada = specialtyPicker.SelectedItem?.ToString();
        string medicoSeleccionado = doctorPicker.SelectedItem?.ToString();

        // Validar que todos los campos estén llenos
        if (string.IsNullOrWhiteSpace(fechaIngresada) || string.IsNullOrWhiteSpace(especialidadSeleccionada) || string.IsNullOrWhiteSpace(medicoSeleccionado))
        {
            await DisplayAlert("Error", "Por favor, completa todos los campos antes de continuar.", "OK");
            return;
        }

        // Validar el formato de la fecha
        if (!DateTime.TryParseExact(fechaIngresada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
        {
            await DisplayAlert("Error", "Por favor, ingresa una fecha válida en el formato DD-MM-AAAA.", "OK");
            return;
        }

        // Navegar a CuartoPage pasando los datos como parámetros
        await Navigation.PushAsync(new CuartoPage(fechaIngresada, especialidadSeleccionada, medicoSeleccionado));
    }




}