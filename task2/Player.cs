using System;

namespace task2
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("The record has been played.");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("The playing of the record has been paused.");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("The playing of the record has been stopped.");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("The record has been recorded.");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("The recording of the record has been paused.");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("The recording of the record has been stopped.");
        }

    }
}
