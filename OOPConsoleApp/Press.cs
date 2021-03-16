using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConsoleApp
{
    class Press
    {
        int pistonPos;
        bool pistonGoingDown;
        int runSpeed;
        string toolTop;
        string toolBottom;

        bool powerOn;
        bool manualMode;
        bool emergencyStop;

        public Press()
        {
            toolTop = "------";
            toolBottom = "------";
            runSpeed = 25;
            pistonGoingDown = true;
        }

        public bool EmergencyStop()
        {
            emergencyStop = true;

            return emergencyStop;
        }

        public bool ResetEmergencyStop()
        {
            emergencyStop = false;

            return emergencyStop;
        }

        public bool TurnOn()
        {
            if (!emergencyStop)
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
            if (!emergencyStop && powerOn)
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
                pistonPos += runSpeed;
            }
            else
            {
                pistonPos -= runSpeed;
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
