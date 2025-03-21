namespace LetterBoxDupe
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SrchBrMovie.Text;

            List<SearchMovieResults> results = new List<SearchMovieResults>
            {
                new SearchMovieResults {Title = "Title", Description = "Description"}
            };

            Navigation.PushModalAsync(new MoviePage(results));

        }

    }

}
