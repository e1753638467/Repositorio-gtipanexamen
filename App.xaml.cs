namespace gtipanexamen
{
    public partial class App : Application
    {
        public static string usuarioConectado { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.login());
        }
    }
}
