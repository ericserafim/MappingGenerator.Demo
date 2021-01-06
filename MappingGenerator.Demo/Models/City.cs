namespace MappingGenerator.Demo.Models
{
    public class City
    {
        public string Name { get; set; }

        public override string ToString() => Name;
    }

    public class CityDto
    {
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}