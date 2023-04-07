using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netProject
{
   
        public class driver : person
        {
        public driver(int NoofEyes, int Height, string FaceColor, string Name): base(NoofEyes,  Height,  FaceColor,  Name) { }
            public string driverLiscence { get; set; }
            public string driverName { get; set; }


            public void Desc()
            {
                Console.WriteLine("Amy is driver");
            base.Lunch();
            }
        }

        }
    