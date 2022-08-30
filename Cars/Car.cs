using _3_BuilderPattern.CarFeatures;

namespace _3_BuilderPattern.Cars
{
    internal abstract class Car
    {
        protected decimal Price;
        public List<CarFeature> Features { get; set; } = new();

        public void AddFeature(CarFeature feature)
        {
            Features.Add(feature);
        }

        public decimal CountPrice()
        {
            Price += Features.Sum(carFeature => carFeature.Price);
            return Price;
        }

        public override string ToString()
        {
            return $"Car price is {CountPrice()}";
        }
    }
}
