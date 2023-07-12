using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App_menu;

public partial class TablasMultiplicar : ContentPage

{

    /// <summary>
    /// <Createdate>08/07/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>08/07/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un If el cual verificara si los datos introducidos son nulos o si los entry estan vacios</Lastmodificationdescription>
    /// <Lastmodificationautor>Ingrid Gabriel, Lorena Vásquez</Lastmodificationautor>
    /// </summary>


    /// <summary>Constructor de la clase</summary>
    
    public TablasMultiplicar()

	{

		InitializeComponent();

	}
    /// <summary>En el evento del boton se se imprimiran las tablas de multiplicar teniendo como delimitante hasta la del numero 10</summary>

    private void OnCounterClicked(object sender, EventArgs e)

    {
        // Creamos un if el cual se encarga de que no allan valores nulos o casillas vacias y si es asi este imprime un mensaje de error //

        if (!string.IsNullOrEmpty(numero.Text))

        {

            // Declaramos las variable x, que sera la encaragada de expresar las tablas de multiplicar //

            int x = 0;

            // Declaramos la variable N, esta se encargara de almacenar el numero ingresado en la propiedad text del Entry "numero" //

            int N = Int32.Parse(numero.Text);

            while (x < 10)

            {

                x++;

                // Imprimimos las tablas de multiplicar solicitadas //

                DisplayAlert("Tabla de multiplicar:", N + "X" + x + "=" + (N * x), "Aceptar");

            }

            DisplayAlert("Error", "Ocurrio un error con el dato introducido", "Aceptar");

        }
    }

}
