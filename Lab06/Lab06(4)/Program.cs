using Lab06_4_.Exceptions;
using Lab06_4_;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Song> songs = new List<Song>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] inputSong = Console.ReadLine().Split(';');
            try
            {
                songs.Add(new Song(inputSong[0], inputSong[1], inputSong[2]));
                Console.WriteLine("Song added");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine($"Songs added: {songs.Count}");
        int playlistLength = 0;
        songs.ForEach(s => playlistLength += s.SongLength);
        TimeSpan playlistDuration = TimeSpan.FromSeconds(playlistLength);
        Console.WriteLine($"Playlist Length : {playlistDuration}");
    }
}