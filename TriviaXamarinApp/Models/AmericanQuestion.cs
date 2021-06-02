using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaXamarinApp.Models
{
    public class AmericanQuestion
    {
        public string QText { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] OtherAnswers { get; set; }
        public string CreatorNickName { get; set; }

        public AmericanQuestion()
        {

        }

        public void CreateQuestion()
        {
            this.QText = "how many noses does a slug have";
            this.CorrectAnswer = "four";
            this.OtherAnswers = new string[3];
            this.OtherAnswers[0] = "none";
            this.OtherAnswers[1] = "one";
            this.OtherAnswers[2] = "five";
            this.CreatorNickName = "michi";

        }

    }
}