namespace gtipanexamen.Vistas;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}
    // Matriz de usuarios y contrase�as
    private string[,] usuarios = {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
        };
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtPassword.Text;

        // Validaci�n de las credenciales ingresadas
        bool credencialesValidas = false;
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuario == usuarios[i, 0] && contrase�a == usuarios[i, 1])
            {
                credencialesValidas = true;
                break;
            }
        }

        if (credencialesValidas)
        {
    
            DisplayAlert("Inicio de Sesi�n", $"Usuario conectado: {usuario}", "OK");

            // Navegar a la p�gina 'home' y pasar el usuario como par�metro
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            // Mostrar alerta si las credenciales son incorrectas
            DisplayAlert("Inicio de Sesi�n", "Usuario o contrase�a incorrectos", "OK");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro(App.usuarioConectado));
    }
}

