using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Dialogue
    {
        public string ToUserDialogue;
        public double ID;
        public string[] Responses;
        public double[] ResponseID;
        public Item GiveItem;

        public Dialogue(string touser, double id, string[] responses, double[] responseID, Item giveitem = null)
        {
            ToUserDialogue = touser;
            ID = id;
            Responses = responses;
            ResponseID = responseID;
            GiveItem = giveitem;
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
