namespace ConsoleAppDZ7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat("ул. Строителей, дом.4, квартира 77", 12, 3, 77.5, true, false);
            House house = new House("ул. Сиреневая, дом 12", 1, 600.5, 4, 148.2);


            Buying_a_property<Flat> one = new Buying_a_property<Flat> ("Агентство недвижимости \"Этажи\"", "Петров В.В.", 120000, flat);
            one.Сontract();
            one.Price();
            
            Console.WriteLine();

            Buying_a_property<House> two = new Buying_a_property <House>("Агентство недвижимости \"Этажи\"", "Сидоров А.Д.", 200000, house);
            two.Сontract();
            two.Price();
        }
    }
}
