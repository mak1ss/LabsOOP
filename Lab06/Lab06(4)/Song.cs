using Lab06_4_.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4_
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int songLength;
        public string ArtistName
        {
            get => artistName;
            set => artistName = value.Length >= 3 && value.Length <= 20 ? value : throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols");
        }

        public string SongName
        {
            get => songName;
            set => songName = value.Length >= 3 && value.Length <= 20 ? value : throw new InvalidSongNameException("Song name should be between 3 and 20 symbols");
        }

        public int SongLength
        {
            get => songLength;
        }
        public Song(string artistName, string songName, string songLength)
        {
            ArtistName = artistName;
            SongName = songName;
            SetSongLength(songLength);
        }

        private void SetSongLength(string songLength)
        {
            string[] input = songLength.Split(':');
            int res = int.Parse(input[0]) <= 14 && int.Parse(input[0]) >= 0 ? int.Parse(input[0]) * 60 : throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
            res += int.Parse(input[1]) <= 59 && int.Parse(input[0]) >= 0 ? int.Parse(input[1]) : throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            this.songLength = res;
        }
    }
}
