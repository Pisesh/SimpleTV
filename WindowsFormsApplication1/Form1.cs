using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        TV newtv = new TV();
        bool Validator = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Btn_Power_TV_Click(object sender, EventArgs e)
        {
            newtv.Power();
            PowerButtonRefresh();
        }

        private void PowerButtonRefresh()
        {
            if (newtv.PowerStatus == true)
            {
                Btn_Power.BackColor = Color.Green;
                Btn_Power_TV.BackColor = Color.Green;
                Validator = true;
                Print();
            }
            else
            {
                Btn_Power.BackColor = Color.DarkRed;
                Btn_Power_TV.BackColor = Color.DarkRed;
                Validator = false;
                Clean();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TV_Label.Text = newtv.TV_Mark;
            TV_Model.Text = newtv.TV_Model;
        }

        private void Btn_Power_Click(object sender, EventArgs e)
        {
            newtv.Power();
            PowerButtonRefresh();
        }

        private void Print()
        {
            if (Validator == true)
            {
                Lbl_Channel.Text = Convert.ToString(newtv.ChannelStatus);
                Lbl_Volume.Text = Convert.ToString(newtv.VolumeStatus);
                Lbl_IsMute.Text = Convert.ToString(newtv.MuteStatus);
            }
        }

        private void Clean()
        {
            if (Validator == false)
            {
                Lbl_Channel.Text = "";
                Lbl_Volume.Text = "";
                Lbl_IsMute.Text = "";
            }
        }

        private void Btn_Mute_Click(object sender, EventArgs e)
        {
            if (Validator == true)
            {
                newtv.Mute();
                Print();
            }
        }

        private void Btn_Vol_UP_Click(object sender, EventArgs e)
        {
            if (Validator == true)
            {
                newtv.VolumeUP();
                Print();
            }
        }

        private void Btn_Vol_Down_Click(object sender, EventArgs e)
        {
            if (Validator == true)
            {
                newtv.VolumeDown();
                Print();
            }
        }

        private void Btn_Channel_UP_Click(object sender, EventArgs e)
        {
            if (Validator == true)
            {
                newtv.ChannelUP();
                Print();
            }
        }

        private void Btn_Channel_Down_Click(object sender, EventArgs e)
        {
            if (Validator == true)
            {
                newtv.ChannelDown();
                Print();
            }
        }
    }
}
