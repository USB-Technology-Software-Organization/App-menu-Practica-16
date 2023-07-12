namespace App_menu;

public partial class AdquisicionDolares : ContentPage

{

    /// <summary>
    /// <Createdate>08/07/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>08/07/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un If el cual verificara si los datos introducidos son nulos o si los entry estan vacios</Lastmodificationdescription>
    /// <Lastmodificationautor>Kevin Silva</Lastmodificationautor>
    /// </summary>

    ///<summary>Constructor de la clase</summary>

    public AdquisicionDolares()

	{

		InitializeComponent();

	}
    /// <summary>En el evento del boton se determinara cuantos dolares se pueden adquirir con una cantidad de pesos determinada </summary>

    private void Convertir_Clicked(object sender, EventArgs e)

    {

        // Creamos un if el cual se encarga de que no allan valores nulos o casillas vacias y si es asi este imprime un mensaje de error //

        if (!String.IsNullOrEmpty(peso.Text))

        {

            // Declaramos la variable P, la cual almacenara la cantidad de pesos //

            double P = double.Parse(peso.Text);

            // Declaramos la variable D, que su valor sera:  D = P * 0.058 //

            double D = P * 0.058;

            // Imprimimos el resultado en un DisplayAlert y mostramos el resultado de la variable D //

            DisplayAlert("La cantidad de dolares que se pueden adquirir es:", Convert.ToString(D), "Aceptar");

        }

        else

        {

            DisplayAlert("Error", "Introduce el campo", "Aceptar");

        }

    }

}