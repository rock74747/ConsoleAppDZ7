using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ7
{
    public class House : IRealty
    {
        static string Realty => "частный дом";
        public int Y; // колич-во этажей в доме
         public double Square_region { get; set; } // Площадь участка

        public string Adress { get; set; }
        public int Room { get; set; }

        public double Square { get; set; }

        public House (string adress,int y, double square_region,  int room, double square) {
            this.Y = y;
            this.Square_region = square_region;
            this.Room = room;
            this.Square = square;
            this.Adress = adress;
        }
        public void Move()
        {
            Console.WriteLine($"Вид недвижимости: {Realty}, адрес: {Adress}, количество комнат: {Room}, " +
                $"количество этажей в доме: {Y}, площадь дома: {Square} кв. м., площадь участка: {Square_region} кв. м.");
        }
    }
}
