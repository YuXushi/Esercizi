namespace Esercizi_MAUI_6._0;

public partial class MatematicaView : ContentPage
{
	public MatematicaView()
	{
		InitializeComponent();
	}

	private async void Calcolo(object sender, EventArgs e)
	{
		try
		{
			double a, b, c, x1 = 0, x2 = 0;
			string messaggio = "";
			a = Convert.ToDouble(txtA.Text); 
			b = Convert.ToDouble(txtB.Text); 
			c = Convert.ToDouble(txtC.Text); 
			Matematica.Equazione2Grado(a, b, c, ref messaggio, ref x1, ref x2 );
			await App.Current.MainPage.DisplayAlert("Risultato", messaggio, "Ok");
			if (messaggio != "Non ammette radici reali")
			{
				string risultatoRadici = $"x1 = {x1}, x2 = {x2}";
				await App.Current.MainPage.DisplayAlert("Radici:", risultatoRadici, "Ok");
			}
			Thread.Sleep(5000);
			txtA.Text = "";
			txtB.Text = "";
			txtC.Text = "";
		}
		catch (Exception ex)
		{
			await App.Current.MainPage.DisplayAlert("Errore", ex.Message, "OK");
		}
	}

	private void Reset(object sender, EventArgs e)
	{
        txtA.Text = "";
        txtB.Text = "";
        txtC.Text = "";
    }
}
