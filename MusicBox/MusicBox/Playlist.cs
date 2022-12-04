using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBox
{
    internal class Playlist
    {
        List<Music> _musics;
        private int _start;

        public int Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public List<Music> Musics
        {
            get { return _musics; }
            set { _musics = value; }
        }
        public Playlist()
        {
            _musics = new List<Music>();
        }
        public void AddMusic(Music music)
        {
            _musics.Add(music);
        }

        public void Play(Music music)
        {
            foreach (Music music1 in _musics)
            {
                if (music==music1)
                {
                    Start = DateTime.Now.Second;
                    Start = Start + music.Time;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You are listenning to {music.ArtistName}-{music.Name}");
                    return;
                }
            }
            
        }

        public void Show()
        {
            for (int i = 0; i < Musics.Count; i++)
            {
                Console.WriteLine($"Id: {Musics[i].Id}    Name: {Musics[i].Name}   Artist name: {Musics[i].ArtistName}   Time: {Musics[i].Time}");
            }
        }
    }
}
