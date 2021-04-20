using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_Okoronko
{
    delegate void Trains();

    class MyEvent
    {
        // Объявляем событие
        public event Trains UserEvent;

        // Используем метод для запуска события
        public void OnUserEvent()
        {
            UserEvent();
        }
    }

    class TrainsInfo
    {
        string TrName, TrStart, TrEnd;
        double TrTime;

        public TrainsInfo(string Name, string Start, string End, double Time)
        {
            this.Name = Name;
            this.Start = Start;
            this.End = End;
            this.Time = Time;
            
        }

        public string Name 
        { 
            set { TrName = value; } 
            get { return TrName; } 
        }
        public string Start 
        { 
            set { TrStart = value; } 
            get { return TrStart; } 
        }
        public string End 
        { 
            set { TrEnd = value; } 
            get { return TrEnd; } 
        }
        public double Time 
        { 
            set { TrTime = value; } 
            get { return TrTime; }
        }

        // Обработчик события
        public void TrainsInfoEvent()
        {
            Console.WriteLine("Событие вызвано!\n");
            Console.WriteLine("Название поезда: {0}\nСтанция отправления: {1}\nСтанция прибытия: {2}\nВремя в пути: {3} часов", Name, Start, End, Time);
        }
    }

    class Program
    {
        static void Main()
        {
            MyEvent  ev = new MyEvent();
            TrainsInfo train1 = new TrainsInfo(Name: "Стрела", Start: "Минск", End: "Москва", Time: 7.5) ;

            // Добавляем обработчик события
            ev.UserEvent += train1.TrainsInfoEvent;

            // Запустим событие
            ev.OnUserEvent();

            Console.ReadLine();
        }
    }

}
