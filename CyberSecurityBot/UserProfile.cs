using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    public class UserProfile
    {
        public string Name { get; set; }
        public int MessageCount { get; set; }
        public string LastTopic { get; set; }   

        //Constroctor
        public UserProfile(string name)
        {
            Name = name;
            MessageCount = 0;
            LastTopic = " None";


        }
    }
}
