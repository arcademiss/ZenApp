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
    public partial class LeadearBoardForm : Form
    {
        private List<String> leaderboard;
        public LeadearBoardForm(List<String>leaderboard)
        {
            InitializeComponent();
            this.leaderboard = leaderboard;
            listLeaderboard.Items.Clear();
            foreach (string entry in leaderboard)
            {
                listLeaderboard.Items.Add(entry);
            }
        }
    }
}
