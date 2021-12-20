using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using NAudio.Wave;

namespace MusGen
{
    public partial class MusGen : Form
    {
        public MusGen()
        {
            InitializeComponent();
        }
        private async void Play (Player player)
        {
            await Task.Run(() =>
            {
                player.play();
                if (checkBox1.Checked)
                {
                    capture.StopRecording();
                    if (outputFileName == null)
                        return;
                    var processStartInfo = new ProcessStartInfo
                    {
                        FileName = Path.GetDirectoryName(outputFileName),
                        UseShellExecute = true
                    };
                    Process.Start(processStartInfo);
                }
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tonality = new Tonality(comboBox1.SelectedIndex);
            playlist = new Playlist(tonality.getTonality());
            player = new Player(playlist.getPlaylist());
            if (checkBox1.Checked)
            {
                capture = new WasapiLoopbackCapture();
                var writer = new WaveFileWriter(outputFileName, capture.WaveFormat);
                capture.DataAvailable += async (s, ea) =>
                {
                    if (writer != null)
                    {
                        await writer.WriteAsync(ea.Buffer, 0, ea.BytesRecorded);
                        await writer.FlushAsync();
                    }
                };
                capture.RecordingStopped += (s, ea) =>
                {
                    if (writer != null)
                    {
                        writer.Dispose();
                        writer = null;
                    }
                    capture.Dispose();
                };
                capture.StartRecording();
            }
            Play(player);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && outputFileName == null)
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Wave files | *.wav";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
                outputFileName = dialog.FileName;
            }
        }
    }
}
