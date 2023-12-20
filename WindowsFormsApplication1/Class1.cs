using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TV
    {
        // Filed
        private int CurrentChannel = 1;
        private int CurrentVolume = 1;

        private int[] MinMaxChannel = new int[2] { 1, 20 };
        private int[] MinMaxVolume = new int[2] { 0, 100 };

        private bool IsPower = false;
        private bool IsMute = false;

        // Constant
        private const string TVMark = "SONY";
        private const string TVModel = "25497865";

        // Property
        public string TV_Mark
        {
            get
            {
                return TVMark;
            }
        }

        public string TV_Model
        {
            get
            {
                return TVModel;
            }
        }
        
        // Channels
        public void ChannelUP()
        {
         
            if (CurrentChannel < MinMaxChannel[1])
            {
                CurrentChannel++;
            }
            
        }
        public void ChannelDown()
        {
            if (CurrentChannel > MinMaxChannel[0])
            {
                CurrentChannel--;
            }
        }

        public int ChannelStatus
        {
            get
            {
                return CurrentChannel;
            }
        }


        // Volume

        public void VolumeDown()
        {
            if (CurrentVolume > MinMaxVolume[0])
            {
                CurrentVolume--;
            }
        }

        public void VolumeUP()
        {
            if (CurrentVolume < MinMaxVolume[1])
            {
                CurrentVolume++;
            }
        }

        public int VolumeStatus
        {
            get
            {
                return CurrentVolume;
            }
        }


         
        // Power
        public bool PowerStatus
        {
            get
            {
                return IsPower;
            }
        }

        public void Power()
        {
            if (IsPower == true)
            {
                IsPower = false;
            }
            else
            {
                IsPower = true;
            }
        }

        // Mute

        public void Mute()
        {
            if (IsMute == true)
            {
                IsMute = false;
            }
            else
            {
                IsMute = true;
            }
        }

        public bool MuteStatus
        {
            get
            {
                return IsMute;
            }
        }

    }
}
