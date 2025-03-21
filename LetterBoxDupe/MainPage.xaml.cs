namespace LetterBoxDupe
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SrchBrMovie.Text;

            List<SearchMovieResults> results = new List<SearchMovieResults>
            {
                new SearchMovieResults {Title = "{query}"}
            };

            Navigation.PushModalAsync(new MoviePage(results));

        }

    }

}
