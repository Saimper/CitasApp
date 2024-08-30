using Microsoft.Maui.Controls;
using System;
namespace CitasApp.Pages;

public partial class CuartoPage : ContentPage
{
	public CuartoPage(string fechaIngresada, string specialty, string doctor)
	{
		InitializeComponent();


        dateLabel.Text = $"Fecha: {fechaIngresada}";
        specialtyLabel.Text = $"Especialidad: {specialty}";
        doctorLabel.Text = $"Médico: {doctor}";

    }

    private async void OnAcceptClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuintoPage());

    }
}