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
        public FormEndGame(int ZenPoints, ZenAppClient.ServiceReference1.WebService1SoapClient service)
        {
            InitializeComponent();
        }


    }
}
