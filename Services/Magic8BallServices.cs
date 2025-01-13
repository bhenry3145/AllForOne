using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.Services
{
    public class Magic8BallServices
    {
        public string response = "";
        public int randomNum;
        public Random rng = new Random();

        public string EightBallResponse(string question)
        {

            randomNum = rng.Next(1, 9);

            switch (randomNum)
            {
                case 1:
                    response = "Probably not";
                    break;

                case 2:
                    response = "Certainly";
                    break;

                case 3:
                    response = "Ask again later";
                    break;

                case 4:
                    response = "Yeahhh, maybe";
                    break;

                case 5:
                    response = "Shake it with less aggression next time, no";
                    break;

                case 6:
                    response = "The opposite is true";
                    break;

                case 7:
                    response = "Sorry, not in the mood to answer currently";
                    break;

                case 8:
                    response = "In your dreams pal";
                    break;

                default:
                    response = "Welcome to outside of the 8 ball";
                    break;
            }
            return response;
        }
    }
}