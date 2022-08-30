using _3_BuilderPattern.Cars;

namespace _3_BuilderPattern.Builders
{
    internal interface ICarBuilder
    {
        public void BuildAirconditioning();
        public void Reset();
        public void BuildMediaPlayer();
        public void BuildHeater();
        public Car GetCar();
    }
}
