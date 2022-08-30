using _3_BuilderPattern.Builders;
using _3_BuilderPattern.DirectorServices;

namespace _3_BuilderPattern.MenuService
{
    internal class Menu
    {
        private Director _director;

        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                ChooseBuilder();
                Console.WriteLine("Choose car to build:");
                Console.WriteLine("1. Default car");
                Console.WriteLine("2. Expensive car");
                Console.WriteLine("3. Premium car");
                var key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (key)
                {
                    case '1':
                        _director.BuildDefaultCar();
                        ResultOfBuying();
                        break;
                    case '2':
                        _director.BuildExpensiveCar();
                        ResultOfBuying();
                        break;
                    case '3':
                        _director.BuildPremiumCar();
                        ResultOfBuying();
                        break;
                    default:
                        Console.WriteLine("Error!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void ResultOfBuying()
        {

            Console.WriteLine("You have bought car!\n");
            Console.WriteLine(_director.GetCar().ToString());
            Console.ReadKey();
        }

        private void ChooseBuilder()
        {
            ICarBuilder builder = null;
            while (builder is null)
            {
                Console.WriteLine("Choose car model to build:");
                Console.WriteLine("1. Audi");
                Console.WriteLine("2. Daewoo");
                var key = Console.ReadKey().KeyChar;

                Console.WriteLine();
                switch (key)
                {
                    case '1':
                        builder = new AudiBuilder();
                        break;
                    case '2':
                        builder = new DaewooBuilder();
                        break;
                    default:
                        Console.WriteLine("Error!");
                        Console.ReadKey();
                        break;
                }
            }
            _director = new Director(builder);
        }
    }
}
