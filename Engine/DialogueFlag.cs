using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class DialogueFlag
    {
        public Clue ClueReq { get; set; }
        public Item ItemReq { get; set; }
        public double NewDialoguePath { get; set; }
        public string NewResponse { get; set; }
        public Dialogue NewDialogue { get; set; }

        public DialogueFlag(Clue cluereq, Item itemreq, double newdialoguepath, string newresponse, Dialogue newdialogue)
        {
            ClueReq = cluereq;
            ItemReq = itemreq;
            NewDialoguePath = newdialoguepath;
            NewResponse = newresponse;
            NewDialogue = newdialogue;
        }
    }
}
