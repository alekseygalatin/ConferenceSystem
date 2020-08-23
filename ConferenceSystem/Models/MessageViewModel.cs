using System;

namespace ConferenceSystem.Models
{
    public class MessageViewModel
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
    }
}
