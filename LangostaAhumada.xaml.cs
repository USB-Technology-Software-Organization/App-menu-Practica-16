namespace App_menu;

public partial class LangostaAhumada : ContentPage

{

    /// <summary>
    /// <Createdate>08/07/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>08/07/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un If el cual verificara si los datos introducidos son nulos o si los entry estan vacios</Lastmodificationdescription>
    /// <Lastmodificationautor>Lorena Lisseth Vazquez Godoy</Lastmodificationautor>
    /// </summary>

    /// <summary>Constructor de la clase</summary>

    public LangostaAhumada()

	{

		InitializeComponent();

	}

    private void Langosta_Clicked(object sender, EventArgs e)

    {

        if (!string.IsNullOrEmpty(PersonasEnry.Text))

        {

            // Declaramos las variables y les asignamos sus valores correspondientes //

            double Total;

            double personas = Convert.ToDouble(PersonasEnry.Text);

            // Creamos una condicion que nos diga que si la cantidad es menor a 200 el valor sea de 95, pero si este numero es mayor a 200 pero menor o igual a 300 el costo sea de 85, y si la cantidad es mayor a 300 el costo sea 75 //

            if (personas > 200 && personas <= 300)

            {

                Total = personas * 85.00;

            }

            else if (personas > 300)

            {

                Total = personas * 75.00;

            }

            else

            {

                Total = personas * 95.00;

            }

            // Imprimimos el resultado en un DisplayAlert utilizando el valor de la variable Total //

            DisplayAlert("La cantidad a pagar es:", Total.ToString(), "Aceptar");

        }

        DisplayAlert("Error", "Ingrese la cantidad de personas por favor, muchas gracias", "Cerrar");

    }

}