namespace gtipanexamen.Vistas;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}
    // Matriz de usuarios y contraseñas
    private string[,] usuarios = {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
        };
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtPassword.Text;

        // Validación de las credenciales ingresadas
        bool credencialesValidas = false;
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuario == usuarios[i, 0] && contraseña == usuarios[i, 1])
            {
                credencialesValidas = true;
                break;
            }
        }

        if (credencialesValidas)
        {
    
            DisplayAlert("Inicio de Sesión", $"Usuario conectado: {usuario}", "OK");

            // Navegar a la página 'home' y pasar el usuario como parámetro
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            // Mostrar alerta si las credenciales son incorrectas
            DisplayAlert("Inicio de Sesión", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro(App.usuarioConectado));
    }
}

