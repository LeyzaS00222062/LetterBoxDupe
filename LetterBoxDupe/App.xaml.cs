namespace LetterBoxDupe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            VersionTracking.Track();
      
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MoviePage());
        }
    }
}