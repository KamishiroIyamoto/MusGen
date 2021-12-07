using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusGen
{
    public partial class MusGen : Form
    {
        public MusGen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Tonality tonality = new Tonality(rnd.Next(1, 15));
            label1.Text = tonality.getTonal();
            Playlist playlist = new Playlist(tonality.getTonality());
            Player player = new Player(playlist.getPlaylist());
            player.play();
        }
    }
}
