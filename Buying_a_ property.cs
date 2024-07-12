using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ7
{
    public class Buying_a_property <T> where T : IRealty
    {
        string buyer {get; set;} // продавец
        string seller { get; set;} // покупатель
        int cost { get; set;}  // цена
        T realty { get; set;} // вид недвижимости

        public Buying_a_property (string buyer, string seller, int cost, T realty)
        {
            this.buyer = buyer;
            this.seller = seller;
            this.cost = cost;
            this.realty = realty;
        }
        public void Сontract () 
        {
            Console.WriteLine($"Продавец: {buyer}, покупатель: {seller}, стоимость недвижимости: {cost} долл.");
            realty.Move();
        }
        public void Price ()
        {
            Console.WriteLine($"Стоимость квадратного метра = {(float) (cost / realty.Square)} долл.");
        }

    }
}
