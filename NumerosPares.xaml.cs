namespace App_menu;

public partial class NumerosPares : ContentPage

{

    /// <summary>
    /// <Createdate>7/7/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>7/7/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un DisplayAlert que imprime los numeros pares</Lastmodificationdescription>
    /// <Lastmodificationautor>Lorena Vazquez,Nery Méndez</Lastmodificationautor>
    /// </summary>

    /// <summary>Constructor de la clase</summary>
    
    public NumerosPares()

	{

		InitializeComponent();

	}

    private void Mostrar_Clicked(object sender, EventArgs e)

    {

        // Declaramos las variables correspondientes y realizamos la operación //

        int x = 0;

        while (x < 100)

        {

            x++;

            x = x + 1;

            DisplayAlert("Los numeros pares son:", x.ToString(), "Aceptar");

        }

    }

}