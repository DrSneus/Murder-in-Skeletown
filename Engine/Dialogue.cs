using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Dialogue
    {
        public string NPCDialogue;
        public double ID;
        public string[] Responses;
        public double[] ResponseID;

        public Dialogue(string npcdialogue, double id, string[] responses, double[] responseID)
        {
            NPCDialogue = npcdialogue;
            ID = id;
            Responses = responses;
            ResponseID = responseID;
        }

        public Dictionary<double, string> responseDictionary()
        {
            Dictionary<double, string> responseDict = new Dictionary <double, string>();
            for (int i = 0; i < Responses.Length; i++)
            {
                responseDict.Add(ResponseID[i], Responses[i]);
            }
            return responseDict;
        }
    }
}
