using _3_BuilderPattern.Cars;
using _3_BuilderPattern.CarFeatures;

namespace _3_BuilderPattern.Builders
{

    internal class AudiBuilder : ICarBuilder
    {
        private Audi _car = new();

        public AudiBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Audi();
        }

        public void BuildAirconditioning()
        {
            var airconditioning = new Airconditioning();
            _car.AddFeature(airconditioning);
        }

        public void BuildMediaPlayer()
        {
            var mediaPlayer = new MediaPlayer();
            _car.AddFeature(mediaPlayer);
        }

        public void BuildHeater()
        {
            var seatHeater = new SeatHeater();
            _car.AddFeature(seatHeater);
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
