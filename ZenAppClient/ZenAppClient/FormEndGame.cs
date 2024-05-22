using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenAppClient
{
    public partial class FormEndGame : Form
    {
        private int ZenPoints;
        private ZenAppClient.ServiceReference1.WebService1SoapClient service;
        public FormEndGame(int ZenPoints, ZenAppClient.ServiceReference1.WebService1SoapClient service)
        {
            InitializeComponent();
            labelZenScore.Text = ZenPoints.ToString();
            this.ZenPoints = ZenPoints;
            this.service = service;
        }

        private void buttonSubmitScore_Click(object sender, EventArgs e)
        {
            int score = get_score();
            String name = get_username();
            if (name == "")
            {
                MessageBox.Show("Don't be shy, it's your score! Input your name.");
            }
            else
            {

                //MessageBox.Show("Score " + score.ToString() + " Name " + name);
                service.UpdatePoints(get_username(), get_score());
                this.Close();
            }
                


            }

        private String get_username()
        {
            String name;
            name = textUsername.Text;
            return name;
        }

        private int get_score()
        {
            return ZenPoints;
        }

        private void FormEndGame_Load(object sender, EventArgs e)
        {

        }
    }
}
