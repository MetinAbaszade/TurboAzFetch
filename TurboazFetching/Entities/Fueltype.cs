

namespace TurboazFetching.Entities
{
    public class FuelType
    {
        public int Id { get; set; }
        public List<FuelTypeLocale> FuelTypeLocales { get; set; } = new();

        public FuelType() { }
    }
}
