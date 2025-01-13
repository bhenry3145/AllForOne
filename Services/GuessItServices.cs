using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.Services
{
    public class GuessItServices
    {
        public string sentence = "";
        public int convertedNum;
        public bool runs;
        public int randomNum;
        public Random rng = new Random();

        public string EasyMode(string easyGuess)
        {
            randomNum = rng.Next(1,11);
            runs = int.TryParse(easyGuess, out convertedNum);
            if (runs == false)
            {
                sentence = "Please enter a number";
            }
            else
            {
                if (convertedNum > randomNum)
                {
                    sentence = "Your guess is too high!";
                }
                else if (convertedNum < randomNum)
                {
                    sentence = "Your guess is too low!";
                }
                else if (convertedNum == randomNum)
                {
                    sentence = "Your guess is correct!";
                }
            }
            return sentence;
        }

        public string MediumMode(string mediumGuess)
        {
            randomNum = rng.Next(1,51);
            runs = int.TryParse(mediumGuess, out convertedNum);
            if (runs == false)
            {
                sentence = "Please enter a number";
            }
            else
            {
                if (convertedNum > randomNum)
                {
                    sentence = "Your guess is too high!";
                }
                else if (convertedNum < randomNum)
                {
                    sentence = "Your guess is too low!";
                }
                else if (convertedNum == randomNum)
                {
                    sentence = "Your guess is correct!";
                }
            }
            return sentence;
        }

        public string HardMode(string hardGuess)
        {
            randomNum = rng.Next(1,51);
            runs = int.TryParse(hardGuess, out convertedNum);
            if (runs == false)
            {
                sentence = "Please enter a number";
            }
            else
            {
                if (convertedNum > randomNum)
                {
                    sentence = "Your guess is too high!";
                }
                else if (convertedNum < randomNum)
                {
                    sentence = "Your guess is too low!";
                }
                else if (convertedNum == randomNum)
                {
                    sentence = "Your guess is correct!";
                }
            }
            return sentence;
        }
    }
}