using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBox
{
    internal class Music
    {
        int _id;
        string _name;
        string _artistName;
        int _time;

        public int Id
        {
            get { return _id; }
            set 
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value; 
            }
        }
        public string ArtistName
        {
            get { return _artistName; }
            set 
            { 
                _artistName = value; 
            }
        }
        public int Time
        {
            get { return _time; }
            set 
            { 
                if(value > 0)
                {
                _time = value; 

                }
            }
        }
        public Music(int id,string name,string artistname,int time)
        {
            Id= id;
            Name= name.Capitalize();
            ArtistName= artistname.Capitalize();
            Time= time;
        }
    }
}
