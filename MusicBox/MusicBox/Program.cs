using System.Security.Cryptography.X509Certificates;

namespace MusicBox
{
    internal class Program
    {
        public static List<Music> AllMusic = new List<Music>(0);

        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();
            Music music1 = new Music(1, "Love on the brain", "Rihanna", 220);
            Music music2 = new Music(2, "Umbrella", "Rihanna", 337);
            Music music3 = new Music(3, "Blank Space", "Taylor Swift", 272);
            AllMusic.Add(music1);
            AllMusic.Add(music2);
            AllMusic.Add(music3);
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Create Music\n2.Show musics at playlist\n3.Add music to playlist\n4.Play music");
            bool test = false;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nWhat do you want to do:");
                Console.ForegroundColor = ConsoleColor.Gray;
                int value = Convert.ToInt16(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Music music = new Music(Convert.ToInt16(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Convert.ToInt16(Console.ReadLine()));
                        AllMusic.Add(music);
                        break;
                    case 2:
                        playlist.Show();
                        break;
                    case 3:
                        for (int i = 0; i < AllMusic.Count; i++)
                        {
                            Console.WriteLine($"Id: {AllMusic[i].Id}    Name: {AllMusic[i].Name} ");
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Please enter id of music which one do you want to add playlist:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        int id = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < AllMusic.Count; i++)
                        {
                            if (id == AllMusic[i].Id)
                            {
                                playlist.AddMusic(AllMusic[i]);
                            }
                        }
                        break;
                    case 4:
                        bool test1=false;
                        playlist.Show();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Please enter id of music which one do you want to play:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < playlist.Musics.Count(); i++)
                        {
                            if (playlist.Musics[i].Id == id1)
                            {
                                if (test == false)
                                {
                                    playlist.Play(playlist.Musics[i]);
                                    test = true;
                                }
                                else if (playlist.Start <= DateTime.Now.Second)
                                {
                                    playlist.Play(playlist.Musics[i]);
                                }
                                else
                                {
                                    try
                                    {
                                        Console.WriteLine("Do you really want to change music?\nFor 'Yes' press 'H'\nFor 'No' press 'Y'");
                                        char choice = Convert.ToChar(Console.ReadLine());
                                        choice=char.ToUpper(choice);
                                        switch (choice)
                                        {
                                            case 'H':
                                                playlist.Play(playlist.Musics[i]);
                                                break;
                                            case 'Y':
                                                break;
                                            default:
                                                throw new WrongCommandException("There isn't option like that");
                                                break;
                                        }

                                    }
                                    catch (WrongCommandException)
                                    {

                                        Console.WriteLine("WrongCommandException");
                                    }
                                }
                                test1=true;
                            }
                        }
                        if (test1 == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You don't have this song in your playlist, please add");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("There isn't option like that");
                        break;
                }

            }
        }
    }
}