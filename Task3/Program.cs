using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player1 = new Player();
            IRecodable player2 = new Player();
            player1.Play();
            player2.Record();
            player1.Pause();
            player2.Pause();
            player2.Stop();
            player1.Stop();
            //-----------------Задержка---------------
            Console.ReadKey();
        }
    }
}
