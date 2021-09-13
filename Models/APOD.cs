using System;

namespace GreetingsFromSpace.Models
{
    public class APOD
    {
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public string Copyright { get; set; }
        public string Explanation { get; set; }
    }
}
