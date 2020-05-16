using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Poe1
{
    class Desk
    {
        private int materialPrice;

        public int Size { get; set; }
        public int MaterialPrice
        {
            get { return materialPrice; }
            set { materialPrice = value; }
        }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int NumOfDrawers { get; set; }
        public enum surfaceMaterial 
        {
            Oak = 200,
            Laminate = 200,
            Pine = 300,
            Veneer = 150
        };
    };
}  
