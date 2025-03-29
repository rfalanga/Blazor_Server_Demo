namespace Blazor_Hybrid_Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Blazor_Hybrid_Demo" };
        }
    }
}
