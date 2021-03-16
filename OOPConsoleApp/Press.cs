using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConsoleApp
{
    class Press
    {
        int pistonPos;// börjar å 0(Zero)
        bool pistonGoingDown;
        int runSpeed;
        string toolTop;
        string toolBottom;

        bool powerOn;
        bool manualMode;
        bool emergencyStop;

        public Press()//bygg en Press åt mig
        {
            toolTop = "------";
            toolBottom = "------";
            runSpeed = 25;
            pistonGoingDown = true;
        }

        public bool EmergencyStop()
        {
            emergencyStop = true;
            powerOn = false;

            return emergencyStop;
        }

        public bool ResetEmergencyStop()
        {
            emergencyStop = false;

            return emergencyStop;
        }

        public bool TurnOn()
        {
            if ( ! emergencyStop)
            {
                powerOn = true;
            }
            else
            {
                powerOn = false;
            }

            return powerOn;
        }

        public bool Run()
        {
            if ( ! emergencyStop && powerOn)
            {
                if (manualMode)
                {
                    MovePiston();
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        MovePiston();
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MovePiston()
        {
            if (pistonGoingDown)
            {
                pistonPos += runSpeed;//down
                //pistonPos = pistonPos + runSpeed;
            }
            else
            {
                pistonPos -= runSpeed;//up
            }

            if (pistonPos == 100)
            {
                pistonGoingDown = false;
            }
            if (pistonPos == 0)
            {
                pistonGoingDown = true;
            }
        }
    }
}
