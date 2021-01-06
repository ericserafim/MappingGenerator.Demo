using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingGenerator.Demo.Models
{
    public class Address
    {
        public string Street { get; set; }

        public int Number { get; set; }
        
        public City City { get; set; }

        public Country Country { get; set; }

        public override string ToString() 
            => $"Street: {Street}, Number: {Number}, City: {City}, Country: {Country}";
    }


    public class AddressDto
    {
        public string Street { get; set; }

        public int Number { get; set; }

        public CityDto City { get; set; }

        public CountryDto Country { get; set; }

        public override string ToString() 
            => $"Street: {Street}, Number: {Number}, City: {City}, Country: {Country}";
    }
}
