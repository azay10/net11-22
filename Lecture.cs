using System;

namespace netProject
{

    public class lecture : person
    {

        public lecture(int NoofEyes, int Height, string FaceColor, string Name) : base(NoofEyes, Height, FaceColor, Name) { }

        public string Degree { get; set; }
        public void Desc()
        {
            Console.WriteLine("shreya am lecture");
        }
    }


}
