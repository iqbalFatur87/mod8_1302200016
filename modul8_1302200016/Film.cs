namespace modul8_1302200016
{
    public class Film
    {
        // Database
        public static List<Film> Films = new List<Film>()
        {
            new Film() { Title = "The Shawshank Redemption", Director = "Frank Darabont" , Descriptions = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Stars = {"Tim R.", "Morgan F.", "Bob Gunton" } },
            new Film() { Title = "The GodFather", Director = "Francis Ford Coppola" , Descriptions = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", Stars = {"Marlon B.", "Al Pacino", "James Caan"} },
            new Film() { Title = "The Dark Knight", Director = "Christopher Nolan" , Descriptions = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", Stars = {"Christian B.", "Heath L.", "Aaron E."} }
        };

        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Descriptions { get; set; }

        public Film()
        {
            
        }
    }
}
