namespace gtipanexamen.Vistas;

public partial class Registro : ContentPage
{
    public Registro(string usuarioConectado)
    {
        InitializeComponent();

        
        lblUsuarioConectado.Text = $"Registro: {usuarioConectado}";

     
        pickerPais.Items.Add("ECUADOR");
        pickerPais.Items.Add("ESTADOS UNIDOS");
        pickerPais.Items.Add("");

   
        pickerCiudad.Items.Add("QUITO");
        pickerCiudad.Items.Add("lo");
        pickerCiudad.Items.Add("re");

       
        txtMontoInicial.TextChanged += CalcularPagoMensual;
    }


    private void CalcularPagoMensual(object sender, TextChangedEventArgs e)
    {
        if (double.TryParse(txtMontoInicial.Text, out double montoInicial))
        {
     
            double pagoMensual = montoInicial / 4;
            txtPagoMensual.Text = pagoMensual.ToString("C");
        }
        else
        {
            txtPagoMensual.Text = string.Empty;
        }
    }


    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;

        string resumen = $"Nombre: {nombre}\nApellido: {apellido}\nEdad: {edad}\n";
        resumen += $"Fecha: {dpFecha.Date}\nPaís: {pickerPais.SelectedItem}\nCiudad: {pickerCiudad.SelectedItem}\n";
        resumen += $"Monto Inicial: {txtMontoInicial.Text}\nPago Mensual: {txtPagoMensual.Text}";

        DisplayAlert("Resumen de Registro", resumen, "OK");
    }

  
}


