using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        public void Play() //вот ошибка
        {
            Console.WriteLine("Запуск композиции");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза композиции");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Остановка композиции");
        }
        void IRecodable.Record()
        {
            Console.WriteLine("Запись начата");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись на паузе");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}
