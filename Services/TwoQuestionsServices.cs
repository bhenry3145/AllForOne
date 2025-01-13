using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.Services
{
    public class TwoQuestionsServices
    {
        public string sentence = "";
         public string MakeSentence(string name, string wakingUpTime)
        {
            sentence = "Your name is " + name + " and you woke up at " + wakingUpTime;
            return sentence;
        }
    }
}