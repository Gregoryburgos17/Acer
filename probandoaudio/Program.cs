using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace probandoaudio
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Acer\source\repos\probandoaudio\audio\audio\error.wav";
            player.Play();
            Console.WriteLine("probando");
            Console.ReadKey();
        }
    }
}
