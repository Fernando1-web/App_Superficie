namespace App_Superficie;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		int Base1, Altura1, Area;

		Base1 = Convert.ToInt32(Base.Text);
		Altura1 = Convert.ToInt32(Altura.Text);

		Area = (Base1 * Altura1) / 2;

		LblArea.Text = "El resultado es :" + Area + "cm^2";
    }
}

