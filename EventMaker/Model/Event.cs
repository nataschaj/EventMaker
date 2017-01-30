using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class Event
    {
        int id;
        string Name;
        string Description;
        string Place;
        DateTime DateTime;


        public Event()
        {

        }

        public override string ToString()
        {
            return id + " " + Name + " " + Description + " " + Place + " " + DateTime;
        }
    }
}
