using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    public class Gesture
    {
        public string name;
        public List<string> losesTo;
        public Gesture(string name, List<string> losesTo)
        {
            this.name = name;
            this.losesTo = losesTo;
        }
    }
    
}
