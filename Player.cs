using System;
using System.Collections.Generic;
using System.Threading;
using System.Media;

namespace MusGen
{
    class Player
    {
        private List<string[]> playlist;
        public Player(List<string[]> playlist)
        {
            this.playlist = playlist;
        }
        public void play()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            foreach (string[] symbol in playlist)
            {
                if (symbol[0] == "Pause")
                {
                    Thread.Sleep(125 * int.Parse(symbol[2]));
                }
                else
                {
                    soundPlayer.SoundLocation = $@"{Environment.CurrentDirectory}\res\{symbol[1]}\{symbol[0]}{symbol[2]}.wav";
                    soundPlayer.Load();
                    soundPlayer.PlaySync();
                }
            }
        }
    }
}
