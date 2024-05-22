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
using System.IO;
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
                path2Song = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dwnl", "Alone.mp4");
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
            

            MessageBox.Show("Do you feel Zen?");


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
            existingPath = null;
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

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            /// This function fetches the leaderboard and displays it in a new form
            List<string> leaderboard = new List<string>
            {
                "1. Alice - 1500 points",
            "2. Bob - 1400 points",
            "3. Carol - 1300 points",
            "4. Dave - 1200 points",
            "5. Eve - 1100 points"
            };

            LeadearBoardForm leadearBoardForm = new LeadearBoardForm(leaderboard);
            leadearBoardForm.ShowDialog();
            //TODO: replace with service call and populate the list
        
            
        }

        private void button_Hint_Year_Click(object sender, EventArgs e)
        {
            button_Hint_Year.Enabled = false;
            MessageBox.Show("The year is " + "1970" + " or whatever.");// replace 1970 with service call
            ZenPoints -= 200;
            update_ZenPointsLabel();
        }

        private void button_Hint_Country_Click(object sender, EventArgs e)
        {
            button_Hint_Country.Enabled = false;
            MessageBox.Show("The country is " + "China" + " or nearby.");// replace China with service call
            ZenPoints -= 200;
            update_ZenPointsLabel();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            //0. Generate selection

            //the snipped bellow creats two radio button instances with the radio buttons containing our selection
            RadioButton selectedYear = groupYears.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            RadioButton selectedCountry = groupBoxCountries.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if(selectedYear == null || selectedCountry == null)//check if the user selected corectly
            {
                MessageBox.Show("Make sure you have selected both a country and an year!");
            }
            else
            {
                MessageBox.Show($"Selected: Country: {selectedCountry.Text} and Year: {selectedYear.Text}");
                String year = selectedYear.Text;
                String country = selectedCountry.Text;
                // 1.Check if the selection is correct(the value of both of the radio buttons)
                //2a.If correct then give passive agressive correct message using a service call and display it
                // then set the global song path to null. so that when the user presses play, a new song is played
                //also reset buttons.
                //also increase the round number
                //clear radio buttons
                //2b. If wrong then deduct points and the round keeps going
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Suggestion_Click(object sender, EventArgs e)
        {
            SubmitForm submitform = new SubmitForm();
            submitform.Show();
        }
    }
}
