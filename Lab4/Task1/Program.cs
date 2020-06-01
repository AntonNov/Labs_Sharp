using System;
using System.Runtime.InteropServices;
namespace Test3
{
    public static class Music
    {
        [DllImport("winmm")]
        public static extern int PlaySound(string szSound, IntPtr hModule, int flags);
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            while (true)
            {
                Console.WriteLine("Choose track to play:\n 1.Mac Miller - Everybody\n 2.Nirvana - Smells Like Teen " +
                "Spirit\n 3.Twenty One Pilots - Nico and the Niners\n 4.Slipknot - The Devil in I" +
                "\n 5.Kendrick Lamar - Humble\n 6.Exit");
                key = Console.ReadKey(true).Key;
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Mac Miller - Everybody is playing");
                        Music.PlaySound("c:\\Music\\mac-miller-everybody.wav", new IntPtr(), 0x0001 | 0x0008);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Nirvana - Smells Like Teen Spirit is playing");
                        Music.PlaySound("c:\\Music\\nirvana-smells-like-teen-spirit.wav", new IntPtr(), 0x0001 | 0x0008);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Twenty One Pilots - Nico and the Niners is playing");
                        Music.PlaySound("c:\\Music\\twenty-one-pilots-nico-and-the-niners.wav", new IntPtr(), 0x0001 | 0x0008);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Slipknot - The Devil in I is playing");
                        Music.PlaySound("c:\\Music\\slipknot-the-devil-in-i.wav", new IntPtr(), 0x0001 | 0x0008);
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("Kendrick Lamar - Humble is playing");
                        Music.PlaySound("c:\\Music\\kendrick-lamar-humble.wav", new IntPtr(), 0x0001 | 0x0008);
                        break;
                    case ConsoleKey.D6:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
                Console.WriteLine("Press spacebar to stop");
                while (true)
                {
                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Spacebar)
                    {
                        Music.PlaySound(null, new IntPtr(), 0x0001);
                        break;
                    }
                }
                Console.Clear();
            }
        }
    }
}
