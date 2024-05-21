using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
namespace ZenAppClient
{
    public partial class Form1 : Form
    {
        ZenAppClient.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            
            InitializeComponent();
            labelZenPoints.Text = ZenPoints.ToString();
            update_RoundLabel();


        }


        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private String existingPath=null;
        private int ZenPoints = 1000;
        private int roundNumber = 1;

        private void buttonPlaySong_Click(object sender, EventArgs e)
        {  
           /// This function is called when the play song button is clicked. What happens is that the function retrieves
           /// a random song if one is not already selected and it is played.
           
            
            //Stop any song already playing

            waveOut?.Stop();
            waveOut?.Dispose();
            audioFileReader?.Dispose();

            String path = get_Song(); // here we will use the service to retrieve a song

            playSong(path, waveOut, audioFileReader);
        }

        private String get_Song()
        {

            /// Checks if the global path is null or not. If it is then it means that the user is on the first round
            /// If it is not null then it means the user is playing the same round and we just replay the song.
            String path2Song = "";
            if(existingPath != null)
                path2Song = existingPath;
            else
            {
                //TODO: path2Song=service.GetRandomSong
                path2Song = "C:\\an3\\s2\\II\\dwnl\\Creep [Explicit].mp4";
                existingPath = path2Song;
            }


            

            return path2Song;
        }

        private void playSong(String path, WaveOutEvent waveOut, AudioFileReader audioFileReader)
        {
            /// sets up the song player, plays the song and ticks a counter for 10 seconds
            try
            {
                //Init file reader and wave output
                audioFileReader = new AudioFileReader(path);
                waveOut = new WaveOutEvent();

                //play the audio file
                waveOut.Init(audioFileReader);
                waveOut.Play();

                // set a timer for 10 seconds

                Timer timer = new Timer();

                timer.Interval = 10000;
                timer.Tick += (s, args) =>
                {
                    waveOut.Stop();
                    timer.Stop();
                };
                timer.Start();
            }catch (Exception ex)
            {
                MessageBox.Show("Error playing audio file" + ex.Message);
            }

        }


        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            //1.Display message box, "Wow you suck!"
            

            MessageBox.Show("hAH KYS");


            //2.Decrease zen points
            ZenPoints = ZenPoints - roundNumber * 200;
            update_ZenPointsLabel(); // update zen points label
            //3. Increase the round count
            roundNumber++;
            //4a. If it is greater than 3 then ask the user for their name and finish the game.
            if(roundNumber > 3)
            {
                //TODO:Create form asking for name
                FormEndGame formEndGame = new FormEndGame(ZenPoints, service);
                formEndGame.ShowDialog();
                game_reset();
                //TODO: add name and points to database
                //when the data is sent to the database and the form is closed the game is also closed
            }
            update_RoundLabel();
            //4b.Pick a new song(set the global path to null).
        }

        private void game_reset()
        {
            ZenPoints = 1000;
            roundNumber = 1;
            update_ZenPointsLabel();
            update_RoundLabel();
        }

        private void update_RoundLabel()
        {
            labelRound.Text = "Round: " + roundNumber.ToString() + "/3";
        }

        private void update_ZenPointsLabel()
        {
            labelZenPoints.Text = ZenPoints.ToString();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            waveOut?.Stop();
            waveOut?.Dispose();
            audioFileReader?.Dispose();
            base.OnFormClosing(e);
        }
        
    }
}
