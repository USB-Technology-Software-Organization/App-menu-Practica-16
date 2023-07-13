namespace App_menu;

public partial class SueldoSemanal : ContentPage

{

    /// <summary>
    /// <Createdate>7/7/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>7/7/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un If el cual verificara si los datos introducidos son nulos o si los entry estan vacios</Lastmodificationdescription>
    /// <Lastmodificationautor>Ingrid Jacqueline Gabriel Zepeda</Lastmodificationautor>
    /// </summary>

    /// <summary>Constructor de la clase</summary>

    ///<summary>
    ///Probando Commit
    /// </summary>
    public SueldoSemanal()

    {

        InitializeComponent();

	}

    /// <summary>En el evento del boton se calculará el sueldo semanalde un trabajador en base al pago por hora que recibe y la cantidad de horas trabajadas</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void Calcular_Clicked(object sender, EventArgs e)

    {

        if (!string.IsNullOrEmpty(PHEntry.Text) && (!string.IsNullOrEmpty(HTEntry.Text)))

        {

            // Declaramos las variables PH, HT, a las cuales se les asigna como valor la propiedad text del PHEntry y HTEntry correspondientemente //

            double PH = double.Parse(PHEntry.Text);

            double HT = double.Parse(HTEntry.Text);

            // Declaramos variable ST que su valor sera: ST = PH * HT, y se imprimira ST en un DisplayAlert //

            double ST = PH * HT;

            DisplayAlert("El sueldo total es:", ST.ToString(), "Aceptar");

        }

        else

        {

            DisplayAlert("Error", "Inserte los datos requeridos", "Aceptar");

        }

    }

}