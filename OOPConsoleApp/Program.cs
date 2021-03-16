using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Press press1 = new Press();
            //Press press2 = new Press();
            //Press press3 = new Press();
            //Press press4 = new Press();
            //Press press5 = new Press();
            //Press press6 = new Press();
            //Press press7 = new Press();

            Press[] volvoPresses = new Press[7];

            //          index < 7
            for (int i = 0; i < volvoPresses.Length; i++)
            {
                volvoPresses[i] = new Press();
            }

            volvoPresses[2].TurnOn();//slå på strömmen för press nr.3


        }
    }
}
