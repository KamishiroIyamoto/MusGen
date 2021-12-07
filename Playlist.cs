using System;
using System.Collections.Generic;

namespace MusGen
{
    class Playlist
    {
        List<string[]> playlist = new List<string[]>();
        public Playlist(string[] tonality)
        {
            Random rnd = new Random();
            int dur = 2 * rnd.Next(0, 512);
            for (int i = 0; i < dur; i++)
            {
                int temp = rnd.Next(0, 8);
                string note = temp == 7 ? "Pause" : tonality[temp];
                string octave = rnd.Next(0, 2) == 0 ? "Small" : "One-line";
                string duration = rnd.Next(1, 5).ToString();

                playlist.Add(new string[] { note, octave, duration });
            }
        }
        public List<string[]> getPlaylist()
        {
            return playlist;
        }
    }
}