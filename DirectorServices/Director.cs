using _3_BuilderPattern.Builders;
using _3_BuilderPattern.Cars;

namespace _3_BuilderPattern.DirectorServices
{
    internal class Director
    {
        private readonly ICarBuilder _carBuilder;

        public Director(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void BuildDefaultCar()
        {
            _carBuilder.Reset();
            if (_carBuilder is AudiBuilder)
                _carBuilder.BuildHeater();
        }
        public void BuildExpensiveCar()
        {
            _carBuilder.Reset();
            if (_carBuilder is AudiBuilder)
                _carBuilder.BuildHeater();

            _carBuilder.BuildAirconditioning();
        }
        public void BuildPremiumCar()
        {
            _carBuilder.Reset();
            if (_carBuilder is AudiBuilder)
                _carBuilder.BuildHeater();

            _carBuilder.BuildAirconditioning();
            _carBuilder.BuildMediaPlayer();
        }

        public Car GetCar()
        {
            return _carBuilder.GetCar();
        }
    }
}
