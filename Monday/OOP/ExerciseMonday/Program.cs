namespace ExerciseMonday
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Spotify playlist (exercise for lists)

            // Vi behöver songs class

            List<song1> songs = new List<song1>();
            song1.Title = "Song 1";
            song1.Artist = "Artist 1";
            song1.Duration = 138;

            List<song2> songs = new List<song2>();
            song2.Title = "Song 2";
            song2.Artist = "Artist 2";
            song2.Duration = 120;

            // songs lista

            List<Song> nazarsPlaylist = new List<Song>();
            nazarsPlaylist.Add(song1);
            nazarsPlaylist.Add(song2);

            foreach (var song in nazarsPlaylist)
            {
                Console.WriteLine($"Title: {song1.Title}, Artist: {song1.Artist}, Duration: {song1.Duration}");
            }
        }

    }
}
