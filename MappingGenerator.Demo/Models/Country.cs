namespace MappingGenerator.Demo.Models
{
    public class Country
    {
        public string Name { get; set; }

        public override string ToString() => Name;
    }

    public class CountryDto
    {
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}