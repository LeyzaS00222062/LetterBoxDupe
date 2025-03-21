namespace LetterBoxDupe
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage(List<SearchMovieResults> results)
        {
            InitializeComponent();
            movieResultsPage.ItemsSource = results;
        }

        
    }
}
