using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food
{
    public class Mood
    {
        private string moods;
        private int rate;

        public Mood() { }
        public Mood(int rate)
        {
            this.rate = rate;
        }
        public Mood(string moods, int rate)
        {
            this.moods = moods;
            this.rate = rate;
        }

        public string Moods { get => moods; set => moods = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}
