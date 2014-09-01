using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MetroAppDemo.Classes
{
    public class SurveyQuestion
    {
        public SurveyQuestion(JObject jSubMessage)
        {
            questionId = getValue((String)jSubMessage["questionId"]);
            question = getValue((String)jSubMessage["question"]);
            questionType = getValue((String)jSubMessage["questionType"]);

            possibleAnswers = new List<string>();

            if (jSubMessage["possibleAnswers"] != null)
            {
                foreach (JObject answers in jSubMessage["possibleAnswers"])
                {
                    possibleAnswers.Add(answers["answer"].ToString());
                }
            }
        }

        public String questionId { get; set; }
        public String question { get; set; }

        public String questionType { get; set; }
        public List<String> possibleAnswers { get; set; }

        private String getValue(String value)
        {
            if (value != null) return value;

            return "";
        }


    }
}
