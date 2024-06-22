namespace gtipanexamen.Vistas;

public partial class Resumen : ContentPage
{
    public Resumen(string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string montoInicial, string pagoMensual)
    {
        InitializeComponent();

        // Mostrar Usuario Conectado (ejemplo estático)
        lblUsuarioConectado.Text = $"Usuario Conectado: NombreUsuario";

        // Mostrar datos en el resumen
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;
        lblMontoInicial.Text = montoInicial;
        lblPagoMensual.Text = pagoMensual;

        // Calcular y mostrar el Pago Total
        if (double.TryParse(montoInicial, out double monto))
        {
            if (double.TryParse(pagoMensual.Replace("$", ""), out double pagoMensualDouble))
            {
                double pagoTotal = monto + (pagoMensualDouble * 3); // Se asume 4 pagos en total
                lblPagoTotal.Text = pagoTotal.ToString("C");
            }
        }
    }
}

