using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food
{
    public class Meal
    {
        private string food;
        private decimal size;
        private TimeSpan time;

        public Meal() { }
        public Meal(string food, decimal size, TimeSpan time)
        {
            this.food = food;
            this.size = size;
            this.time = time;
        }

        public string Food { get => food; set => food = value; }
        public decimal Size { get => size; set => size = value; }
        public TimeSpan Time { get => time; set => time = value; }
    }
}
