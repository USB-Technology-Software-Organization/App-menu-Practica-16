namespace App_menu;

public partial class MainPage : ContentPage

{

    /// <summary>
    /// <Createdate>10/07/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>10/07/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se configuraron los eventos clic de las imagenbutton</Lastmodificationdescription>
    /// <Lastmodificationautor>Nery David,Kevin Silva</Lastmodificationautor>
    /// </summary>

    public MainPage()

    {

        InitializeComponent();

    }

    private void ImageButton_Clicked_NumerosPares(object sender, EventArgs e)

    {

        Navigation.PushAsync(new NumerosPares());

    }

    private void ImageButton_Clicked_CuentaRegresiva(object sender, EventArgs e)

    {

        Navigation.PushAsync(new CuentaRegresiva());

    }

    private void ImageButton_Clicked_TablasMultiplicar(object sender, EventArgs e)

    {

        Navigation.PushAsync(new TablasMultiplicar());

    }

    private void ImageButton_Clicked_SueldoSemanal(object sender, EventArgs e)

    {

        Navigation.PushAsync(new SueldoSemanal());

    }

    private void ImageButton_Clicked_LangostaAhumada(object sender, EventArgs e)

    {

        Navigation.PushAsync(new LangostaAhumada());

    }

    private void ImageButton_Clicked_AdquisicionDolares(object sender, EventArgs e)

    {

        Navigation.PushAsync(new AdquisicionDolares());

    }

    private void ImageButton_Clicked_Acerca(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Acerca());

    }

}

