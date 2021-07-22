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
        public Clue GiveClue;

        public Dialogue(string touser, double id, string[] responses, double[] responseID)
        {
            ToUserDialogue = touser;
            ID = id;
            Responses = responses;
            ResponseID = responseID;
            GiveItem = null;
            GiveClue = null;
        }

        public Dialogue(string touser, double id, string[] responses, double[] responseID, Item giveitem)
        {
            ToUserDialogue = touser;
            ID = id;
            Responses = responses;
            ResponseID = responseID;
            GiveItem = giveitem;
            GiveClue = null;
        }

        public Dialogue(string touser, double id, string[] responses, double[] responseID, Clue giveclue)
        {
            ToUserDialogue = touser;
            ID = id;
            Responses = responses;
            ResponseID = responseID;
            GiveClue = giveclue;
            GiveItem = null;
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

        public void AddNewResponse(string newresponses, double newresponseid)
        {
            // Adds a new response option to the dialogue tree, allowing for the usage of flags to alter dialogue
            Responses = new List<string>(Responses) { newresponses }.ToArray();
            ResponseID = new List<double>(ResponseID) { newresponseid }.ToArray();
        }
        
    }
}
