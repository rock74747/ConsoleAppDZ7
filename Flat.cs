using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ7
{
    public class Flat : IRealty 
    {
        static string Realty => "квартира";
        public int X; // этаж

        public string Adress { get; set; }
        public int Room { get; set; }

        public double Square { get; set; }

        bool balcony {  get; set; }
        bool gas { get; set; }

        public Flat (string adress, int x, int room, double square, bool balcony, bool gas) 
        { this.Adress = adress;
            this.Room = room;
            this.Square = square;
            this.balcony = balcony;
            this.gas = gas;
            this.X = x;
        }
        public void Move()
        {
            Console.WriteLine($"Вид недвижимости: {Realty}, адрес: {Adress}, количество комнат: {Room}, " +
                $"площадь: {Square} кв.м., {X} этаж,");
            if (balcony)
                Console.Write("в квартире балкон, ");
            else
                Console.Write("в квартире нет балкона, ");
            if (gas)
                Console.WriteLine("в квартире eсть газ");
            else
                Console.WriteLine("в квартире нет газа");
        }
    }
}
